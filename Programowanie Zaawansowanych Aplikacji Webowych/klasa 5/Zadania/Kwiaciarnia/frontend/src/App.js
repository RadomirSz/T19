import './App.css';
import { Navigate, Route, Routes } from 'react-router-dom';
import StronaKoszyka from './components/StronaKoszyka';
import StronaGlowna from './components/StronaGlowna';
import SzczegolyKwiatu from './components/SzczegolyKwiatu';
import Stopka from './components/Stopka';
import Naglowek from './components/Naglowek';
import { API_URL } from './narzedzia';

function App() {
  const image = `${API_URL}/api/images/1/kwiat.jpg`;

  return <main className="page-shell">
    <Naglowek image={image} />
    <Routes>
      <Route path="/" element={<StronaGlowna />} />
      <Route path="/koszyk" element={<StronaKoszyka />} />
      <Route path="/kwiat/:id" element={<SzczegolyKwiatu />} />
      <Route path="*" element={<Navigate to="/" replace />} />
    </Routes>
    <Stopka image={image} />
  </main>;
}

export default App;
