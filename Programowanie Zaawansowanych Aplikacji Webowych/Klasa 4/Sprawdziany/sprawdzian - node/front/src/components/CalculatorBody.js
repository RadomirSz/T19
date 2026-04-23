import ShapeGraphic from './ShapeGraphic';

function CalculatorBody(props) {
  
    const selectedShapeLabel =
    props.shapeOptions.find((shape) => shape.value === props.selectedShape)?.label || '';

  const calculationLabel =
    props.calculationType === 'surfaceArea' ? 'pole powierzchni calkowitej' : 'objetosc';

  return (
    <main className="page-body">
      <section className="calculator-panel">
        <form onSubmit={props.onSubmit}>
          <div className="field-group">
            <label htmlFor="shape-select" className="field-label">
              Wybierz bryłę
            </label>
            <select
              id="shape-select"
              className="field-select"
              value={props.selectedShape}
              onChange={props.onShapeChange}
            >
              {props.shapeOptions.map((shape) => (
                <option key={shape.value} value={shape.value}>
                  {shape.label}
                </option>
              ))}
            </select>
          </div>

          <div className="field-group">
            <label htmlFor="calculation-select" className="field-label">
              Co liczysz
            </label>
            <select
              id="calculation-select"
              className="field-select"
              value={props.calculationType}
              onChange={props.onCalculationTypeChange}
            >
              <option value="surfaceArea">Pole powierzchni calkowitej</option>
              <option value="volume">Objetosc</option>
            </select>
          </div>

          {props.selectedShape === 'stozek' && (
            <div className="field-group">
              <label htmlFor="r-input" className="field-label">
                Promien podstawy r
              </label>
              <input id="r-input" className="field-input" type="number" 
              name="r" min="1" value={props.dimensions.r} 
              onChange={props.onDimensionChange} required />
            </div>
          )}

          {props.selectedShape === 'ostroslup' && (
            <div className="field-group">
              <label htmlFor="a-input" className="field-label">
                Dlugosc podstawy a
              </label>
              <input id="a-input" className="field-input" type="number" 
              name="a" min="1" value={props.dimensions.a} 
              onChange={props.onDimensionChange} required />
            </div>
          )}

          <div className="field-group">
            <label htmlFor="h-input" className="field-label">
              Wysokosc h
            </label>
            <input id="h-input" className="field-input" type="number" 
            name="h" min="0.0001" step="any" value={props.dimensions.h} 
            onChange={props.onDimensionChange} required />
          </div>

          <button className="submit-button" type="submit" disabled={props.isLoading}>
            {props.isLoading ? 'Licze...' : 'Oblicz'}
          </button>
        </form>
      </section>

      <section className="result-panel">
        <h2 className="visual-heading">Grafika bryly</h2>
        <ShapeGraphic shape={props.selectedShape} />

        <div className="result-box">
          {props.result !== null ? (
            <p className="result-text">
              Wynik ({calculationLabel}) dla {selectedShapeLabel}: <strong>{props.result.toFixed(2)}</strong>
            </p>
          ) : ( 
            <p className="result-text">Wprowadz dane i kliknij Oblicz.</p>
          )}
        </div>

        {props.error && <p className="error-box">{props.error}</p>}
      </section>
    </main>
  );
}

export default CalculatorBody;
