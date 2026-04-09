import './App.css';
import { useState } from 'react';
import TriangleGraphic from './TriangleGraphic';

function App() {
  const [dataType, setDataType] = useState("");
  const [first, setFirst] = useState("");
  const [second, setSecond] = useState("");
  const [third, setThird] = useState("");
  const [result, setResult] = useState(null);
  const [loading, setLoading] = useState(false);

  const placeholders = 
    dataType === "katy" ? 
    ["kat 1", "kat 2", "kat 3"] : ["bok 1", "bok 2", "bok 3"];

  async function handleSubmit(event) {
    event.preventDefault();

    if (!dataType) {
      alert("Prosze wybrac rodzaj danych.");
      return;
    }

    if (!first || !second || !third) {
      setResult({
        canBuild: false,
        message: "Prosze wypelnic wszystkie pola.",
      });
      return;
    }

    setLoading(true);
    try {
      const response = await fetch("/api/triangle", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ dataType, first, second, third }),
      });

      const raw = await response.text();
      let data = null;
      try {
        data = raw ? JSON.parse(raw) : null;
      } catch (parseError) {
        data = null;
      }

      if (!response.ok) {
        setResult({
          canBuild: false,
          message:
            (data && data.message) ||
            "Backend jest niedostepny lub zwrocil blad. Uruchom serwer Node i sprobuj ponownie.",
        });
        return;
      }

      setResult(
        data || {
          canBuild: false,
          message: "Serwer zwrocil nieprawidlowy format odpowiedzi.",
        }
      );
    } catch (error) {
      setResult({
        canBuild: false,
        message: "Nie udalo sie polaczyc z serwerem Node.js.",
      });
      console.error(error);
    } finally {
      setLoading(false);
    }
  }

  return (
    <main className="page">
      <section className="panel">
        <h1>Sprawdzamy trojkaty</h1>
        <form onSubmit={handleSubmit}>
          <div className="form-row">
            <label htmlFor="dataType">Prosze okreslic rodzaj danych</label>
            <select id="dataType" value={dataType} onChange={(e) => setDataType(e.target.value)}>
              <option value="">Prosze wybrac rodzaj danych</option>
              <option value="boki">boki</option>
              <option value="katy">katy</option>
            </select>
          </div>

          <div className="form-row">
            <label htmlFor="first">Prosze podac pierwsza wartosc</label>
            <input
              id="first"
              type="number"
              step="any"
              value={first}
              onChange={(e) => setFirst(e.target.value)}
              placeholder={placeholders[0]}
            />
          </div>

          <div className="form-row">
            <label htmlFor="second">Prosze podac druga wartosc</label>
            <input
              id="second"
              type="number"
              step="any"
              value={second}
              onChange={(e) => setSecond(e.target.value)}
              placeholder={placeholders[1]}
            />
          </div>

          <div className="form-row">
            <label htmlFor="third">Prosze podac trzecia wartosc</label>
            <input
              id="third"
              type="number"
              step="any"
              value={third}
              onChange={(e) => setThird(e.target.value)}
              placeholder={placeholders[2]}
            />
          </div>

          <div className="actions">
            <button type="submit" disabled={loading}>
              {loading ? "Trwa..." : "Sprawdz"}
            </button>
          </div>
        </form>

        <p className={`message ${result?.canBuild ? "ok" : "error"}`}>{result?.message || ""}</p>
        <div className="graphic">
          <TriangleGraphic result={result} />
        </div>
      </section>

      <div className="footer">Zapraszamy ponownie</div>
    </main>
  );
}

export default App;
