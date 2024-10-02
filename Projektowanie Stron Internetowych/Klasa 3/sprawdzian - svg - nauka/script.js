function DrawFigure() {
    var figure = document.getElementById("Shape").value;
    var color = document.getElementById("Color").value;
    var size = document.getElementById("Size").value;

    let svg = '';
    switch (figure) {
        case "rect":
            svg = `<rect x="50vw" y="10vh" width="${size}" height="${size/2}" fill="${color}" stroke="black" transform="rotate(50,${size/2},${size/2})"></rect>`;
            break;
        case "circle":
            svg = `<circle cx="50vw" cy="10vh" r="${size}" fill="${color}" stroke="black" ></circle>`;
            break;
        case "ellipse":
            svg = `<ellipse cx="50vw" cy="25vh" rx="${size}" ry="${size/2}" fill="${color}"></ellipse>`;
        default:
            break;
    }

        
    document.getElementById("SVG_Container").innerHTML = svg;
}