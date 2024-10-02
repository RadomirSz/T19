function DrawFigure() {
    var figure = document.getElementById("Shape").value;
    var color = document.getElementById("Color").value;
    var size = document.getElementById("Size").value;

    switch (size) {
        case "small":
            size = 200;
            break;
        case "medium":
            size = 400;
            break;
        case "large":
            size = 600;
            break;
    }

    let svg = '';

    if (figure === "rect") {
        svg = `<svg width="${size * 2}px" height="${size * 2}px">
            <g id="figura">
                <rect x="${size / 2}" y="${size / 2}" width="${size}" height="${size}" fill="${color}" stroke="black"></rect>
            </g>
        </svg>`;
    } else if (figure === "circle") {
        svg = `<svg width="${size}px" height="${size}px">
            <g id="figura">
                <circle cx="${size / 2}" cy="${size / 2}" r="${size / 2}" fill="${color}" stroke="black"></circle>
            </g>
        </svg>`;
    }

    document.getElementById("SVG_Container").innerHTML = svg;   
}