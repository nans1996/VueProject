Vue.use(VueResource);

//товары
var resources = Vue.resource('/api/selling');

//сохранение объектов
//Vue.component('sellings-form', {
//    props: ['sellings', 'sellingAttr'],
//    data: function () {
//        return {
//            id_seller: '',
//            price: '',
//            datetime: '',
//            status: '',
//            id: ''
//        }
//    },

//    watch: {
//        productAttr: function (newVal, oldVal) {
//            this.id = newVal.id;
//            this.name = newVal.name;
//            this.adress = newVal.adress;
//            this.phone = newVal.phone;

//        }
//    },

//    template:
//        '<div>' +

//        '<input class="tab" type="image" src="/Images/save.png" @click="save"/>' +
//        '</br>' +
//        '<input type="text" placeholder="название" class="pole" v-model="name"/>' +
//        '</br>' +
//        '<input type="text" placeholder="адрес" class="pole" v-model="adress"/>' +
//        '</br>' +
//        '<input type="text" placeholder="телефон" class="pole" v-model="phone"/>' +
//        '</div>',
//    methods: {
//        save: function () {
//            var supplier = {
//                name: this.name, adress: this.adress, phone: this.phone
//            };
//            //обновление
//            if (this.id) {
//                resources.update({ id: this.id }, supplier).then(result =>
//                    result.json().then(data => {
//                        var index = this.suppliers.findIndex(supplier => supplier === data.name);
//                        this.suppliers.splice(index, 1, data);
//                        this.id = "";
//                        this.name = "";
//                        this.adress = "";
//                        this.phone = "";
//                    }
//                    ))
//            }
//            else {
//                resources.save({}, supplier).then(result =>
//                    result.json().then(data => {
//                        this.suppliers.push(data);
//                        this.name = "";
//                        this.adress = "";
//                        this.phone = "";
//                    })
//                )
//            }
//        },


//    }
//});


//вывод объектов
Vue.component('supplier-row', {
    props: ['supplier', 'editeSupplier', 'suppliers'],
    template:
        '<table  style="margin: auto;">' +
        '<tbody>' +
        '<tr><td class="text" width="150"> {{ supplier.id}}</td>' +
        '<td class="text" width="150"> {{ supplier.name}}</td>' +
        '<td class="text" width="150"> {{ supplier.adress }}</td>' +
        '<td class="text" width="150"> {{ supplier.phone}}</td>' +
        '<td width="150">' +
        //'<input type="image" src="/Images/edit (1).png" @click="edit"/>' +
        '<input class="tab" type="image" src="/Images/bin.png" @click="del"/>' +
        '</td></tr> ' +
        '<tr width="950"><HR WIDTH="400%" ALIGN="center" SIZE="1"/></tr>' +
        '</tbody>' +
        '</table> ',
    //methods: {
    //    edit: function () {
    //        this.editeSupplier(this.supplier);
    //    },
        //удаление
        del: function () {
            resources.remove({ id: this.selling.id }).then(result => {
                if (result.ok) {
                    this.sellings.splice(this.sellings.indexOf(this.selling), 1)
                }
            }

            )
        }
   // }
});

//вывод
Vue.component('sellings-list', {
    props: ['sellings'],
    data: function () {
        return {
            selling: null
        }
    },


    template: '<div style="position: relative; width: 300 px;">' +
        //'<sellings-form :suppliers="suppliers" :supplierAttr="supplier"/>' +
        //'</br>' +
        //'</br>' +
        '<table  style="margin: auto;">' +
        '<tr><th class="text2" width="150">Продавец</th><th class="text2" width="150">Цена<th>' +
        '<th class="text2" width="150">Дата<th><th class="text2" width="150">Статус</th><th class="text2" width="150"></th></tr>' +
        '</table>' +
        '<selling-row v-for = "selling in sellings" :key="selling.Id" :selling="selling"' +
        ':sellings="sellings"/></div> ',


    //created: function () {
    //    resources.get().then(result =>
    //        result.json().then(data =>
    //            data.forEach(supplier => this.suppliers.push(supplier))
    //        )
    //    )

    //},

    ////обновление
    //methods: {
    //    editeSupplier: function (supplier) {
    //        this.supplier = supplier;
    //    }
    //}

});

var app = new Vue({
    el: '#sel',
    template: '<sellings-list :sellings="sellings"/>',
    data: {
        sellings: []
    }
});

