// StaticFiles/firebase-messaging-sw.js
importScripts('https://www.gstatic.com/firebasejs/9.23.0/firebase-app-compat.js');
importScripts('https://www.gstatic.com/firebasejs/9.23.0/firebase-messaging-compat.js');

firebase.initializeApp({
    apiKey: 'AIzaSyB79ldqNNY0lf6lKr4vmlKcX7PX0_pfM6M',
    authDomain: 'order-food-8cf79.firebaseapp.com',
    projectId: 'order-food-8cf79',
    storageBucket: 'order-food-8cf79.appspot.com',
    messagingSenderId: '775705757390',
    appId: '1:775705757390:web:679d88bd159fd16e17f29f',
    measurementId: 'G-F7H5WV6M4Q'
});

const messaging = firebase.messaging();
