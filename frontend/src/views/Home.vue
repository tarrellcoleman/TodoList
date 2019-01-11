<template>
  <div id="TodoList">
    <form v-on:submit.prevent="submitted()">
      <img alt="Vue logo" src="../assets/logo.png">
      <h1>TodoList</h1>
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
      <button v-on:click="deleted(index)">Delete</button>
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
      listOfTasks: [ ]
    }
  },
  methods: {
    submitted: function () {
      this.listOfTasks.push({
        task: this.newTask
      })
      this.newTask = ''
    },
    deleted: function (index) {
      this.listOfTasks.splice(index, 1)
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
