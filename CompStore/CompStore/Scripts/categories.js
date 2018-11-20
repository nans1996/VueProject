
Vue.use(VueResource);
var resource = Vue.resource('api/categories');


//сохранение объектов
Vue.component('categories-form', {
    props: ['categories','categoryAttr'],
    data: function () {
        return {
            name: '',
            id: ''
         }
    },

    watch: {
        categoryAttr: function (newVal, oldVal) {
            this.name = newVal.name;
            this.id = newVal.id;
        }
    },

    template:
        '<div>' +
        '<input type="text" placeholder="название" class="pole" v-model="name"/>' +
        '<input type="button" value="Сохранить" @click="save"/>' +
        '<button  @click="save">Сохранить</button>'+
        '</div>',
    methods: {
        save: function () {
            var category = { name: this.name };
//обновление
            if (this.id) {
                resource.update({ id: this.id }, category).then(result =>
                    result.json().then(data => {
                        var index = this.categories.findIndex(category => category === data.name);
                        this.categories.splice(index, 1, data);
                        this.name = ''
                        this.id = ''
                    }
                    ))
            }
            else { 
            resource.save({}, category).then(result =>
                result.json().then(data => {
                    this.categories.push(data);
                    this.name = ""
                })
            )
          }
        }
    }
});


//вывод объектов
Vue.component('category-row', {
    props: ['category', 'editeCategory','categories'],
    template: '<div><i>{{category.id }}</i> {{ category.name }}'+
        '<span style="position: absolute; right: 0">'+
       '<input type="button" value="Изменить" @click="edit" />' +
        '<input type="button" value="Удалить" @click="del" />' +
        '</span>'+
        '</div> ',
    methods: {
        edit: function () {
            this.editeCategory(this.category);
        },
        //удаление
        del: function () {
            resource.remove({ id: this.category.id }).then(result => {
                if (result.ok) {
                    this.categories.splice(this.categories.indexOf(this.category),1)
                }
            }
                
            )
        }
    }
});

Vue.component('categories-list', {
    props: ['categories'],
    data: function () {
        return {
            category: null
        }
    },
    template: '<div style="position: relative; width: 300 px;">' +
        '<categories-form :categories="categories" :categoryAttr="category"/>' +
        '<category-row v-for = "category in categories" :key="category.Id" :category="category"' +
    ':editeCategory="editeCategory"  :categories="categories"/></div> ',
    created: function () {
        resource.get().then(result =>
            result.json().then(data =>
                data.forEach(category => this.categories.push(category))
            )
        )
    },

    //обновление
    methods: {
        editeCategory: function (category) {
            this.category = category;
        }
    }
});

var app = new Vue({
    el: '#app',
    template: '<categories-list :categories="categories"/>',
    data: {
        categories: []
    }
});