import './App.css';
import { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Container, Row, Col } from 'react-bootstrap';

function App() {
  const [a, setA] = useState('');
  const [b, setB] = useState('');
  const [c, setC] = useState('');
  const [result, setResult] = useState(null);
  const [error, setError] = useState('');

  const handleCalculate = () => {
    setError('');
    
    const aNum = parseFloat(a);
    const bNum = parseFloat(b);
    const cNum = parseFloat(c);

    if (isNaN(aNum) || isNaN(bNum) || isNaN(cNum)) {
      setError('Wszystkie wartości muszą być liczbami');
      return;
    }

    if (aNum === 0) {
      setError('Współczynnik a nie może być równy 0');
      return;
    }

    const delta = bNum * bNum - 4 * aNum * cNum;
    const x1 = delta >= 0 ? (-bNum - Math.sqrt(delta)) / (2 * aNum) : null;
    const x2 = delta >= 0 ? (-bNum + Math.sqrt(delta)) / (2 * aNum) : null;

    setResult({
      a: aNum,
      b: bNum,
      c: cNum,
      delta,
      x1,
      x2
    });
  };

  const reset = () => {
    setA('');
    setB('');
    setC('');
    setResult(null);
    setError('');
  };

  return (
    <div className="App">
      <Container>
        <Row>
          <Col lg={10} className="mx-auto">
            <h1>Witamy na stronie: Matematyka dla każdego</h1>
        <h2>Pomożemy zrozumieć i rozwiązać: Równanie kwadratowe</h2>
        
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

        <Row>
          <Col md={12}>
            <div className="input-box">
              <h3>Przykładowe obliczenia</h3>
              <Row>
                <Col sm={4} className="text-end">
                  <label>proszę podać: a: </label>
                </Col>
                <Col sm={8}>
                  <input 
                    type="number" 
                    value={a} 
                    onChange={(e) => setA(e.target.value)}
                    step="any"
                  />
                </Col>
              </Row>
              <Row>
                <Col sm={4} className="text-end">
                  <label>proszę podać: b: </label>
                </Col>
                <Col sm={8}>
                  <input 
                    type="number" 
                    value={b} 
                    onChange={(e) => setB(e.target.value)}
                    step="any"
                  />
                </Col>
              </Row>
              <Row>
                <Col sm={4} className="text-end">
                  <label>proszę podać: c: </label>
                </Col>
                <Col sm={8}>
                  <input 
                    type="number" 
                    value={c} 
                    onChange={(e) => setC(e.target.value)}
                    step="any"
                  />
                </Col>
              </Row>
          
          {error && <p className="error">{error}</p>}
          
          <div className="button-group">
            <button className="btn-calculate" onClick={handleCalculate}>
              Rozpocznij obliczenia
            </button>
            <button className="btn-back" onClick={reset}>
              Wyczyść
            </button>
              </div>
            </div>
          </Col>
        </Row>

        {result && (
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
        )}

        <Row>
          <Col md={12}>
            <div className="interpretation-section">
          <h3>Interpretacja graficzna:</h3>
          <div className="graph-placeholder">
            {result ? (
              result.delta >= 0 ? (
                <p>Parabola przecina oś OX w {result.delta === 0 ? 'jednym' : 'dwóch'} {result.delta === 0 ? 'punkcie' : 'punktach'}</p>
              ) : (
                <p>Parabola nie przecina osi OX</p>
              )
            ) : (
              <p>Wprowadź wartości i rozpocznij obliczenia, aby zobaczyć interpretację graficzną</p>
              )}
            </div>
          </div>
        </Col>
      </Row>
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default App;
