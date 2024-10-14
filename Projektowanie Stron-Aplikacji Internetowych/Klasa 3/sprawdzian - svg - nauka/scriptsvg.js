function funkcja() {
    let shape = document.getElementById("Shape").value;
    let color = document.getElementById("Color").value;
    let size = document.getElementById("Size").value;
    
    let svg = '';
    if(document.getElementById("black").checked) {
        switch (shape) {
            case "rect":
                svg = `<rect x="50vw" y="10vh" width="${size}" height="${size/2}" fill="${color}" stroke="black"></rect>`;
                break;
            case "circle":
                svg = `<circle cx="50vw" cy="10vh" r="${size/2}" fill="${color}" stroke="black"></circle>`;
                break;
            case "ellipse":
                svg = `<ellipse cx="50vw" cy="10vh" rx="${size}" ry="${size/2}" fill="${color}" stroke="black"><ellipse>`;
                break;
        }
    }else if(document.getElementById("blue").checked) {
        switch (shape) {
            case "rect":
                svg = `<rect x="50vw" y="10vh" width="${size}" height="${size/2}" fill="${color}" stroke="blue"></rect>`;
                break;
            case "circle":
                svg = `<circle cx="50vw" cy="10vh" r="${size/2}" fill="${color}" stroke="blue"></circle>`;
                break;
            case "ellipse":
                svg = `<ellipse cx="50vw" cy="10vh" rx="${size}" ry="${size/2}" fill="${color}" stroke="blue"><ellipse>`;
                break;
        }
    }
    else {
        switch (shape) {
            case "rect":
                svg = `<rect x="50vw" y="10vh" width="${size}" height="${size/2}" fill="${color}"></rect>`;
                break;
            case "circle":
                svg = `<circle cx="50vw" cy="10vh" r="${size/2}" fill="${color}"></circle>`;
                break;
            case "ellipse":
                svg = `<ellipse cx="50vw" cy="10vh" rx="${size}" ry="${size/2}" fill="${color}"><ellipse>`
                break;
        }
    }
    
    document.getElementById("container").innerHTML = svg;
}
