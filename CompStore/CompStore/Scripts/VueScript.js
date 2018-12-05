
Vue.use(VueResource);
var resource = Vue.resource('/api/categories');


//сохранение объектов
Vue.component('categories-form', {
    props: ['categories', 'categoryAttr'],
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
        '<input type="image"srс="/Images/save.png" @click="save"/>' +
        
        '</br>' +
       
        '<input type="text" placeholder="название" class="pole" v-model="name"/>' +
        
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
        },

        //search: function () {
        //    var result = categories.filter(category => category === data.searchStr);
        //}

    }
});


//вывод объектов
Vue.component('category-row', {
    props: ['category', 'editeCategory', 'categories'],
    template: '<table  width="600" style="margin: auto;">' +
        '<tbody>'+
        '<tr><td class="text"> {{ category.name }}</td>' +
         '<td width="150">'+
        '<input type="image" src="/Images/edit (1).png" @click="edit"/>' +
        '<input type="image"srс="/Images/bin.png" @click="del" />' +
        '</td></tr>' +
        '<tr width="700"><HR WIDTH="130%" ALIGN="center" SIZE="1"/></tr>'+
       '</tbody>'+
        '</table> ',
    methods: {
        edit: function () {
            this.editeCategory(this.category);
        },
        //удаление
        del: function () {
            resource.remove({ id: this.category.id }).then(result => {
                if (result.ok) {
                    this.categories.splice(this.categories.indexOf(this.category), 1)
                }
            }

            )
        }
    }
});

//вывод
Vue.component('categories-list', {
    props: ['categories'],
    data: function () {
        return {
        //    searchStr: '',
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

    //filterSearch: function () {
    //    return this.categories.filter(category => {
    //        return category.toLowerCase().indexOf(this.searchStr.toLowerCase()) !== -1
    //    })
    //},
});

var app = new Vue({
    el: '#categ',
    template: '<categories-list :categories="categories"/>',
    data: {
        categories: []
    }
});