Vue.use(VueResource);
var resource = Vue.resource('api/categories');


//сохранение объектов
Vue.component('categories-form', {
    props: ['categories'],
    data: function () {
        return {
            name: ''
         }
    },
    template:
        '<div>' +
        '<input type="text" placeholder="название" v-model="name"/>' +
        '<input type="button" value="Сохранить" @click="save"/>' +
        '</div>',
    methods: {
        save: function () {
            var category = {name: this.name };
            resource.save({}, category).then(result =>
                result.json().then(data => {
                    this.categories.push(data);
                })
            )
        }
    }
});


//вывод объектов
Vue.component('category-row', {
    props: ['category'],
    template: '<div><i>{{category.id }}</i> {{ category.name }} '
        + '</div > '

});

Vue.component('categories-list', {
    props: ['categories'],
    template: '<div>' +
        '<categories-form :categories="categories"/>' +
        '<category-row v-for = "category in categories" :key="category.Id" :category="category" /></div> ',
    created: function () {
        resource.get().then(result =>
            result.json().then(data =>
                data.forEach(category => this.categories.push(category))
            )
        )
    }
});

var app = new Vue({
    el: '#app',
    template: '<categories-list :categories="categories"/>',
    data: {
        categories: []
    }
});