Vue.use(VueResource);

//товары
var resources = Vue.resource('/api/aspnetuser');

//сохранение объектов
Vue.component('users-form', {
    props: ['users', 'userAttr'],
    data: function () {
        return {
            email: '',
            surname: '',
            name: '',
            patronymic: '',
            n_per_file: '',
            salary: '',
            id: ''
        }
    },

    watch: {
        userAttr: function (newVal, oldVal) {
            this.email = newVal.email;
            this.surname = newVal.surname;
            this.name = newVal.name;
            this.patronymic = newVal.patronymic;
            this.n_per_file = newVal.n_per_file;
            this.salary = newVal.salary;

        }
    },

    template:
        '<div>' +

        '<input class="tab" type="image" src="/Images/save.png" @click="save"/>' +
        '</br>' +
        '<input type="text" placeholder="email" class="pole" v-model="email"/>' +
        '</br>' +
        '<input type="text" placeholder="фамилия" class="pole" v-model="surname"/>' +
        '</br>' +
        '<input type="text" placeholder="имя" class="pole" v-model="name"/>' +
         '</br>' +
        '<input type="text" placeholder="отчество" class="pole" v-model="patronymic"/>' +
        '</br>' +
        '<input type="text" placeholder="личное дело" class="pole" v-model="n_per_file"/>' +
        '</br>' +
        '<input type="text" placeholder="зарплата" class="pole" v-model="salary"/>' +
        '</div>',
    methods: {
        save: function () {
            var user = {
                email: this.email, surname: this.surname, name: this.name,
                patronymic: this.patronymic, n_per_file: this.n_per_file, salary: this.salary
            };
            //обновление
            if (this.id) {
                resources.update({ id: this.id }, supplier).then(result =>
                    result.json().then(data => {
                        var index = this.suppliers.findIndex(supplier => supplier === data.name);
                        this.suppliers.splice(index, 1, data);
                        this.id = "";
                        this.surname = "";
                        this.name = "";
                        this.patronymic = "";
                        this.n_per_file = "";
                        this.salary = "";
                    }
                    ))
            }
            //else {
            //    resources.save({}, supplier).then(result =>
            //        result.json().then(data => {
            //            this.suppliers.push(data);
            //            this.name = "";
            //            this.adress = "";
            //            this.phone = "";
            //        })
            //    )
            //}
        },


    }
});


//вывод объектов
Vue.component('user-row', {
    props: ['user', 'editeUser', 'users'],
    template:
        '<table  style="margin: auto;">' +
        '<tbody>' +
        '<tr><td class="text" width="150"> {{user.email}}</td>' +
        '<td class="text" width="150"> {{user.surname}}</td>' +
        '<td class="text" width="150"> {{ user.name }}</td>' +
        '<td class="text" width="150"> {{ user.patronymic}}</td>' +
        '<td class="text" width="150"> {{ user.n_per_file}}</td>' +
        '<td class="text" width="150"> {{ user.salary}}</td>' +
        '<td width="150">' +
        '<input type="image" src="/Images/edit (1).png" @click="edit"/>' +
        '<input class="tab" type="image" src="/Images/bin.png" @click="del"/>' +
        '</td></tr> ' +
        '<tr width="950"><HR WIDTH="400%" ALIGN="center" SIZE="1"/></tr>' +
        '</tbody>' +
        '</table> ',
    methods: {
        edit: function () {
            this.editeUser(this.user);
        },
        //удаление
        del: function () {
            resources.remove({ id: this.user.id }).then(result => {
                if (result.ok) {
                    this.users.splice(this.users.indexOf(this.user), 1)
                }
            }

            )
        }
    }
});

//вывод
Vue.component('users-list', {
    props: ['users'],
    data: function () {
        return {
            user: null
        }
    },


    template: '<div style="position: relative; width: 300 px;">' +
        '<users-form :users="users" :userAttr="user"/>' +
        '</br>' +
        '</br>' +
        '<table  style="margin: auto;">' +
        '<tr><th class="text2" width="150">Email</th><th class="text2" width="150">Фамилия<th>' +
        '<th class="text2" width="150">Имя<th><th class="text2" width="150">Отчество</th>' +
        '<th class="text2" width="150">№ личного дела<th><th class="text2" width="150">Зарплата</th><th class="text2" width="150"></th></tr>' +
        '</table>' +
        '<user-row v-for = "user in users" :key="user.Id" :user="user"' +
        ':editeUser="editeUser"  :users="users"/></div> ',


    created: function () {
        resources.get().then(result =>
            result.json().then(data =>
                data.forEach(user => this.users.push(user))
            )
        )

    },

    //обновление
    methods: {
        editeUser: function (user) {
            this.user = user;
        }
    }

});

var app = new Vue({
    el: '#us',
    template: '<users-list :users="users"/>',
    data: {
        users: []
    }
});

