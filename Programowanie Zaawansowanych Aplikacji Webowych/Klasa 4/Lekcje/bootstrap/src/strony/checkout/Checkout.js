import React from "react";
import { Row, Col, Container } from "react-bootstrap";
import MyInput from "../../componenty/forms/MyInput";

function Checkout() {
    const [daneOsobowe, setDaneOsobowe] = React.useState({
        imie: "",
        nazwisko: ""
    });

    const changeHandler = event => {
        let inputValue = event.target.value;
        let inputName = event.target.name;
        setDaneOsobowe((prevState) => ({
            ...prevState,
            [inputName]: inputValue
        }));
    };

    return (
        <Container>
            <form>
                <Row>
                    <Col xs={12}>
                        <h1>Witamy przy kasie </h1>
                        <h2>Proszę podać dane do wysyłki: </h2>
                    </Col>
                </Row>
                <Row>
                    <Col xs={12} md={4}>
                        <MyInput
                            type="text"
                            name="imie"
                            label="Imię"
                            className="form-control"
                            value={daneOsobowe.imie}
                            onChange={changeHandler}
                        />
                    </Col>
                    <Col xs={12} md={4}>
                        <MyInput
                            type="text"
                            name="nazwisko"
                            label="Nazwisko"
                            className="form-control"
                            value={daneOsobowe.nazwisko}
                            onChange={changeHandler}
                        />
                    </Col>
                </Row>
                <br />
                <br />Wprowadzone imię: {(daneOsobowe.imie === "") ? "jeszcze nie wprowadzone" : daneOsobowe.imie}
                <br />Wprowadzone nazwisko: {(daneOsobowe.nazwisko === "") ? "jeszcze nie wprowadzone" : daneOsobowe.nazwisko}
            </form>
        </Container>
    );
}

export default Checkout;