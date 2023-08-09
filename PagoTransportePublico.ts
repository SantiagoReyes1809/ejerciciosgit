interface PaymentInterface {
  makePayment(amount: number): boolean;
}

class TransitCard implements PaymentInterface {
  private balance: number = 0;

  constructor(initialBalance: number) {
    this.balance = initialBalance;
  }

  makePayment(amount: number): boolean {
    if (this.balance >= amount) {
      this.balance -= amount;
      console.log(`Payment of $ ${amount} accepted. Remaining balance: $ ${this.balance}`);
      return true;
    } else {
      console.log(`Payment of $ ${amount} rejected. Insufficient balance: $ ${this.balance}`);
      return false;
    }
  }

  addFunds(amount: number): void {
    this.balance += amount;
    console.log(`Added $ ${amount} to balance. New balance: $ ${this.balance}`);
  }

  getBalance(): number {
    return this.balance;
  }
}

const transitCard = new TransitCard(10.0);

const busRideCost = 2.5;
const busRideSuccess = transitCard.makePayment(busRideCost);
if (busRideSuccess) {
  console.log('Bus ride accepted. Thank you for riding with us!');
} else {
  console.log('Bus ride rejected. Please add funds to your transit card.');
}

const balance = transitCard.getBalance();
console.log(`Transit card balance: $ ${balance}`);

transitCard.addFunds(20.0);

const trainRideCost = 3.25;
const trainRideSuccess = transitCard.makePayment(trainRideCost);
if (trainRideSuccess) {
  console.log('Train ride accepted. Thank you for riding with us!');
} else {
  console.log('Train ride rejected. Please add funds to your transit card.');
}

const newBalance = transitCard.getBalance();
console.log(`Transit card balance: $ ${newBalance}`);
