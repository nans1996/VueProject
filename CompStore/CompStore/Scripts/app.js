var messageApi = Vue.resource('/api/products');

Vue.component('message-row', {
    props: ['message'],
    template: '<div><i>{{message.Id }}</i> {{message.Name}}</div>'

});

Vue.component('messages-list', {
    props: ['messages'],
    template: '<div><message-row v-for = "message in messages" :key="message.Id" :message="message"/></div>',
    created: function () {
        messageApi.get().then(result=>console.log(result))

    }
    });

var app = new Vue({
    el: '#app',
    template: '<messages-list :messages="messages"/>',
    data: {
        messages: []
    }
});