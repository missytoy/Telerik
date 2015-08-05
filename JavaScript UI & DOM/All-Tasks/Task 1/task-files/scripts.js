function createImagesPreviewer(containerID, animals) {

    var leftDiv = document.createElement("div");
    leftDiv.id = "left-div";
    leftDiv.style.float = "left";
    leftDiv.style.width = "70%";
    leftDiv.style.height = "100%";
    leftDiv.style.textAlign = "center";
    leftDiv.classList.add("image-preview");

    var rightDiv = document.createElement("div");
    rightDiv.id = "right-div";
    rightDiv.style.float = "right";
    rightDiv.style.width = "30%";
    rightDiv.style.height = "100%";
    rightDiv.style.overflowY = "scroll";

    var spanFilter = document.createElement("span");
    spanFilter.innerText = "Filter";

    var searchBar = document.createElement("input");
    // searchBar.setAttribute("type", "text");
    searchBar.style.height = "10%";
    searchBar.style.width = "80%";

    var divFilter = document.createElement("div");
    divFilter.appendChild(spanFilter);
    divFilter.appendChild(searchBar);
    divFilter.style.textAlign = "center";

    rightDiv.appendChild(divFilter);

    var ul = document.createElement("ul");
    var li = document.createElement("li");

    ul.style.padding = "0px";
    ul.style.listStyleType = "none";

    li.style.textAlign = "center";
    li.classList.add("image-container");

    var h1 = document.createElement("h1");
    h1.style.fontSize = "15px";
    h1.style.textAlign = "center";
    h1.style.margin = "0px";

    var image = document.createElement("img");
    image.style.textAlign = "center";
    image.style.width = "90%";
    image.style.height = "80%";
    image.style.borderRadius = "5px";

    for (var i = 0; i < animals.length; i++) {

        var currentLi = li.cloneNode(true),
            currentH1 = h1.cloneNode(true),
            currentImage = image.cloneNode(true);

        currentH1.innerText = animals[i].title;
        currentImage.src = animals[i].url;

        currentLi.appendChild(currentH1);
        currentLi.appendChild(currentImage);

        // currentLi.addEventListener("click", function () {
        //     leftDiv.innerHTML = this.innerHTML;
        //     var h = document.querySelector("#left-div h1");
        //     h.style.fontSize = "40px";
        // }, false);

        // currentLi.addEventListener("mouseover", function () {
        //     this.style.backgroundColor = "grey";
        // }, false);

        // currentLi.addEventListener("mouseout", function () {
        //     this.style.backgroundColor = "white";
        // }, false);

        ul.appendChild(currentLi);

    }

    ul.addEventListener("click", function (ev) {
        var target = ev.target.parentNode;
        leftDiv.innerHTML = target.innerHTML;
        var h = document.querySelector("#left-div h1");
        h.style.fontSize = "40px";

    }, false);

    ul.addEventListener("mouseover", function (ev) {
        var target = ev.target.parentNode;
        target.style.backgroundColor = "grey";

    }, false);

    ul.addEventListener("mouseout", function (ev) {
        var target = ev.target.parentNode;
        target.style.backgroundColor = "white";

    }, false);

    searchBar.addEventListener("keyup", function () {

        var jivotni = document.querySelectorAll("li");

        // console.log(jivotni[1]);
        // console.log(this.value);

        for (var i = 0; i < jivotni.length; i++) {

            var currentAnimal = jivotni[i],
                currentAnimalName = currentAnimal.firstChild.innerHTML.toLowerCase();

            if (currentAnimalName.indexOf(this.value.toLowerCase()) < 0) {

                currentAnimal.style.display = "none";
            } else {
                currentAnimal.style.display = "block";
            }
        }
    }, false);

    rightDiv.appendChild(ul);

    var container = document.getElementById(containerID);
    //  var container = document.querySelector('div'); //#id
    container.style.width = "550px";
    container.style.height = "400px";
    container.appendChild(leftDiv);
    container.appendChild(rightDiv);

    // return container;
}

//var fragment =document.createDocumentFragment();
//fragment.appendChild();

//if(target.tagName === "IMG")

//if(typeof element === "string"){
//    element = document.getElementById(element);
//}