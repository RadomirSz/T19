import propTypes from "prop-types";

function Age(props) {
    return <h3>Juz masz {props.wiek} lat i {props.miesiac} miesiecy</h3>;
}

Age.propTypes = {
    wiek: propTypes.number.isRequired,
    miesiac: propTypes.string
}

export default Age;