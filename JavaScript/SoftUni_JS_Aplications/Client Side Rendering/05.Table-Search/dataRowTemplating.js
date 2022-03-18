import { html } from '../node_modules/lit-html/lit-html.js';
import { classMap } from '../node_modules/lit-html/directives/class-map.js';

export function dataRowTemplate(infoEntry, match) {
  let fullName = infoEntry.firstName + ' ' + infoEntry.lastName;

  let isIncluded =
    match &&
    Object.entries(infoEntry).some(
      ([k, v]) => k != '_id' && v.toLowerCase().includes(match.toLowerCase())
    );

  let result = html` <tr class="${classMap({ select: isIncluded })}}">
    <td>${fullName}</td>
    <td>${infoEntry.email}</td>
    <td>${infoEntry.course}</td>
  </tr>`;

  return result;
}
