import React from 'react';
import { Row, Col } from 'react-bootstrap';

function InputForm(props) {
  return (
    <Row>
      <Col md={12}>
        <div className="input-box">
          <h3>Przykładowe obliczenia</h3>
          <Row>
            <Col sm={6} className="text-end">
              <label>proszę podać: a: </label>
            </Col>
            <Col sm={6} className='text-start'>
              <input 
                type="number" 
                value={props.a} 
                onChange={(e) => props.setA(e.target.value)}
                step="any"
              />
            </Col>
          </Row>
          <Row>
            <Col sm={6} className="text-end">
              <label>proszę podać: b: </label>
            </Col>
            <Col sm={6} className='text-start'>
              <input 
                type="number" 
                value={props.b} 
                onChange={(e) => props.setB(e.target.value)}
                step="any"
              />
            </Col>
          </Row>
          <Row>
            <Col sm={6} className="text-end">
              <label>proszę podać: c: </label>
            </Col>
            <Col sm={6} className='text-start'>
                <input 
                type="number" 
                value={props.c} 
                onChange={(e) => props.setC(e.target.value)}
                step="any"
                />
            </Col>
          </Row>
      
          {props.error && <p className="error">{props.error}</p>}
      
          <div className="button-group">
            <button className="btn-calculate" onClick={props.handleCalculate}>
              Rozpocznij obliczenia
            </button>
            <button className="btn-back" onClick={props.reset}>
              Wyczyść
            </button>
          </div>
        </div>
      </Col>
    </Row>
  );
}

export default InputForm;
