function formularz()
{
    alert(document.getElementById("pole1").value);
}

function oblicz()
{
    let a = document.getElementById("bok1").value;
    let b = document.getElementById("bok2").value;
    document.getElementById("div2").textContent = "Pole:" + a*b + "j²";
}

function wybor()
{
    let f = document.getElementsByName("radio");
    let v;
    for (let i = 0; i < f.length; i++)
    {
        if(f[i].checked)
        {
            v = f[i].value;
        }
    }
    alert(v);
}

function wybor2()
{
    let f = document.getElementsByName("checkbox");
    let v = "";
    for (let i = 0; i < f.length; i++)
    {
        if(f[i].checked)
        {
            v += f[i].value + " ";
        }
    }
    if(v == '') v = "nic nie zaznaczyłeś";
    alert(v);
}

function wybor3()
{
    var s = document.getElementById("ssaki");
    alert("value ma wartość: " + s.value);
    alert("selectedindex zwraca wartość: " + s.selectedIndex);
    alert("length zwraca wartość: " + s.length);
}