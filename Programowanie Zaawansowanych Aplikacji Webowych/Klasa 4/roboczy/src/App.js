import './App.css';
import Header from './Header';
import CarCard from './CarCard';
import Footer from './Footer';
import { carsData, companyInfo } from './data';

function App() {
  return (
    <div className="App">
      <Header 
        companyName={companyInfo.name} 
        slogan={companyInfo.slogan} 
      />

      <main className="main-content">
        <div className="cars-grid">
          {carsData.map(car => (
            <CarCard key={car.id} car={car} />
          ))}
        </div>
      </main>

      <Footer 
        openingHours={companyInfo.openingHours}
        companyName={companyInfo.name}
        year={companyInfo.established}
      />
    </div>
  );
}

export default App;
