import React, { useState } from 'react';

function Main() {
  const [figura, setFigura] = useState('');
  const [dlugosc1, setDlugosc1] = useState('');
  const [dlugosc2, setDlugosc2] = useState('');
  const [jednostka, setJednostka] = useState('');
  const [wyslijNaPoczte, setWyslijNaPoczte] = useState(false);
  const [email, setEmail] = useState('');
  const [uwagi, setUwagi] = useState('');
  const [figury] = useState([
    { value: 'kolo', label: 'Koło' },
    { value: 'prostokat', label: 'Prostokąt' },
    { value: 'kwadrat', label: 'Kwadrat' },
  ]);

  function Oblicz() {
    if (!figura || !dlugosc1 || !jednostka) {
      alert('Proszę wypełnić wszystkie wymagane pola!');
      return;
    }
    if(figura === 'prostokat' && !dlugosc2) {
      alert('Proszę podać długość 2 boku dla prostokąta!');
      return;
    }
    let wiadomoscEmail = "";
    if (wyslijNaPoczte) {
      if (email.includes('@')) {
        wiadomoscEmail = `Dane zostaną wysłane na email ${email}`;
      }
      else {
        alert('Proszę podać poprawny adres e-mail!');
        return;
      }
    }

    let obwod = ObliczObwod();
    let pole = ObliczPole();
    let wynik = `Obwód: ${obwod.toFixed(2)} ${jednostka}, Pole: ${pole.toFixed(2)} ${jednostka}²`;
    
    let out = wynik + "\n" + uwagi + "\n" + wiadomoscEmail;
    alert(out);
  }
  
  function ObliczObwod() {
    switch (figura) {
      case "kolo":
        return 2 * Math.PI * parseFloat(dlugosc1);
        
      case "prostokat":
        return 2 * (parseFloat(dlugosc1) + parseFloat(dlugosc2));
        
      case "kwadrat":
        return 4 * parseFloat(dlugosc1);
      default:
        return 0;
    }
  }
  function ObliczPole() {
    switch (figura) {
      case "kolo":
        return Math.PI * parseFloat(dlugosc1) * parseFloat(dlugosc1);
        
      case "prostokat":
        return parseFloat(dlugosc1) * parseFloat(dlugosc2);
        
      case "kwadrat":
        return parseFloat(dlugosc1) * parseFloat(dlugosc1);
      default:
        return 0;
    }
  }

  return (
    <main>
      {figura && (
        <div><img src={`${figura}.png`} alt={figura} /><br/></div>
      )}
      <label htmlFor="select" className="opispola">
        Proszę wybrać figurę:
      </label>
      <select id="select" value={figura} onChange={(e) => setFigura(e.target.value)}>
          <option value="">--Please choose an option--</option>
          {figury.map((f) => (
            <option key={f.value} value={f.value}>{f.label}</option>
          ))}
      </select><br/>

      <label htmlFor="numberInput1" className="opispola">
        Proszę podać długość 1 boku/promienia:
      </label>
      <input type="number" id="numberInput1" 
        value={dlugosc1} onChange={(e) => setDlugosc1(e.target.value)} /><br/>

      <label htmlFor="numberInput2" className="opispola">
        Proszę podać długość 2 boku (tylko dla prostokąta):
      </label>
      <input type="number" id="numberInput2" 
        value={dlugosc2} onChange={(e) => setDlugosc2(e.target.value)} /><br/>

      <div className="center">
      <p className='opispola'>Proszę wybrać jednostkę</p>

      <input type="radio" id="milimetry" name="radiobuttons"
        value="Milimetry" checked={jednostka === 'Milimetry'} 
        onChange={(e) => setJednostka(e.target.value)}/>
      <label htmlFor="milimetry">Milimetry</label><br/>

      <input type="radio" id="centymetry" name="radiobuttons"
        value="Centymetry" checked={jednostka === 'Centymetry'} 
        onChange={(e) => setJednostka(e.target.value)}/>
      <label htmlFor="centymetry">Centymetry</label><br/>

      <input type="radio" id="metry" name="radiobuttons" 
        value="Metry" checked={jednostka === 'Metry'} 
        onChange={(e) => setJednostka(e.target.value)}/>
      <label htmlFor="metry" >Metry</label><br/><br/>
      </div>

      <input type='checkbox' id="checkbox" 
        checked={wyslijNaPoczte} 
        onChange={(e) => setWyslijNaPoczte(e.target.checked)} />
      <label htmlFor="checkbox" className="opispola">
        Proszę zaznaczyć jeśli dane mają zostać wysłane na pocztę
      </label><br/>

      <label htmlFor="emailInput" className="opispola">Adres e-mail</label>
      <input type="email" id="emailInput" value={email} 
        onChange={(e) => setEmail(e.target.value)}/><br/>
      
      <label htmlFor="comments" className="opispola" style={{ verticalAlign: 'top' }}>Uwagi</label>
      <textarea id="comments" value={uwagi} 
        onChange={(e) => setUwagi(e.target.value)}></textarea><br/>

      <button onClick={Oblicz}>Oblicz / Wyslij</button>
    </main>
  );
}

export default Main;
