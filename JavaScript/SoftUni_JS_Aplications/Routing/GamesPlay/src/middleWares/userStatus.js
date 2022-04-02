import { getUserData } from "../util.js";




export function userUpdate(ctx, next) {
    ctx.user = getUserData();
    next();
  }