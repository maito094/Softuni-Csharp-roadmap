function solve(steps,footprint,speed) {
    let distance = steps*footprint; //meters
    let breakTime = Math.floor(distance/500); //minutes
    let time = breakTime*60+(distance/speed*3600/1000); // seconds;
    
    let hours = Math.floor( time/3600);
    let minutes = Math.floor( (time-hours*3600)/60);

    let seconds = Math.round((time-(minutes*60+hours*3600)));

    console.log(`${hours.toString().padStart(2,0)}:${minutes.toString().padStart(2,0)}:${seconds.toString().padStart(2,0)}`);
}
solve(25164, 0.70, 1);
