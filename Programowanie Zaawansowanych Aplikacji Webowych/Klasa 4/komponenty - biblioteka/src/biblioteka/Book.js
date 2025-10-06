import Header from "./naglowek/Header";
import Footer from "./stopka/Footer";
import BookOpis from "./cialo/BookOpis";


function Book(){
    return(
        <div>
            <Header nazwa="Adama Mickiewicza" miasto="Poznaniu"/>
            <BookOpis />
            <Footer/>
        </div>
    )
}

export default Book;