import { useState } from 'react';
import './App.css';
import Header from './components/Header';
import CalculatorBody from './components/CalculatorBody';
import Footer from './components/Footer';

const opcje_bryl = [
  { value: 'stozek', label: 'Stozek' },
  { value: 'ostroslup', label: 'Ostroslup o podstawie kwadratu' }
];

function App() {
  const [shapeOptions] = useState(opcje_bryl);
  const [selectedShape, setSelectedShape] = useState(opcje_bryl[0].value);
  const [calculationType, setCalculationType] = useState('surfaceArea');
  const [dimensions, setDimensions] = useState({ r: '', a: '', h: '' });
  const [result, setResult] = useState(null);
  const [error, setError] = useState('');
  const [isLoading, setIsLoading] = useState(false);

  function handleShapeChange(event) {
    setSelectedShape(event.target.value);
    setResult(null);
    setError('');
  }

  function handleCalculationTypeChange(event) {
    setCalculationType(event.target.value);
    setResult(null);
    setError('');
  }

  function handleDimensionChange(event) {
    const { name, value } = event.target;

    setDimensions((previous) => {
      return {
        ...previous,
        [name]: value
      };
    });
  }

  function prepareDimensions() {
    if (selectedShape === 'stozek') {
      return {
        r: dimensions.r,
        h: dimensions.h
      };
    }

    return {
      a: dimensions.a,
      h: dimensions.h
    };
  }

  async function handleSubmit(event) {
    event.preventDefault();
    setIsLoading(true);
    setError('');
    setResult(null);

    try {
      const response = await fetch('http://localhost:3100/api/calculate', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          shape: selectedShape,
          calculation: calculationType,
          dimensions: prepareDimensions()
        })
      });

      let data = {};
      try {
        data = await response.json();
      } catch (parseError) {
        data = {};
      }

      if (!response.ok) {
        setError(data.error || 'Wystapil blad podczas obliczen.');
        return;
      }

      setResult(Number(data.result));
    } catch (requestError) {
      setError('Uruchom serwer node na porcie 3100.');
    } finally {
      setIsLoading(false);
    }
  }

  return (
    <div className="App">
      <Header tytul='bryły' />
      <CalculatorBody
        shapeOptions={shapeOptions}
        selectedShape={selectedShape}
        onShapeChange={handleShapeChange}
        calculationType={calculationType}
        onCalculationTypeChange={handleCalculationTypeChange}
        dimensions={dimensions}
        onDimensionChange={handleDimensionChange}
        onSubmit={handleSubmit}
        result={result}
        error={error}
        isLoading={isLoading}
      />
      <Footer termin='jutro' />
    </div>
  );
}

export default App;
