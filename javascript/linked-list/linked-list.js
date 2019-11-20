//
// This is only a SKELETON file for the 'Linked List' exercise. It's been provided as a
// convenience to get you started writing code faster.
//
class node{
  constructor(data, prev = null, next = null){
    this.data = data;
    this.prev = prev;
    this.next = next;
  }
}
export class LinkedList {
  constructor(){
    this.head = null;
    this.tail = null;
  }

  push(data) {
    if(this.head === null){// this checks if this will be the head
      this.head = new node(data);
      this.tail = this.head;
      //console.log(this.head.data);
    } else{
      this.tail.next = new node(data, this.tail); // this reassigns the next of the previous tail node to point to this node
      this.tail = this.tail.next; //this reassigns the tail to this node
      //console.log(this.tail.data);
    }
  }


  pop() {
    const current = this.tail; //creates a temp variable
    this.tail = this.tail.prev; // sets tail of ll to the node before the the current tail
    if (current === this.head){this.head = null;} // if the node removed is also the head this resets the head
    return current.data;
  }

  shift() {
    const current = this.head;
    this.head = this.head.next && this.head ? this.head.next : null;// reassigns head unless there is nothing after the current head
    return current.data;
  }

  unshift(data) {
    if(this.head === null){// this checks if this will be the head
      this.head = new node(data);
      this.tail = this.head;
    } else{
      this.head.prev = new node(data,null, this.head); // assigns the new node to the prev value of current head
      this.head = this.head.prev; // assigns new node to head
    }
  }

  delete(data) {
    let current = this.head;
    while (current !== null){
      if(current.data === data){// only activates if data matches the current head
        if(!current.prev){this.head = current.next;} //tests if deletion is the head and reassigns ll head
        else{current.prev.next = current.next;}//sets the next of the prev node to the current next
        if(!current.next){this.tail = current.prev;}// tests if deletion is the tail and reassigns ll tail
        else{current.next.prev = current.prev;}//sets the prev of the next node to the current prev 
        break;// prevents this from deleting more than one entry
        }
        current = current.next;
      }
    }

  count() {
    let counter = 0;
    let current = this.head;// starts at head
    if (current){counter++;}// counts the first one
    while(current && current.next){// checks if current node has a next
      current = current.next;// changes current to next node
      counter++;
    }
    return counter;
  }
}
