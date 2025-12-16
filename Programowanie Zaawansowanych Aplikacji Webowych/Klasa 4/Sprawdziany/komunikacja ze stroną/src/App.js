import './App.css';
import { useState } from 'react';
import KwiatyCzerwone from './Kwiaty/KwiatyCzerwone';
import KwiatyNiebieskie from './Kwiaty/KwiatyNiebieskie';
import KwiatyFioletowe from './Kwiaty/KwiatyFioletowe';
import KwiatyZolte from './Kwiaty/KwiatyZolte';
import Naglowek from './Naglowek/Naglowek';

function App() {
  const [toggle, setToggle] = useState(false);
  const [pokazZolte, setPokażZolte] = useState(true);

  const toggleKwiaty = (takczynie) => {
    setToggle(takczynie);
    setPokażZolte(true); 
  };

  return (
    <div className="App">
      <Naglowek typ="kwiatowy" />
     
      <div className="rzad">
        <KwiatyCzerwone iloscStartowa={10}/>
        <KwiatyNiebieskie iloscRano={22} iloscWieczor={4} onToggleKwiaty={toggleKwiaty} />
      </div>
      
      {toggle && (
        <div className="rzad">
          <KwiatyFioletowe/>
          {pokazZolte && <KwiatyZolte onUkryj={() => setPokażZolte(false)}/>}
        </div>
      )}
    </div>
  );
}

export default App;
