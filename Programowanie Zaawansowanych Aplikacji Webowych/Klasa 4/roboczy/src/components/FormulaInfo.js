import React from 'react';
import { Row, Col } from 'react-bootstrap';

function FormulaInfo() {
  return (
    <Row>
      <Col md={12}>
        <div className="formula-box">
          <h3>Postać ogólna:</h3>
          <p className="formula">ax² + bx + c = 0</p>
          <p className="formula-description">wyrażnik równania kwadratowego</p>
          
          <ul className="formula-list">
            <li>delta = b² - 4ac</li>
            <li>jeśli delta &gt; 0 to równanie ma dwa rozwiązania</li>
            <li>jeśli delta = 0 to równanie ma jedno rozwiązanie</li>
            <li>jeśli delta &lt; 0 to równanie nie ma rozwiązania</li>
            <li>x₁ = (-b - √Δ) / 2a</li>
            <li>x₂ = (-b + √Δ) / 2a</li>
          </ul>
        </div>
      </Col>
    </Row>
  );
}

export default FormulaInfo;
