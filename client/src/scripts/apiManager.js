export const getAllYearlyEvents = async () => {
  const res = await fetch("/api/yearlyevents");
  return res.json();
};
