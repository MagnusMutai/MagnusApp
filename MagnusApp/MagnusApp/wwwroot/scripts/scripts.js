﻿//let sections = document.querySelectorAll(".sub-container");
//window.onscroll = () => {
//    sections.forEach(sec => {
//        let top = window.scrollY;
//        let offset = sec.offsetTop - 150;
//        let height = sec.offsetHeight;

//        if (top >= offset && top < offset + height) {
//            sec.classList.add("show-animate");
//        }
//        //if want to use repeating animation on scroll use this
//        else {
//            sec.classList.remove("show-animate");
//        }
//    })
//};



//window.showAnimation = () => {
//    DotNet.invokeMethodAsync("MagnusApp.Client", "AddAnimation");
//};



//const boxes = document.querySelectorAll(".sub-container")
//window.addEventListener("scroll", () => {
//    const innerHeightOfWindow = window.innerHeight;
//    boxes.forEach(box => {
//        const boxTop = box.getBoundingClientRect().top
//        if (boxTop < innerHeightOfWindow) {
//            DotNet.invokeMethodAsync('MagnusApp.Client', 'AddAnimation');
//        }
//        // else {
//        //     box.classList.remove("show-animate")
//        // }
//    });
//});

//window.addEventListener('resize', () => {

//    if (window.innerWidth > 1000) {
//        DotNet.invokeMethodAsync("MagnusApp", "DisableAutoplay")
//    }
//});

if (!window.Cypress) {
    const scrollCounter = document.querySelector('.js-scroll-counter');

    AOS.init({
        mirror: true,
        once: true
    });

    document.addEventListener('aos:in', function (e) {
        console.log('in!', e.detail);
    });
}


//export function startResizeListener(dotNetHelper) {
//    window.addEventListener('resize', () => {

//        if (window.innerWidth > 1000) {
//            dotNetHelper.invokeMethodAsync("MagnusApp.Client", "DisableAutoPlay")
//        }
//    });

//    // Check on page load
//    if (window.innerWidth > 1000) {
//        dotNetHelper.invokeMethodAsync("MagnusApp.Client", "DisableAutoPlay");
//    }
//}