window.addEventListener("resize", () => {
    //console.log(`Window size: ${window.innerWidth} x ${window.innerHeight}`);
    var elements = document.getElementsByClassName("show");
    for (var i = 0; i < elements.length; i++) {
        elements[i].classList.remove("show");
    }
});