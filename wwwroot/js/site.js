function toggleMenu() {
    const menu = document.getElementById("quickMenu");
    if (menu.style.display === "block") {
        menu.style.display = "none";
    } else {
        menu.style.display = "block";
    }
}

// Esto hace que el menú se cierre si hacés clic afuera
document.addEventListener("click", function (e) {
    const menu = document.getElementById("quickMenu");
    const toggle = document.querySelector(".menu-toggle");

    if (!menu.contains(e.target) && !toggle.contains(e.target)) {
        menu.style.display = "none";
    }
});