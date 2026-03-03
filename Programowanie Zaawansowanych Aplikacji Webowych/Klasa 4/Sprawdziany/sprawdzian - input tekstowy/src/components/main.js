import { useState } from "react";

export default function Main() {
    
    const [x, setX] = useState(0);
    const [y, setY] = useState(0);
    const [wynik, setWynik] = useState(0);

    const [a, setA] = useState(0);
    const [b, setB] = useState(0);
    const [c, setC] = useState(0);

    const [wynikTrojkat, setWynikTrojkat] = useState("Podaj wartości boków trójkąta");
    const [imgSrc, setImgSrc] = useState("trojkat_rownoboczny.png");
    const paths = ["trojkat_zle.png", "trojkat_rownoboczny.png", "trojkat_rownoramienny.png", "trojkat_prostokatny.png", "trojkat.png"];

    const ustawTrojkat = (a, b, c) => {
        if (!czyTrojkat(a, b, c)) {
            setWynikTrojkat("Nie można zbudować trójkąta z podanych boków");
            setImgSrc(paths[0]);
        } else if (czyRownoboczny(a, b, c)) {
            setWynikTrojkat("Trójkąt jest równoboczny");
            setImgSrc(paths[1]);
        } else if (czyProstokatny(a, b, c)) {
            setWynikTrojkat("Trójkąt jest prostokątny");
            setImgSrc(paths[3]);
        } else if (czyRownoramienny(a, b, c)) {
            setWynikTrojkat("Trójkąt jest równoramienny");
            setImgSrc(paths[2]);
        } else {
            setWynikTrojkat("Trójkąt jest różnoboczny");
            setImgSrc(paths[4]);
        }

    };
    const dzielenie = (a, b) => {
        if (b === 0) {
            alert("Nie można dzielić przez 0!");
            return 0;
        }
        return a / b;
    }
    const czyTrojkat = (a, b, c) => {
        if (a + b > c && a + c > b && b + c > a) return true;
        return false;
    }
    const czyRownoboczny = (a, b, c) => {
        if (a === b && b === c && a === c) return true;
        return false;
    }
    const czyRownoramienny = (a, b, c) => {
        if (a === b || b === c || a === c) return true;
        return false;
    }
    const czyProstokatny = (a, b, c) => {
        if (Math.sqrt(a * a + b * b) === c || Math.sqrt(a * a + c * c) === b || Math.sqrt(b * b + c * c) === a) return true;
        return false;
    }

    return(
        <main>
            <div className="dzielenie">
                <label htmlFor="x">Proszę podać 1szą liczbę: </label>
                <input id="x" type="number" value={x} onChange={(e) => setX(Number(e.target.value))}/><br/>
                
                <label htmlFor="y">Proszę podać 2gą liczbę: </label>
                <input id="y" type="number" value={y} onChange={(e) => setY(Number(e.target.value))} /><br/>

                <input type="button" value="Podziel" onClick={() => setWynik(dzielenie(x, y))}/>
                <p className="wynik">{wynik}</p>
            </div>

            <div className="trojkaty">
                <label htmlFor="a">Proszę podać 1szą liczbę: </label>
                <input id="a" type="number" value={a} onChange={(e) => setA(Number(e.target.value))} /><br/>

                <label htmlFor="b">Proszę podać 2gą liczbę: </label>
                <input id="b" type="number" value={b} onChange={(e) => setB(Number(e.target.value))} /><br/>

                <label htmlFor="c">Proszę podać 3cią liczbę: </label>
                <input id="c" type="number" value={c} onChange={(e) => setC(Number(e.target.value))} /><br/>

                <input type="button" value="Sprawdź" onClick={() => ustawTrojkat(a, b, c)} ></input>
                <p className="wynik">{wynikTrojkat}</p>
                <img src={imgSrc} alt="obrazek" />
            </div>
        </main>
    )
}