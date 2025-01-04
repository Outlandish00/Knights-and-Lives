export const getARandomNumberInRange = (min, max) => {
  const aRandomNumber = Math.floor(Math.random() * (max - min) + min);
  return aRandomNumber;
};
