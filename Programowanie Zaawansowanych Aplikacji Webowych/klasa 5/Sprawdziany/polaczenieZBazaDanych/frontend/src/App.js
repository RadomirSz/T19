import Header from './components/Header';
import Main from './components/Main';
import Footer from './components/Footer';
import './App.css';

function App() {
  return (
    <div className="page">
      <Header nazwaKsiegarni="Księgarnia w Technikum 19 wita" />
      <Main />
      <Footer czasOtwarcia="zapraszamy od stycznia do grudnia" />
    </div>
  );
}

export default App;
