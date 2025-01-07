export const getAllYearlyEvents = async () => {
  const res = await fetch("/api/yearlyevents");
  return res.json();
};

export const getAllFamilyNames = async () => {
  const res = await fetch("/api/familynames");
  return res.json();
};
