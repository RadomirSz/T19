function funkcja(input) {
    switch (input) {
        case 1:
            document.getElementById('cytat1').style.display = 'none';
            document.getElementById('cytat2').style.display = 'block';
            break;
        case 2:
            document.getElementById('cytat2').style.display = 'none';
            document.getElementById('cytat3').style.display = 'block';
            break;
        case 3:
            document.getElementById('cytat3').style.display = 'none';
            document.getElementById('cytat1').style.display = 'block';
            break;
        default:
            document.getElementById('cytat1').style.display = 'block';
            document.getElementById('cytat2').style.display = 'none';
            document.getElementById('cytat3').style.display = 'none';
            break;
    }
}