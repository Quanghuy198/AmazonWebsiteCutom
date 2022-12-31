$(document).ready(function () {
    $(".owl-carousel").owlCarousel();
});

$('#discover').owlCarousel({
    loop: false,
    margin: 20,
    nav: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 3
        },
        1000: {
            items: 6
        }
    }


});


$('#feed-carousel-product').owlCarousel({
    loop: true,
    margin: 20,
    nav: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 3
        },
        1000: {
            items: 7
        }
    }
});

$('#feed-carousel-product-7').owlCarousel({
    loop: true,
    margin: 20,
    nav: true,
    responsive: {
        0: {
            items: 1
        },
        600: {
            items: 3
        },
        1000: {
            items: 7
        }
    }
});


//code for btn see all in hmenu
{
    let btnSeeAll = document.getElementsByClassName("item-see-all");
    // console.log(btnSeeAll);
    for (let i = 0; i < btnSeeAll.length; ++i) {
        btnSeeAll[i].onclick = function (e) {
            // console.log(this);
            // console.log(this.parentElement.parentElement);
            let parentElement = this.parentElement.parentElement;
            let compressE = parentElement.getElementsByClassName("compressed");
            console.log(compressE);
            compressE[0].style.display = "block";
            this.style.display = "none";
        };
    };
};

//code for btn see less in hmenu

{
    let btnSeeLess = document.getElementsByClassName("item-see-less");
    // console.log(btnSeeLess);
    for (let i = 0; i < btnSeeLess.length; ++i) {
        btnSeeLess[i].onclick = function (e) {
            // console.log(this);
            console.log(this.parentElement.parentElement);
            let parentElement = this.parentElement.parentElement;
            let compressE = parentElement.getElementsByClassName("compressed");
            // console.log(compressE);
            compressE[0].style.display = "none";
            parentElement.getElementsByClassName("item-see-all")[0].style.display = "flex";
        };
    };
};

//code for show hmenu detail
{
    let liElement = document.getElementsByClassName("hmenu-wrap-item");
    // console.log(liElement);
    for (let i = 0; i < liElement.length; ++i) {

        // console.log(dataMenuId);
        liElement[i].onclick = function (e) {
            let dataMenuId = this.getAttribute("data-menu-id");
            // console.log(dataMenuId)
            if (dataMenuId) {
                let itemElement = document.querySelectorAll("[data-menu-id='" + dataMenuId + "']");
                // console.log(itemElement);
                let wrapHmenu = itemElement[0].parentElement.parentElement.parentElement;

                // wrapHmenu.style.display ="none";
                // console.log(itemElement[1].parentElement);
                let menuDetail = itemElement[1].parentElement;

                menuDetail.style.transform = "translateX(-100%)";
                wrapHmenu.style.transform = "translateX(-100%)";
                menuDetail.classList.add("visible-hmenu");

            } else {
                e.preventDefault();
            }
        }

    }
};

//code for return main menu
{
    let btnReturnMn = document.querySelector(".btn-Main-menu");
    // console.log(btnReturnMn);

    btnReturnMn.onclick = function (e) {
        // console.log(this);
        let menuDetail = document.querySelector(".menu-detail");
        let wrapHMenu = document.querySelector(".wrap-main-menu");
        // console.log(menuDetail);
        menuDetail.style.transform = "translateX(0)";
        wrapHMenu.style.transform = "translateX(0)";
    }

}








