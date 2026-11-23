import { Route, Routes, useLocation } from 'react-router-dom';
import ListaKwiatow from './ListaKwiatow';
import Koszyk from './Koszyk';
import SzczegolyKwiata from './SzczegolyKwiata';
import Stopka from './Stopka';
import './App.css';

function App() {
  const { pathname } = useLocation();
  let klasaStrony = 'strona-koszyka';
  if (pathname === '/') klasaStrony = 'strona-listy';
  if (pathname.startsWith('/kwiat/')) klasaStrony = 'strona-szczegolow';

  return (
    <div className={`App ${klasaStrony}`}>
      <header className="naglowek">
        <h1>Kwiaciarnia internetowa Hortensja<br />kwiaty dla Twoich bliskich,<br />gdziekolwiek są...</h1>
        <hr className="linia-naglowka" />
      </header>
      <Routes>
        <Route path="/" element={<ListaKwiatow />} />
        <Route path="/koszyk" element={<Koszyk />} />
        <Route path="/kwiat/:id" element={<SzczegolyKwiata />} />
      </Routes>
      <Stopka />
    </div>
  );
}

export default App;
