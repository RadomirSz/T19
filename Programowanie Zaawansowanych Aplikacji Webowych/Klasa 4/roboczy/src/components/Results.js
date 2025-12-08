import React from 'react';
import { Row, Col } from 'react-bootstrap';

function Results({ result }) {
  if (!result) return null;

  return (
    <Row>
      <Col md={12}>
        <div className="results-box">
          <h3>Wyniki obliczeń</h3>
          
          <Row>
            <Col md={12}>
              <div className="result-data">
                <p>
                  <strong>Masz dane:</strong> a={result.a}, b={result.b}, c={result.c}
                </p>
              </div>
            </Col>
          </Row>

          <Row>
            <Col md={12}>
              <div className="calculation">
                <h4>Obliczenia:</h4>
                <p className="formula">Δ = b² - 4ac = {result.delta.toFixed(2)}</p>
                
                <Row>
                  <Col md={12}>
                    {result.delta > 0 && (
                      <div className="solution">
                        <p>Delta jest większa od zera, więc równanie ma dwa rozwiązania:</p>
                        <p>x₁ = {result.x1.toFixed(2)}</p>
                        <p>x₂ = {result.x2.toFixed(2)}</p>
                      </div>
                    )}
                    
                    {result.delta === 0 && (
                      <div className="solution">
                        <p>Delta jest równa zero, więc równanie ma jedno rozwiązanie:</p>
                        <p>x = {result.x1.toFixed(2)}</p>
                      </div>
                    )}
                    
                    {result.delta < 0 && (
                      <div className="solution">
                        <p>Delta jest mniejsza od zera, więc równanie nie ma rozwiązania w liczbach rzeczywistych</p>
                      </div>
                    )}
                  </Col>
                </Row>
              </div>
            </Col>
          </Row>
        </div>
      </Col>
    </Row>
  );
}

export default Results;
