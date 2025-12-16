import React from 'react';
import { Row, Col } from 'react-bootstrap';

function GraphInterpretation(props) {
    var result = props.result;
    
    const getGraphImage = () => {
        if (!result) {
            return null;
        }
        
        const aValue = parseFloat(props.a);
        const folder = aValue > 0 ? 'positive' : 'negative';
        let imageName = '';
        
        if (result.delta > 0) {
            imageName = 'twopoints.jpg';
        } else if (result.delta === 0) {
            imageName = 'onepoint.jpg';
        } else {
            imageName = 'nopoints.jpg';
        }
        
        return `${process.env.PUBLIC_URL}/graphic/${folder}/${imageName}`;
    };
    
  return (
    <Row>
      <Col md={12}>
        <div className="interpretation-section">
          <h3>Interpretacja graficzna:</h3>
          <div className="graph-placeholder">
            {result ? (
                <img src={getGraphImage()} alt="Wykres funkcji kwadratowej" style={{maxWidth: '100%', height: 'auto'}} />
            ) : (
                <p>Wprowadź wartości i rozpocznij obliczenia, aby zobaczyć interpretację graficzną</p>
            )}
          </div>
        </div>
      </Col>
    </Row>
  );
}

export default GraphInterpretation;
