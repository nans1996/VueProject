Vue.use(VueResource);

//товары
var resources = Vue.resource('/api/users');

//сохранение объектов
Vue.component('users-form', {
    props: ['users'],
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

});


//вывод объектов
Vue.component('user-row', {
    props: ['user', 'users'],
    template:
        '<table  style="margin: auto;">' +
        '<tbody>' +
        '<tr><td class="text" width="150"> {{user.email}}</td>' +
        '<td class="text" width="150"> {{user.surname}}</td>' +
        '<td class="text" width="150"> {{ user.name }}</td>' +
        '<td class="text" width="150"> {{ user.patronymic}}</td>' +
        '<td class="text" width="150"> {{ user.n_per_file}}</td>' +
        '<td class="text" width="150"> {{ user.salary}}</td>' +
        '</tr> ' +
        '<tr width="950"><HR WIDTH="600%" ALIGN="center" SIZE="1"/></tr>' +
        '</tbody>' +
        '</table> ',

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
        '<th class="text2" width="150">№ личного дела<th><th class="text2" width="150">Зарплата</th></tr>' +
        '</table>' +
        '</br>'+
        '<user-row v-for = "user in users" :key="user.Id" :user="user"' +
        ' :users="users"/></div> ',


    created: function () {
        resources.get().then(result =>
            result.json().then(data =>
                data.forEach(user => this.users.push(user))
            )
        )

    },


});

var app = new Vue({
    el: '#us',
    template: '<users-list :users="users"/>',
    data: {
        users: []
    }
});

