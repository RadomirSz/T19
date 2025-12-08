import React from 'react';
import { Row, Col } from 'react-bootstrap';

function GraphInterpretation(props) {
    var result = props.result;
  return (
    <Row>
      <Col md={12}>
        <div className="interpretation-section">
          <h3>Interpretacja graficzna:</h3>
          <div className="graph-placeholder">
            {result ? (
                    props.a > 0 ? 
                    (
                        result.delta > 0 ? (<img src="./positive/twopoints.jpg"></img>):(<p></p>)
                    ) : (
                    <p>Parabola nie przecina osi OX</p>
                    )
                ) : (
                    <p>Wprowadź wartości i rozpocznij obliczenia, aby zobaczyć interpretację graficzną</p>
                )
            }
          </div>
        </div>
      </Col>
    </Row>
  );
}

export default GraphInterpretation;
