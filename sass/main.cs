@keyframes movInLeft {
  0% {
    opacity: 0;
    transform: translateX(-10rem);
  }
  80% {
    transform: translateX(1rem);
  }
  100% {
    opacity: 1;
    transform: translateX(0);
  }
}
@keyframes movInRight {
  0% {
    opacity: 0;
    transform: translateX(10rem);
  }
  80% {
    transform: translateX(-1rem);
  }
  100% {
    opacity: 1;
    transform: translateX(0);
  }
}
@keyframes movInBottom {
  0% {
    opacity: 0;
    transform: translatey(3rem);
  }
  100% {
    opacity: 1;
    transform: translateX(0);
  }
}
*,
*::after,
*::before {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

html {
  font-size: 62.5%;
}

body {
  box-sizing: border-box;
}

body {
  font-family: "Lato" sans-serif;
  font-weight: 200;
  line-height: 1.7;
  color: #777;
  padding: 30px;
}

.header {
  height: 95vh;
  background-image: linear-gradient(to right bottom, rgba(126, 213, 111, 0), rgba(40, 180, 133, 0)), url("../img/hero.jpg");
  background-size: cover;
  background-position: top;
  clip-path: polygon(0 0, 100% 0, 100% 75vh, 0 100%);
  position: relative;
}
.header__logo-box {
  position: absolute;
  top: 4rem;
  left: 4rem;
}
.header__logo img {
  height: 4.5rem;
}
.header__text-box {
  position: absolute;
  top: 35%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #fff;
  backface-visibility: hidden;
  text-align: center;
}
.header__text-box .text-box--prim {
  display: block;
  text-transform: uppercase;
  letter-spacing: 3.5rem;
  font-size: 6rem;
  font-weight: 400;
  animation: movInLeft 0.4s ease-out;
}
.header__text-box .text-box--sub {
  display: block;
  letter-spacing: 1.5rem;
  font-size: 20px;
  font-weight: 700;
  text-align: center;
  animation: movInRight 0.4s ease-out;
  margin-bottom: 60px;
}

.heading-secondary {
  display: inline-block;
  font-size: 3.5rem;
  text-transform: uppercase;
  font-weight: 700;
  background-image: linear-gradient(to right, #7ed56f, #28b485);
  -webkit-background-clip: text;
  color: transparent;
  letter-spacing: 0.2rem;
  transition: all 0.2s;
}
.heading-secondary:hover {
  transform: skewY(2deg) skewX(15deg) scale(1.1);
  text-shadow: 0.5rem 1rem 2rem rgba(0, 0, 0, 0.2);
}

.heading-tertiary {
  font-size: 2rem;
  font-weight: 700;
  text-transform: uppercase;
}

.paragraph {
  font-size: 1.6rem;
}
.paragraph:not(:last-child) {
  margin-bottom: 3rem;
}

.u-center-text {
  text-align: center !important;
}

.u-margin-bottom-small {
  margin-bottom: 1.5rem;
}

.u-margin-bottom-med {
  margin-bottom: 5rem !important;
}

.u-margin-bottom-big {
  margin-bottom: 8rem !important;
}

.u-margin-top-big {
  margin-top: 8rem !important;
}

.u-margin-top-huge {
  margin-top: 10rem !important;
}

.section-about {
  background-color: #f7f7f7;
  padding: 25rem 0;
  margin-top: -20vh;
}

.section-features {
  padding: 20rem 0;
  background: linear-gradient(to right bottom, rgba(126, 213, 111, 0.8), rgba(40, 180, 133, 0.8)), url("../img/nat-4.jpg");
  background-size: cover;
  transform: skewY(-7deg);
  margin-top: -10rem;
}
.section-features > * {
  transform: skewY(7deg);
}

.section-tours {
  background-color: #f7f7f7;
  padding: 25rem 0 15rem 0;
  margin-top: -10rem;
}

.section-stories {
  position: relative;
  padding: 15rem 0;
}

.section-book {
  padding: 15rem 0;
  background-image: linear-gradient(to right bottom, #7ed56f, #28b485);
}

.book {
  background-image: linear-gradient(105deg, white 0%, rgba(255, 255, 255, 0.9) 50%, transparent 50%), url("../img/nat-10.jpg");
  background-size: cover;
  border-radius: 3px;
  box-shadow: 0 1.5rem 4rem rgba(0, 0, 0, 0.2);
  height: 50rem;
}
.book__form {
  width: 50%;
  padding: 6rem;
}

.btn, .btn:link, .btn:visited {
  text-transform: uppercase;
  text-decoration: none;
  padding: 15px 40px;
  display: inline-block;
  border-radius: 10rem;
  position: relative;
  font-size: 1 1.6rem;
  border: none;
  cursor: pointer;
}
.btn:hover {
  transform: translateY(-0.3rem);
  box-shadow: 0 10px 20px rgba(0, 0, 0, 0.2);
}
.btn:hover::after {
  transform: scaleX(1.4) scaleY(1.6);
  opacity: 0;
}
.btn:active, .btn:focus {
  outline: none;
  transform: translateY(-1px);
  box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
}
.btn--white {
  color: #777;
  background-color: #fff;
}
.btn--white::after {
  background-color: #fff;
}
.btn--green {
  color: #fff;
  background-color: #55c57a;
}
.btn--green::after {
  background-color: #55c57a;
}
.btn::after {
  content: "";
  display: inline-block;
  height: 100%;
  width: 100%;
  border-radius: 10rem;
  position: absolute;
  top: 0;
  left: 0;
  z-index: -1;
  transition: all 0.4s;
}
.btn--animation {
  animation: movInBottom 0.4s ease-out 0.75s;
  animation-fill-mode: backwards;
}

.btn-text:link, .btn-text:visited {
  font-size: 1.6rem;
  color: #55c57a;
  display: inline-block;
  text-decoration: none;
  border-bottom: 1px solid #55c57a;
  padding: 3px;
  transition: all 0.2s;
}
.btn-text:hover {
  background-color: #55c57a;
  color: #fff;
  box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.15);
  transform: translateY(-2px);
}
.btn-text:active {
  box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.15);
  transform: translateY(0);
}

.card {
  perspective: 150rem;
  position: relative;
  height: 52rem;
}
.card__side {
  height: 52rem;
  font-size: 2rem;
  transition: all 0.8s ease;
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  backface-visibility: hidden;
  overflow: hidden;
  border-radius: 3px;
  box-shadow: 0 1.5rem 4rem rgba(0, 0, 0, 0.15);
}
.card__side--front {
  background-color: #fff;
}
.card__side--back {
  transform: rotateY(180deg);
}
.card__side--back-1 {
  background-image: linear-gradient(to right bottom, #ffb900, #ff7730);
}
.card__side--back-2 {
  background-image: linear-gradient(to right bottom, #7ed56f, #28b485);
}
.card__side--back-3 {
  background-image: linear-gradient(to right bottom, #2998ff, #5643fa);
}
.card:hover .card__side--front {
  transform: rotateY(-180deg);
}
.card:hover .card__side--back {
  transform: rotateY(0);
}
.card__picture {
  background-size: cover;
  height: 23rem;
  background-blend-mode: screen;
  clip-path: polygon(0 0, 100% 0, 100% 85%, 0 100%);
  border-top-left-radius: 3px;
  border-top-right-radius: 3px;
}
.card__picture-1 {
  background-image: linear-gradient(to right bottom, #ffb900, #ff7730), url("../img/nat-5.jpg");
}
.card__picture-2 {
  background-image: linear-gradient(to right bottom, #7ed56f, #28b485), url("../img/nat-6.jpg");
}
.card__picture-3 {
  background-image: linear-gradient(to right bottom, #2998ff, #5643fa), url("../img/nat-7.jpg");
}
.card__heading {
  font-size: 2.8rem;
  font-weight: 300;
  text-align: right;
  text-transform: uppercase;
  color: #fff;
  position: absolute;
  top: 12rem;
  right: 2rem;
  width: 75%;
  padding: 5px;
}
.card__heading__span {
  padding: 1rem 1.5rem;
  -webkit-box-decoration-break: clone;
  box-decoration-break: clone;
}
.card__heading__span-1 {
  background-image: linear-gradient(to right bottom, #ffb900, #ff7730);
}
.card__heading__span-2 {
  background-image: linear-gradient(to right bottom, #7ed56f, #28b485);
}
.card__heading__span-3 {
  background-image: linear-gradient(to right bottom, #2998ff, #5643fa);
}
.card__info {
  padding: 3rem;
}
.card__info ul {
  list-style: none;
  width: 80%;
  margin: 0 auto;
}
.card__info li {
  text-align: center;
  font-size: 1.5rem;
  padding: 1rem;
}
.card__info li:not(:last-child) {
  border-bottom: 1px solid #000;
}
.card__cta {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 90%;
  text-align: center;
}
.card__price-box {
  text-align: center;
  color: #fff;
  margin-bottom: 8rem;
}
.card__price-only {
  font-size: 1.4rem;
  text-decoration: uppercase;
}
.card__price-value {
  font-size: 6rem;
  font-weight: 100;
}

.composition {
  position: relative;
}
.composition__photo {
  width: 55%;
  box-shadow: 0 1.5rem 4rem rgba(0, 0, 0, 0.4);
  border-radius: 2px;
  position: absolute;
  transform: all 0.2s;
  z-index: 10;
  outline-offset: 1.5rem;
}
.composition__photo--p1 {
  left: 0;
  top: -2rem;
}
.composition__photo--p2 {
  right: 0;
  top: 2rem;
}
.composition__photo--p3 {
  left: 20%;
  top: 10rem;
}
.composition__photo:hover {
  outline: 1.5rem solid #55c57a;
  transform: scale(1.05) translateY(-0.5rem);
  box-shadow: 0 2.5rem 4rem rgba(0, 0, 0, 0.5);
  z-index: 20;
}
.composition:hover .composition__photo:not(:hover) {
  transform: scale(0.95);
}

.feature-box {
  background-color: rgba(255, 255, 255, 0.8);
  font-size: 1.5rem;
  padding: 2.5rem;
  text-align: center;
  border-radius: 3px;
  box-shadow: 0 1.5rem 4rem rgba(0, 0, 0, 0.15);
  transition: transform 0.3s;
}
.feature-box__icon {
  font-size: 6rem;
  margin-bottom: 0.5rem;
  display: inline-block;
  background-image: linear-gradient(to right, #7ed56f, .feature-box__icon color-primary-dark);
  background-clip: text;
  color: #7ed56f;
}
.feature-box:hover {
  transform: translateY(-1.5rem) scale(1.03);
}

.form__group:not(:last-child) {
  margin-bottom: 2rem;
}
.form__input {
  font-size: 1.5rem;
  font-family: inherit;
  color: inherit;
  padding: 1.5rem 2rem;
  border-radius: 2px;
  background-color: rgba(255, 255, 255, 0.5);
  border: none;
  border-bottom: 3px solid transparent;
  width: 90%;
  display: inline-block;
  transition: all 0.3s;
}
.form__input:focus {
  outline: none;
  box-shadow: 0 3rem 2rem rgba(0, 0, 0, 0.1);
  border-bottom: 3px solid #55c57a;
}
.form__input:focus:invalid {
  border-bottom: 3px solid #ff7730;
}
.form__input::-webkit-input-placeholder {
  color: #999;
}
.form__label {
  font-size: 1.3rem;
  font-weight: 700;
  margin-left: 2rem;
  margin-top: 0.7rem;
  display: block;
  transition: all 0.3s;
}
.form__input:placeholder-shown + .form__label {
  opacity: 0;
  visibility: hidden;
  transform: translateY(-4rem);
}
.form__radio-group {
  width: 50%;
  float: left;
}
.form__radio-input {
  display: none;
}
.form__radio-label {
  font-size: 1.6rem;
  cursor: pointer;
  position: relative;
  padding-left: 4.5rem;
}
.form__radio-button {
  height: 3rem;
  width: 3rem;
  border: 5px solid #55c57a;
  border-radius: 50%;
  display: inline-block;
  position: absolute;
  left: 0;
  top: -0.4rem;
}
.form__radio-button::after {
  content: "";
  display: block;
  height: 1.3rem;
  width: 1.3rem;
  border-radius: 50%;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  background-color: #55c57a;
  opacity: 0;
  transition: opacity 0.2s;
}
.form__radio-input:checked ~ .form__radio-label .form__radio-button::after {
  opacity: 1;
}

.story {
  width: 75%;
  margin: 0 auto;
  box-shadow: 0 3rem 6rem rgba(0, 0, 0, 0.1);
  background-color: rgba(255, 255, 255, 0.8);
  border-radius: 10px;
  padding: 6rem;
  font-size: 1.6rem;
  transform: skew(-12deg);
}
.story__shape {
  width: 15rem;
  height: 15rem;
  background-color: #fff;
  float: left;
  transform: translateX(-3rem) skewX(12deg);
  position: relative;
}
.story__img {
  height: 100%;
  transform: translateX(-4rem) scale(1.4);
  backface-visibility: hidden;
  transition: all 0.5s;
}
.story__text {
  transform: skewX(12deg);
}
.story__caption {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, 20%);
  font-size: 1.7rem;
  color: #fff;
  text-transform: uppercase;
  text-align: center;
  opacity: 0;
  transition: all 0.5s;
  backface-visibility: hidden;
}
.story:hover .story__caption {
  opacity: 1;
  transform: translate(-50%, -50%);
}
.story:hover .story__img {
  transform: translateX(-4rem) scale(1);
  filter: blur(3px) brightness(80%);
}

.bg-video {
  position: absolute;
  top: 0;
  left: 0;
  height: 100%;
  width: 100%;
  z-index: -1;
  opacity: 0.15;
  overflow: hidden;
}
.bg-video__content {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.header {
  height: 95vh;
  background-image: #fff;
  background-size: cover;
  background-position: top;
  clip-path: polygon(0 0, 100% 0, 100% 75vh, 0 100%);
  position: relative;
}
.header__logo-box {
  position: absolute;
  top: 4rem;
  left: 4rem;
}
.header__logo img {
  height: 4.5rem;
}
.header__text-box {
  position: absolute;
  top: 35%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #fff;
  backface-visibility: hidden;
  text-align: center;
}
.header__text-box .text-box--prim {
  display: block;
  text-transform: uppercase;
  letter-spacing: 3.5rem;
  font-size: 6rem;
  font-weight: 400;
  animation: movInLeft 0.4s ease-out;
}
.header__text-box .text-box--sub {
  display: block;
  letter-spacing: 1.5rem;
  font-size: 20px;
  font-weight: 700;
  text-align: center;
  animation: movInRight 0.4s ease-out;
  margin-bottom: 60px;
}

.row {
  max-width: 114rem;
  margin: 0 auto;
}
.row:not(:last-child) {
  margin-bottom: 8rem;
}
.row::after {
  content: "";
  display: table;
  clear: both;
}
.row [class^=col-] {
  float: left;
}
.row [class^=col-]:not(:last-child) {
  margin-right: 6rem;
}
.row .col-1-of-2 {
  width: calc((100% - 6rem) / 2);
}
.row .col-1-of-3 {
  width: calc((100% - 2 * 6rem) / 3);
}
.row .col-2-of-3 {
  width: calc( 2 * (((100% - 2 * 6rem) / 3)) + 6rem);
}
.row .col-1-of-4 {
  width: calc((100% - 3 * 6rem) / 4);
}
.row .col-2-of-4 {
  width: calc( 2 * (((100% - 3 * 6rem) / 4)) + 6rem);
}
.row .col-3-of-4 {
  width: calc( 3 * (((100% - 3 * 6rem) / 4)) + 2 * 6rem);
}

.footer {
  padding: 10rem 0;
  background-color: #333;
  font-size: 1.4rem;
  color: #f7f7f7;
}
.footer__logo-box {
  text-align: center;
  margin-bottom: 8rem;
}
.footer__logo {
  width: 15rem;
  height: auto;
}
.footer__navigation {
  border-top: 1px solid #777;
  padding-top: 2rem;
  display: inline-block;
}
.footer__list {
  list-style: none;
}
.footer__items {
  display: inline-block;
}
.footer__items:not(:last-child) {
  margin-right: 1.5rem;
}
.footer__link:link, .footer__link:visited {
  color: #f7f7f7;
  background-color: #333;
  text-decoration: none;
  text-transform: uppercase;
  display: inline-block;
  transition: all 0.2s;
}
.footer__link:hover, .footer__link:active {
  color: #55c57a;
  box-shadow: 0 1rem 2rem rgba(0, 0, 0, 0.4);
  transform: rotate(5deg) scale(1.3);
}
.footer__copyright {
  border-top: 1px solid #777;
  padding-top: 2rem;
  width: 80%;
  float: right;
}

.navigation__checkbox {
  display: none;
}
.navigation__button {
  background-color: #fff;
  height: 7rem;
  width: 7rem;
  border-radius: 50%;
  position: fixed;
  top: 6rem;
  right: 6rem;
  z-index: 200;
  box-shadow: 0 1rem 3rem rgba(0, 0, 0, 0.1);
  text-align: center;
  cursor: pointer;
}
.navigation__background {
  height: 6rem;
  width: 6rem;
  border-radius: 50%;
  position: fixed;
  top: 6.5rem;
  right: 6.5rem;
  background-image: radial-gradient(#7ed56f, #28b485);
  z-index: 100;
  transition: all 0.8s cubic-bezier(0.86, 0, 0.07, 1);
}
.navigation__nav {
  height: 100vh;
  position: fixed;
  top: 0;
  right: 0;
  z-index: 150;
  opacity: 0;
  width: 0;
  transition: all 0.8s cubic-bezier(0.68, -0.55, 0.265, 1.55);
}
.navigation__list {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  list-style: none;
  text-align: center;
  width: 100%;
}
.navigation__item {
  margin: 1rem;
}
.navigation__link:link, .navigation__link:visited {
  display: inline-block;
  font-size: 3rem;
  font-weight: 300;
  padding: 1rem 2rem;
  color: #fff;
  text-decoration: none;
  text-transform: uppercase;
  background-image: linear-gradient(120deg, transparent 0%, transparent 50%, #fff 50%);
  background-size: 220%;
  transition: all 0.2s;
}
.navigation__link:link span, .navigation__link:visited span {
  display: inline-block;
  margin-right: 1.5rem;
}
.navigation__link:hover, .navigation__link:active {
  background-position: 100%;
  color: #55c57a;
  transform: translateX(1rem);
}
.navigation__checkbox:checked ~ .navigation__background {
  transform: scale(80);
}
.navigation__checkbox:checked ~ .navigation__nav {
  opacity: 1;
  width: 100%;
}
.navigation__icon {
  position: relative;
  margin-top: 3.5rem;
}
.navigation__icon, .navigation__icon::before, .navigation__icon::after {
  width: 3rem;
  height: 2px;
  background-color: red;
  display: inline-block;
}
.navigation__icon::before, .navigation__icon::after {
  content: "";
  position: absolute;
  left: 0;
  transition: all 0.2s;
}
.navigation__icon::before {
  top: -0.8rem;
}
.navigation__icon::after {
  top: 0.8rem;
}
.navigation__button:hover .navigation__icon::before {
  top: -1rem;
}
.navigation__button:hover .navigation__icon::after {
  top: 1rem;
}
.navigation__checkbox:checked + .navigation__button .navigation__icon {
  background-color: transparent;
}
.navigation__checkbox:checked + .navigation__button .navigation__icon::before {
  top: 0;
  transform: rotate(135deg);
}
.navigation__checkbox:checked + .navigation__button .navigation__icon::after {
  top: 0;
  transform: rotate(-135deg);
}

/*# sourceMappingURL=main.cs.map */
