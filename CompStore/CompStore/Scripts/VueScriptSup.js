Vue.use(VueResource);

//товары
var resources = Vue.resource('/api/suppliers');

//сохранение объектов
Vue.component('suppliers-form', {
    props: ['suppliers', 'supplierAttr'],
    data: function () {
        return {
            name: '',
            adress: '',
            phone: '',
            id: ''
        }
    },

    watch: {
        productAttr: function (newVal, oldVal) {
            this.id = newVal.id;
            this.name = newVal.name;
            this.adress = newVal.adress;
            this.phone = newVal.phone;

        }
    },

    template:
        '<div>' +

        '<input class="tab" type="image" src="/Images/save.png" @click="save"/>' +
        '</br>' +
        '<input type="text" placeholder="название" class="pole" v-model="name"/>' +
        '</br>' +
        '<input type="text" placeholder="адрес" class="pole" v-model="adress"/>' +
        '</br>' +
        '<input type="text" placeholder="телефон" class="pole" v-model="phone"/>' +
        '</div>',
    methods: {
        save: function () {
            var supplier = {
                name: this.name, adress: this.adress, phone: this.phone
            };
            //обновление
            if (this.id) {
                resources.update({ id: this.id }, supplier).then(result =>
                    result.json().then(data => {
                        var index = this.suppliers.findIndex(supplier => supplier === data.name);
                        this.suppliers.splice(index, 1, data);
                        this.id = "";
                        this.name = "";
                        this.adress = "";
                        this.phone = "";
                    }
                    ))
            }
            else {
                resources.save({}, supplier).then(result =>
                    result.json().then(data => {
                        this.suppliers.push(data);
                        this.name = "";
                        this.adress = "";
                        this.phone = "";
                    })
                )
            }
        },


    }
});


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
        '<input type="image" src="/Images/edit (1).png" @click="edit"/>' +
        '<input class="tab" type="image" src="/Images/bin.png" @click="del"/>' +
        '</td></tr> ' +
        '<tr width="950"><HR WIDTH="400%" ALIGN="center" SIZE="1"/></tr>' +
        '</tbody>' +
        '</table> ',
    methods: {
        edit: function () {
            this.editeSupplier(this.supplier);
        },
        //удаление
        del: function () {
            resources.remove({ id: this.supplier.id }).then(result => {
                if (result.ok) {
                    this.suppliers.splice(this.suppliers.indexOf(this.supplier), 1)
                }
            }

            )
        }
    }
});

//вывод
Vue.component('suppliers-list', {
    props: ['suppliers'],
    data: function () {
        return {
            supplier: null
        }
    },


    template: '<div style="position: relative; width: 300 px;">' +
        '<suppliers-form :suppliers="suppliers" :supplierAttr="supplier"/>' +
        '</br>' +
        '</br>' +
        '<table  style="margin: auto;">' +
        '<tr><th class="text2" width="150">№</th><th class="text2" width="150">Название<th>' +
        '<th class="text2" width="150">Адрес<th><th class="text2" width="150">Телефон</th><th class="text2" width="150"></th></tr>' +
        '</table>' +
        '<supplier-row v-for = "supplier in suppliers" :key="supplier.Id" :supplier="supplier"' +
        ':editeSupplier="editeSupplier"  :suppliers="suppliers"/></div> ',


    created: function () {
        resources.get().then(result =>
            result.json().then(data =>
                data.forEach(supplier => this.suppliers.push(supplier))
            )
        )

    },

    //обновление
    methods: {
        editeSupplier: function (supplier) {
            this.supplier = supplier;
        }
    }

});

var app = new Vue({
    el: '#sup',
    template: '<suppliers-list :suppliers="suppliers"/>',
    data: {
        suppliers: []
    }
});

