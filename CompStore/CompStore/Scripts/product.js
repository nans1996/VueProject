Vue.use(VueResource);
var resource = Vue.resource('api/products');


//сохранение объектов
Vue.component('products-form', {
    props:['products'],
    data: function () {
        return {
            ident: '',
            name: '',
            id_cat: '',
            id_sup: '',
            country: '',
            number: '',
            price: '',
            acc_date:''
        }
    },
    template:
        '<div>' +
        '<input type="text" placeholder="идентификатор" v-model="ident"/>' +
        '<input type="text" placeholder="название" v-model="name"/>' +
        '<input type="number" placeholder="категория" v-model="id_cat"/>' +
        '<input type="number" placeholder="поставщик" v-model="id_sup"/>' +
        '<input type="text" placeholder="страна" v-model="country"/>' +
        '<input type="number" placeholder="количесво" v-model="number"/>' +
        '<input type="number" placeholder="цена" v-model="price"/>' +
        '<input type="text" placeholder="дата регистрации" v-model="acc_date"/>' +
        '<input type="button" value="Сохранить" @click="save"/>' +
    '</div>',
methods: {
    save: function () {
        var product = {
            ident: this.ident, name: this.name, id_cat: this.id_cat, id_sup: this.id_sup,
            country: this.country, number: this.number, price: this.price, acc_date: this.acc_date
        };
        resource.save({}, product).then(result =>
            result.json().then(date => {
                this.products.push(data);
            })
        )
    }
    }
});


//вывод объектов
Vue.component('product-row', {
    props: ['product'],
    template: '<div><i>{{product.identificator }}</i> {{ product.name }} '
        +  '{{ product.country }} {{ product.number }} {{ product.price }}</div > '

});

Vue.component('products-list', {
    props: ['products'],
    template: '<div>'+
        '<products-form :products="products"/>'+
        '<product-row v-for = "product in products" :key="product.Id" :product="product" /></div> ',
    created: function () {
        resource.get().then(result =>
            result.json().then(data =>
                data.forEach(product => this.products.push(product))
            )
   ) }
});

var app = new Vue({
    el: '#app',
    template: '<products-list :products="products"/>',
    data: {
        products: []
    }
});