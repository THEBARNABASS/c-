
import React, { useContext, useEffect, useState } from "react";
import MainContent from "../../components/MainContent/MainContent";
import Title from "../../components/Title/Title";
import Table from "./TableDep/TableDep";
import Container from "../../components/Container/Container";
import { Select } from "../../components/FormComponents/FormComponents";
import Spinner from "../../components/Spinner/Spinner";
import Modal from "../../components/Modal/Modal";
import api, {
  eventsResource,
  commentaryEventResource,
} from "../../Services/Service";

import "./DetalhesEventoPage.css";
import { UserContext } from "../../context/AuthContext";

const DetalhesEventoPage = () => {
  // state do menu mobile

  const [eventos, setEventos] = useState([]);
  // select mocado
  // const [quaisEventos, setQuaisEventos] = useState([
  const quaisEventos = [
    { value: 1, text: "Todos os eventos" },
  
  ];

  const [tipoEvento, setTipoEvento] = useState("1"); //código do tipo do Evento escolhido
  const [showSpinner, setShowSpinner] = useState(false);
  const [showModal, setShowModal] = useState(false);

  // recupera os dados globais do usuário
  const { userData } = useContext(UserContext);
  const [comentario, setComentario] = useState("");
  const [idEvento, setIdEvento] = useState("");
  const [idComentario, setIdComentario] = useState(null);

  useEffect(() => {
    loadMyCommentary();
  }, [comentario, userData.userId]); //


  const showHideModal = (idEvent) => {
    // console.clear();
    // console.log("id do evento atual");
    // console.log(idEvent);

    setShowModal(showModal ? false : true);
    // setUserData({ ...userData, idEvento: idEvent });
    setIdEvento(idEvent);
    // console.log("após guardar no state do usuário");
    // console.log(idEvent);
  };

  // ler um comentário - get
  const loadMyCommentary = async (idUsuario, comentario) => {
    // console.log("fui chamado");

    try {
      // api está retornando sempre todos os comentários do usuário
      const promise = await api.get(
        `${commentaryEventResource}?idUsuario=${idUsuario}&idComentario=${comentario}`
      );

      const myComm = await promise.data.filter(
        (comm) => comm.comentario === idComentario && comm.idUsuario === idUsuario
      );


      setComentario(myComm.length > 0 ? myComm[0].descricao : "");
      setIdComentario(myComm.length > 0 ? myComm[0].idComentarioEvento : null);
    } catch (error) {
      console.log("Erro ao carregar o evento");
      console.log(error);
    }
  };



  return (
    <>
      <MainContent>
        <Container>
          <Title titleText={"Eventos"} additionalClass="custom-title" />

          <Table
            dados={eventos }
            fnShowModal={showHideModal}
          /> 
        </Container>
      </MainContent>
      {/* SPINNER -Feito com position */}
      {showSpinner ? <Spinner /> : null}

      {showModal ? (
        <Modal
          // userId={userData.userId}
          showHideModal={showHideModal}
          fnGet={loadMyCommentary}
        //   fnPost={postMyCommentary}
        //   fnDelete={commentaryRemove}
          comentaryText={comentario}
          userId={userData.userId}
          idEvento={idEvento}
          idComentario={idComentario}
        />
      ) : null}
    </>
  );
};

export default DetalhesEventoPage;









    // /* <Select
    //         id="id-tipo-evento"
    //         name="tipo-evento"
    //         required={true}
    //         options={quaisEventos} // aqui o array dos tipos
    //         manipulationFunction={(e) => myEvents(e.target.value)} // aqui só a variável state
    //         defaultValue={tipoEvento}
    //         additionalClass="select-tp-evento"
    //       /> 
      
