import './App.css';
import Header from './Header';
import CarCard from './CarCard';
import Footer from './Footer';
import { oldCarsData, newCarsData, companyInfo, rodzajeAut } from './data';

function App() {
  return (
    <div className="App">
      
      <Header 
        companyInfo={companyInfo}
      />

      <main className="main-content">
        <div className="left">
          <h3>Polecamy {rodzajeAut.pierwszy} samochody w najlepszej cenie</h3>
          {oldCarsData.map(car => (
            <CarCard key={"old-" + car.id} car={car} />
          ))}
        </div>
        <div className="right">
          <h3>Polecamy {rodzajeAut.drugi} samochody w najlepszej cenie</h3>
          {newCarsData.map(car => (
            <CarCard key={"new-" + car.id} car={car} />
          ))}
        </div>
      </main>

      <Footer 
        companyInfo={companyInfo}
      />
    </div>
  );
}

export default App;
