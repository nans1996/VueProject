Vue.use(VueResource);

//товары
var resources = Vue.resource('/api/sellings');

//сохранение объектов
Vue.component('sellings-form', {
    props: ['sellings', 'sellingAttr'],
    data: function () {
        return {
            price: '',
            status: '',
            datetime: '',
            id: ''
        }
    },


    template:
        '<div>' +

        '<input class="tab" type="image" src="/Images/save.png" @click="save"/>' +
        '</br>' +
        '<input type="text" placeholder="цена" class="pole" v-model="price"/>' +
        '</br>' +
        '<input type="text" placeholder="статус" class="pole" v-model="status"/>' +
        '</div>',
    methods: {
        save: function () {
            var selling = {
                price: this.price, status: this.status
            };
  
                resources.save({}, selling).then(result =>
                    result.json().then(data => {
                        this.sellings.push(data);
                        this.price = "";
                        this.status = "";
                    })
                )
        },


    }
});


//вывод объектов
Vue.component('selling-row', {
    props: ['selling', 'editeSelling', 'sellings'],
    template:
        '<table  style="margin: auto;">' +
        '<tbody>' +
        '<tr><td class="text" width="150"> {{ selling.id}}</td>' +
        '<td class="text" width="150"> {{ selling.price}}</td>' +
        '<td class="text" width="150"> {{ selling.datetime}}</td>' +
        '<td class="text" width="150"> {{ selling.status }}</td>' +
        '</tr> ' +
        '<tr width="950"><HR WIDTH="400%" ALIGN="center" SIZE="1"/></tr>' +
        '</tbody>' +
        '</table> ',
    methods: {
    }
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
        '<sellings-form :sellings="sellings" :sellingAttr="selling"/>' +
        '</br>' +
        '</br>' +
        '<table  style="margin: auto;">' +
        '<tr><th class="text2" width="150">Продавец</th><th class="text2" width="150">Цена<th>' +
        '<th class="text2" width="150">Дата<th><th class="text2" width="150">Статус</th></tr>' +
        '</table>' +
        '<selling-row v-for = "selling in sellings" :key="selling.Id" :selling="selling"' +
        ':sellings="sellings"/></div> ',


    created: function () {
        resources.get().then(result =>
            result.json().then(data =>
                data.forEach(selling => this.sellings.push(selling))
            )
        )

    },

    //обновление
    methods: {
        editeSelling: function (selling) {
            this.selling = selling;
        }
    }

});

var app = new Vue({
    el: '#sel',
    template: '<sellings-list :sellings="sellings"/>',
    data: {
        sellings: []
    }
});

