import logo from './resources/logo.png';
import './App.css';
import Header from './strona/Header/Header';
import Footer from './strona/Footer/Footer';
import Menu from './strona/Body/Menu';

function App() {
  return (
    <div className="App">
      <Header type="naszej kawiarni"/>
      <img src={logo} alt="logo" />
      <div className="menus">
        <Menu name="napoje" productList={["Kawa biała","Herbata zielona", "Herbata owocowa"]} />
        <Menu name="ciasta" productList={["Pączki","Sernik", "drożdżówki"]} />
      </div>
      <Footer openHour="8:00" closeHour="12:35 " />
    </div>
  );
}

export default App;
