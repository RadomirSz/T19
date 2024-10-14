function funkcja() {
    let color = document.getElementById("Color").value;
    let size = document.getElementById("Size").value;
        
    let svg = '';
    if(document.getElementById("stroke").checked){
        if(document.getElementById("rect").checked)
            {
                svg = `<rect x="45vw" y="${size}" width="${size}" height="${size/2}" fill="${color}" stroke="black"></rect>`;     
            }
            else if(document.getElementById("circle").checked){
                svg = `<circle cx="50vw" cy="${size}" r="${size/2}" fill="${color}" stroke="black"></circle>`;
            }
            else if(document.getElementById("ellipse").checked){
                svg = `<ellipse cx="50vw" cy="${size}" rx="${size}" ry="${size/2}" fill="${color}" stroke="black"><ellipse>`
            }
    }
    else{
        if(document.getElementById("rect").checked)
            {
                svg = `<rect x="45vw" y="${size}" width="${size}" height="${size/2}" fill="${color}"></rect>`;     
            }
            else if(document.getElementById("circle").checked){
                svg = `<circle cx="50vw" cy="${size}" r="${size/2}" fill="${color}"></circle>`;
            }
            else if(document.getElementById("ellipse").checked){
                svg = `<ellipse cx="50vw" cy="${size}" rx="${size}" ry="${size/2}" fill="${color}"><ellipse>`
            }
    }
    


    document.getElementById("output").innerHTML = `<svg width="100vw" height="${size*3}">` + svg + `</svg>`;
}