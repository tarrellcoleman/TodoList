<template>
  <div id="TodoList">
    <form v-on:submit.prevent="submitted()">
      <img alt="Vue logo" src="../assets/logo.png">
      <h1>Todo</h1>
      <input
        v-model= "newTask"
        id ="new-task"
        placeholder="Add Task"
      >
      <button>Submit</button>
      <br>
    </form>
    <ul>
      <li v-for="(task, index) in listOfTasks" :key="task.id">
        {{ task.task }}
      <br>
      <button v-on:click="deleted(index)">Delete</button>
      <button v-on:click="task.edited=true">Edit</button>
      <br>
      <input v-if="task.edited === true"
          v-model= "editedTask"
          id ="edit-task"
          placeholder= "Edit Task">
          <button v-if="task.edited === true"
                  v-on:click="edited(index)">Submit</button>
          <button v-if="task.edited === true"
                  v-on:click="task.edited=false">Cancel</button>
      </li>
    </ul>
    </div>
</template>
<script>
// @ is an alias to /src

export default {
  name: 'ToDoList',
  data () {
    return {
      newTask: '',
      listOfTasks: [ ],
      isEdit: false,
      editedTask: ''
    }
  },
  methods: {
    submitted: function () {
      if (this.newTask !== '') {
        this.listOfTasks.push({
          task: this.newTask,
          edited: false
        })
      }
      this.newTask = ''
    },
    deleted: function (index) {
      this.listOfTasks.splice(index, 1)
    },
    edited: function (index) {
      this.$set(this.listOfTasks[index], 'task', this.editedTask)
      this.$set(this.listOfTasks[index], 'edited', false)
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
}
ul {
  list-style-type: none;
  padding: 0;
}
li {
  display: inline-block;
  margin: 0 10px;
}
a {
  color: #42b983;
}
</style>
