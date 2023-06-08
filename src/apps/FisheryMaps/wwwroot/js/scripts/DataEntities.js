/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	// The require scope
/******/ 	var __webpack_require__ = {};
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};
/*!*********************************!*\
  !*** ./scripts/DataEntities.ts ***!
  \*********************************/
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   FisheryData: () => (/* binding */ FisheryData),
/* harmony export */   HotSpot: () => (/* binding */ HotSpot),
/* harmony export */   MapPoint: () => (/* binding */ MapPoint)
/* harmony export */ });
var FisheryData = /** @class */ (function () {
    function FisheryData() {
        this.name = String();
        this.latitude = 0.0;
        this.longitude = 0.0;
        this.active = false;
        this.nonce = String();
        this.hotspots = [];
    }
    return FisheryData;
}());

var MapPoint = /** @class */ (function () {
    function MapPoint() {
        this.latitude = 0.0;
        this.longitude = 0.0;
    }
    return MapPoint;
}());

var HotSpot = /** @class */ (function () {
    function HotSpot() {
        this.species = String();
        this.season = String();
        this.techniques = [];
        this.coordinates = [];
    }
    return HotSpot;
}());


/******/ })()
;
//# sourceMappingURL=DataEntities.js.map