function solve(x1, y1, x2, y2) {
  let x1t;
  let x2t;
  let y1t;
  let y2t;

  for (let i = 0; i < 3; i++) {
    if (i == 0) {
      x1t = Number(x1);
      x2t = 0;
      y1t = Number(y1);
      y2t = 0;
    } else if (i == 1) {
      x1t = Number(x2);
      x2t = 0;
      y1t = Number(y2);
      y2t = 0;
    } else {
      x1t = Number(x1);
      x2t = Number(x2);
      y1t = Number(y1);
      y2t = Number(y2);
    }
    msgValidation = 'valid';
    let formulaResult = Math.sqrt((x2t - x1t) ** 2 + (y2t - y1t) ** 2);
    if (formulaResult % 1 != 0) {
      msgValidation = 'invalid';
    }
    console.log(`{${x1t}, ${y1t}} to {${x2t}, ${y2t}} is ${msgValidation}`);
  }
}
solve(2, 1, 1, 1);
