Vue.use(VueResource);

//товары
var resourcep = Vue.resource('/api/products');

//сохранение объектов
Vue.component('products-form', {
    props: ['products', 'productAttr'],
    data: function () {
        return {

            identificator: '',
            name: '',
            id_category: '',
            id_supplier: '',
            country: '',
            number: '',
            price: '',
            info: '',
            id: ''
        }
    },

    watch: {
        productAttr: function (newVal, oldVal) {
            this.id = newVal.id;
            this.name = newVal.name;
            this.identificator = newVal.identificator;
            this.id_category = newVal.id_category;
            this.id_supplier = newVal.id_supplier;
            this.country = newVal.country;
            this.number = newVal.number;
            this.price = newVal.price;

        }
    },

    template:
        '<div>' +
      
        '<input class="tab" type="image" src="/Images/save.png" @click="save"/>' +
        '</br>' +
        '<input type="text" placeholder="идентификатор" class="pole" v-model="identificator"/>' +
        '<input type="text" placeholder="название" class="pole" v-model="name"/>' +
        '<input type="number" placeholder="категория" class="pole" v-model="id_category"/>' +
        '<input type="number" placeholder="поставщик" class="pole" v-model="id_supplier"/>' +
        '<input type="text" placeholder="страна" class="pole" v-model="country"/>' +
        '<input type="number" placeholder="количество" class="pole" v-model="number"/>' +
        '<input type="text" placeholder="цена" class="pole" v-model="price"/>' +


        '</div>',
    methods: {
        save: function () {
            var product = {
                name: this.name, identificator: this.identificator, id_category: this.id_category,
                id_supplier: this.id_supplier, country: this.country, number: this.number,
                price: this.price
            };
            //обновление
            if (this.id) {
                resourcep.update({ id: this.id }, product).then(result =>
                    result.json().then(data => {
                        var index = this.products.findIndex(product => product === data.identificator);
                        this.products.splice(index, 1, data);
                        this.id = "";
                        this.name = "";
                        this.identificator = "";
                        this.id_category = "";
                        this.id_supplier = "";
                        this.country = "";
                        this.number = "";
                        this.price = "";

                    }
                    ))
            }
            else {
                resourcep.save({}, product).then(result =>
                    result.json().then(data => {
                        this.products.push(data);
                        this.name = "";
                        this.identificator = "";
                        this.id_category = "";
                        this.id_supplier = "";
                        this.country = "";
                        this.number = "";
                        this.price = "";
                    })
                )
            }
        },


    }
});


//вывод объектов
Vue.component('product-row', {
    props: ['product', 'editeProduct', 'products'],
    template:
        '<table  style="margin: auto;">' +
        '<tbody>' +

        '<tr><td class="text" width="150"> {{ product.identificator}}</td>' +
        '<td class="text" width="150"> {{ product.name }}</td>' +
        '<td class="text" width="150"> {{ product.number }}</td>' +
        '<td class="text" width="150"> {{ product.id_category }}</td>' +
        '<td class="text" width="150"> {{ product.id_supplier }}</td>' +
        '<td class="text" width="150"> {{ product.country}}</td>' +
        '<td class="text" width="150"> {{ product.price}}</td>' +
        '<td width="150">' +
        '<input type="image" src="/Images/edit (1).png" @click="edit"/>' +
        '<input class="tab" type="image" src="/Images/bin.png" @click="del"/>' +
        '</td>' +
        '<td class= "text" width="100"> {{ product.info }}</td ></tr> ' +
        '<tr width="950"><HR WIDTH="700%" ALIGN="center" SIZE="1"/></tr>' +
        '</tbody>' +
        '</table> ',
    methods: {
        edit: function () {
            this.editeProduct(this.product);
        },
        //удаление
        del: function () {
            resourcep.remove({ id: this.product.id }).then(result => {
                if (result.ok) {
                    this.products.splice(this.products.indexOf(this.product), 1)
                }
            }

            )
        }
    }
});

//вывод
Vue.component('products-list', {
    props: ['products'],
    data: function () {
        return {
            product: null
        }
    },


    template: '<div style="position: relative; width: 300 px;">' +
        '<products-form :products="products" :productAttr="product"/>' +
        '</br>' +
        '</br>' +
        '<table  style="margin: auto;">' +
        '<tr><th class="text2" width="150">Идентификатор</th><th class="text2" width="150">Название</th><th class="text2" width="150">Количество<th>' +
        '<th class="text2" width="150" >Категория</th> <th class="text2" width="150">Поставщик</th> <th class="text2" width="150">Страна</th>' +
        '<th class="text2" width="150">Цена</th> <th width="150"></th><th width="150"></th></tr>' +
        '</table>' +
        '<product-row v-for = "product in products" :key="product.Id" :product="product"' +
        ':editeProduct="editeProduct"  :products="products"/></div> ',


    created: function () {
        resourcep.get().then(result =>
            result.json().then(data =>
                data.forEach(product => this.products.push(product))
            )
        )

    },

    //обновление
    methods: {
        editeProduct: function (product) {
            this.product = product;
        }
    }

});

var app = new Vue({
    el: '#pr',
    template: '<products-list :products="products"/>',
    data: {
        products: []
    }
});

