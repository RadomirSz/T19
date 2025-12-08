import './App.css';
import { useState } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import { Container, Row, Col } from 'react-bootstrap';
import Header from './components/Header';
import FormulaInfo from './components/FormulaInfo';
import InputForm from './components/InputForm';
import Results from './components/Results';
import GraphInterpretation from './components/GraphInterpretation';
import { calculateQuadraticEquation } from './utils/calculations';

function App() {
  const [a, setA] = useState('');
  const [b, setB] = useState('');
  const [c, setC] = useState('');
  const [result, setResult] = useState(null);
  const [error, setError] = useState('');

  const handleCalculate = () => {
    setError('');
    
    const calculation = calculateQuadraticEquation(a, b, c);
    
    if (calculation.error) {
      setError(calculation.error);
      return;
    }

    setResult(calculation);
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
            <Header />
            <FormulaInfo />
            <InputForm 
              a={a}
              b={b}
              c={c}
              setA={setA}
              setB={setB}
              setC={setC}
              error={error}
              handleCalculate={handleCalculate}
              reset={reset}
            />
            <Results result={result} />
            <GraphInterpretation result={result} a={a}/>
          </Col>
        </Row>
      </Container>
    </div>
  );
}

export default App;
