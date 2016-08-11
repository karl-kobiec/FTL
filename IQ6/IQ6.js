/*! jQuery v2.1.4 | (c) 2005, 2015 jQuery Foundation, Inc. | jquery.org/license */
!function (a, b) { "object" == typeof module && "object" == typeof module.exports ? module.exports = a.document ? b(a, !0) : function (a) { if (!a.document) throw new Error("jQuery requires a window with a document"); return b(a) } : b(a) }("undefined" != typeof window ? window : this, function (a, b) {
	var c = [], d = c.slice, e = c.concat, f = c.push, g = c.indexOf, h = {}, i = h.toString, j = h.hasOwnProperty, k = {}, l = a.document, m = "2.1.4", n = function (a, b) { return new n.fn.init(a, b) }, o = /^[\s\uFEFF\xA0]+|[\s\uFEFF\xA0]+$/g, p = /^-ms-/, q = /-([\da-z])/gi, r = function (a, b) { return b.toUpperCase() }; n.fn = n.prototype = { jquery: m, constructor: n, selector: "", length: 0, toArray: function () { return d.call(this) }, get: function (a) { return null != a ? 0 > a ? this[a + this.length] : this[a] : d.call(this) }, pushStack: function (a) { var b = n.merge(this.constructor(), a); return b.prevObject = this, b.context = this.context, b }, each: function (a, b) { return n.each(this, a, b) }, map: function (a) { return this.pushStack(n.map(this, function (b, c) { return a.call(b, c, b) })) }, slice: function () { return this.pushStack(d.apply(this, arguments)) }, first: function () { return this.eq(0) }, last: function () { return this.eq(-1) }, eq: function (a) { var b = this.length, c = +a + (0 > a ? b : 0); return this.pushStack(c >= 0 && b > c ? [this[c]] : []) }, end: function () { return this.prevObject || this.constructor(null) }, push: f, sort: c.sort, splice: c.splice }, n.extend = n.fn.extend = function () { var a, b, c, d, e, f, g = arguments[0] || {}, h = 1, i = arguments.length, j = !1; for ("boolean" == typeof g && (j = g, g = arguments[h] || {}, h++), "object" == typeof g || n.isFunction(g) || (g = {}), h === i && (g = this, h--) ; i > h; h++) if (null != (a = arguments[h])) for (b in a) c = g[b], d = a[b], g !== d && (j && d && (n.isPlainObject(d) || (e = n.isArray(d))) ? (e ? (e = !1, f = c && n.isArray(c) ? c : []) : f = c && n.isPlainObject(c) ? c : {}, g[b] = n.extend(j, f, d)) : void 0 !== d && (g[b] = d)); return g }, n.extend({ expando: "jQuery" + (m + Math.random()).replace(/\D/g, ""), isReady: !0, error: function (a) { throw new Error(a) }, noop: function () { }, isFunction: function (a) { return "function" === n.type(a) }, isArray: Array.isArray, isWindow: function (a) { return null != a && a === a.window }, isNumeric: function (a) { return !n.isArray(a) && a - parseFloat(a) + 1 >= 0 }, isPlainObject: function (a) { return "object" !== n.type(a) || a.nodeType || n.isWindow(a) ? !1 : a.constructor && !j.call(a.constructor.prototype, "isPrototypeOf") ? !1 : !0 }, isEmptyObject: function (a) { var b; for (b in a) return !1; return !0 }, type: function (a) { return null == a ? a + "" : "object" == typeof a || "function" == typeof a ? h[i.call(a)] || "object" : typeof a }, globalEval: function (a) { var b, c = eval; a = n.trim(a), a && (1 === a.indexOf("use strict") ? (b = l.createElement("script"), b.text = a, l.head.appendChild(b).parentNode.removeChild(b)) : c(a)) }, camelCase: function (a) { return a.replace(p, "ms-").replace(q, r) }, nodeName: function (a, b) { return a.nodeName && a.nodeName.toLowerCase() === b.toLowerCase() }, each: function (a, b, c) { var d, e = 0, f = a.length, g = s(a); if (c) { if (g) { for (; f > e; e++) if (d = b.apply(a[e], c), d === !1) break } else for (e in a) if (d = b.apply(a[e], c), d === !1) break } else if (g) { for (; f > e; e++) if (d = b.call(a[e], e, a[e]), d === !1) break } else for (e in a) if (d = b.call(a[e], e, a[e]), d === !1) break; return a }, trim: function (a) { return null == a ? "" : (a + "").replace(o, "") }, makeArray: function (a, b) { var c = b || []; return null != a && (s(Object(a)) ? n.merge(c, "string" == typeof a ? [a] : a) : f.call(c, a)), c }, inArray: function (a, b, c) { return null == b ? -1 : g.call(b, a, c) }, merge: function (a, b) { for (var c = +b.length, d = 0, e = a.length; c > d; d++) a[e++] = b[d]; return a.length = e, a }, grep: function (a, b, c) { for (var d, e = [], f = 0, g = a.length, h = !c; g > f; f++) d = !b(a[f], f), d !== h && e.push(a[f]); return e }, map: function (a, b, c) { var d, f = 0, g = a.length, h = s(a), i = []; if (h) for (; g > f; f++) d = b(a[f], f, c), null != d && i.push(d); else for (f in a) d = b(a[f], f, c), null != d && i.push(d); return e.apply([], i) }, guid: 1, proxy: function (a, b) { var c, e, f; return "string" == typeof b && (c = a[b], b = a, a = c), n.isFunction(a) ? (e = d.call(arguments, 2), f = function () { return a.apply(b || this, e.concat(d.call(arguments))) }, f.guid = a.guid = a.guid || n.guid++, f) : void 0 }, now: Date.now, support: k }), n.each("Boolean Number String Function Array Date RegExp Object Error".split(" "), function (a, b) { h["[object " + b + "]"] = b.toLowerCase() }); function s(a) { var b = "length" in a && a.length, c = n.type(a); return "function" === c || n.isWindow(a) ? !1 : 1 === a.nodeType && b ? !0 : "array" === c || 0 === b || "number" == typeof b && b > 0 && b - 1 in a } var t = function (a) { var b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u = "sizzle" + 1 * new Date, v = a.document, w = 0, x = 0, y = ha(), z = ha(), A = ha(), B = function (a, b) { return a === b && (l = !0), 0 }, C = 1 << 31, D = {}.hasOwnProperty, E = [], F = E.pop, G = E.push, H = E.push, I = E.slice, J = function (a, b) { for (var c = 0, d = a.length; d > c; c++) if (a[c] === b) return c; return -1 }, K = "checked|selected|async|autofocus|autoplay|controls|defer|disabled|hidden|ismap|loop|multiple|open|readonly|required|scoped", L = "[\\x20\\t\\r\\n\\f]", M = "(?:\\\\.|[\\w-]|[^\\x00-\\xa0])+", N = M.replace("w", "w#"), O = "\\[" + L + "*(" + M + ")(?:" + L + "*([*^$|!~]?=)" + L + "*(?:'((?:\\\\.|[^\\\\'])*)'|\"((?:\\\\.|[^\\\\\"])*)\"|(" + N + "))|)" + L + "*\\]", P = ":(" + M + ")(?:\\((('((?:\\\\.|[^\\\\'])*)'|\"((?:\\\\.|[^\\\\\"])*)\")|((?:\\\\.|[^\\\\()[\\]]|" + O + ")*)|.*)\\)|)", Q = new RegExp(L + "+", "g"), R = new RegExp("^" + L + "+|((?:^|[^\\\\])(?:\\\\.)*)" + L + "+$", "g"), S = new RegExp("^" + L + "*," + L + "*"), T = new RegExp("^" + L + "*([>+~]|" + L + ")" + L + "*"), U = new RegExp("=" + L + "*([^\\]'\"]*?)" + L + "*\\]", "g"), V = new RegExp(P), W = new RegExp("^" + N + "$"), X = { ID: new RegExp("^#(" + M + ")"), CLASS: new RegExp("^\\.(" + M + ")"), TAG: new RegExp("^(" + M.replace("w", "w*") + ")"), ATTR: new RegExp("^" + O), PSEUDO: new RegExp("^" + P), CHILD: new RegExp("^:(only|first|last|nth|nth-last)-(child|of-type)(?:\\(" + L + "*(even|odd|(([+-]|)(\\d*)n|)" + L + "*(?:([+-]|)" + L + "*(\\d+)|))" + L + "*\\)|)", "i"), bool: new RegExp("^(?:" + K + ")$", "i"), needsContext: new RegExp("^" + L + "*[>+~]|:(even|odd|eq|gt|lt|nth|first|last)(?:\\(" + L + "*((?:-\\d)?\\d*)" + L + "*\\)|)(?=[^-]|$)", "i") }, Y = /^(?:input|select|textarea|button)$/i, Z = /^h\d$/i, $ = /^[^{]+\{\s*\[native \w/, _ = /^(?:#([\w-]+)|(\w+)|\.([\w-]+))$/, aa = /[+~]/, ba = /'|\\/g, ca = new RegExp("\\\\([\\da-f]{1,6}" + L + "?|(" + L + ")|.)", "ig"), da = function (a, b, c) { var d = "0x" + b - 65536; return d !== d || c ? b : 0 > d ? String.fromCharCode(d + 65536) : String.fromCharCode(d >> 10 | 55296, 1023 & d | 56320) }, ea = function () { m() }; try { H.apply(E = I.call(v.childNodes), v.childNodes), E[v.childNodes.length].nodeType } catch (fa) { H = { apply: E.length ? function (a, b) { G.apply(a, I.call(b)) } : function (a, b) { var c = a.length, d = 0; while (a[c++] = b[d++]); a.length = c - 1 } } } function ga(a, b, d, e) { var f, h, j, k, l, o, r, s, w, x; if ((b ? b.ownerDocument || b : v) !== n && m(b), b = b || n, d = d || [], k = b.nodeType, "string" != typeof a || !a || 1 !== k && 9 !== k && 11 !== k) return d; if (!e && p) { if (11 !== k && (f = _.exec(a))) if (j = f[1]) { if (9 === k) { if (h = b.getElementById(j), !h || !h.parentNode) return d; if (h.id === j) return d.push(h), d } else if (b.ownerDocument && (h = b.ownerDocument.getElementById(j)) && t(b, h) && h.id === j) return d.push(h), d } else { if (f[2]) return H.apply(d, b.getElementsByTagName(a)), d; if ((j = f[3]) && c.getElementsByClassName) return H.apply(d, b.getElementsByClassName(j)), d } if (c.qsa && (!q || !q.test(a))) { if (s = r = u, w = b, x = 1 !== k && a, 1 === k && "object" !== b.nodeName.toLowerCase()) { o = g(a), (r = b.getAttribute("id")) ? s = r.replace(ba, "\\$&") : b.setAttribute("id", s), s = "[id='" + s + "'] ", l = o.length; while (l--) o[l] = s + ra(o[l]); w = aa.test(a) && pa(b.parentNode) || b, x = o.join(",") } if (x) try { return H.apply(d, w.querySelectorAll(x)), d } catch (y) { } finally { r || b.removeAttribute("id") } } } return i(a.replace(R, "$1"), b, d, e) } function ha() { var a = []; function b(c, e) { return a.push(c + " ") > d.cacheLength && delete b[a.shift()], b[c + " "] = e } return b } function ia(a) { return a[u] = !0, a } function ja(a) { var b = n.createElement("div"); try { return !!a(b) } catch (c) { return !1 } finally { b.parentNode && b.parentNode.removeChild(b), b = null } } function ka(a, b) { var c = a.split("|"), e = a.length; while (e--) d.attrHandle[c[e]] = b } function la(a, b) { var c = b && a, d = c && 1 === a.nodeType && 1 === b.nodeType && (~b.sourceIndex || C) - (~a.sourceIndex || C); if (d) return d; if (c) while (c = c.nextSibling) if (c === b) return -1; return a ? 1 : -1 } function ma(a) { return function (b) { var c = b.nodeName.toLowerCase(); return "input" === c && b.type === a } } function na(a) { return function (b) { var c = b.nodeName.toLowerCase(); return ("input" === c || "button" === c) && b.type === a } } function oa(a) { return ia(function (b) { return b = +b, ia(function (c, d) { var e, f = a([], c.length, b), g = f.length; while (g--) c[e = f[g]] && (c[e] = !(d[e] = c[e])) }) }) } function pa(a) { return a && "undefined" != typeof a.getElementsByTagName && a } c = ga.support = {}, f = ga.isXML = function (a) { var b = a && (a.ownerDocument || a).documentElement; return b ? "HTML" !== b.nodeName : !1 }, m = ga.setDocument = function (a) { var b, e, g = a ? a.ownerDocument || a : v; return g !== n && 9 === g.nodeType && g.documentElement ? (n = g, o = g.documentElement, e = g.defaultView, e && e !== e.top && (e.addEventListener ? e.addEventListener("unload", ea, !1) : e.attachEvent && e.attachEvent("onunload", ea)), p = !f(g), c.attributes = ja(function (a) { return a.className = "i", !a.getAttribute("className") }), c.getElementsByTagName = ja(function (a) { return a.appendChild(g.createComment("")), !a.getElementsByTagName("*").length }), c.getElementsByClassName = $.test(g.getElementsByClassName), c.getById = ja(function (a) { return o.appendChild(a).id = u, !g.getElementsByName || !g.getElementsByName(u).length }), c.getById ? (d.find.ID = function (a, b) { if ("undefined" != typeof b.getElementById && p) { var c = b.getElementById(a); return c && c.parentNode ? [c] : [] } }, d.filter.ID = function (a) { var b = a.replace(ca, da); return function (a) { return a.getAttribute("id") === b } }) : (delete d.find.ID, d.filter.ID = function (a) { var b = a.replace(ca, da); return function (a) { var c = "undefined" != typeof a.getAttributeNode && a.getAttributeNode("id"); return c && c.value === b } }), d.find.TAG = c.getElementsByTagName ? function (a, b) { return "undefined" != typeof b.getElementsByTagName ? b.getElementsByTagName(a) : c.qsa ? b.querySelectorAll(a) : void 0 } : function (a, b) { var c, d = [], e = 0, f = b.getElementsByTagName(a); if ("*" === a) { while (c = f[e++]) 1 === c.nodeType && d.push(c); return d } return f }, d.find.CLASS = c.getElementsByClassName && function (a, b) { return p ? b.getElementsByClassName(a) : void 0 }, r = [], q = [], (c.qsa = $.test(g.querySelectorAll)) && (ja(function (a) { o.appendChild(a).innerHTML = "<a id='" + u + "'></a><select id='" + u + "-\f]' msallowcapture=''><option selected=''></option></select>", a.querySelectorAll("[msallowcapture^='']").length && q.push("[*^$]=" + L + "*(?:''|\"\")"), a.querySelectorAll("[selected]").length || q.push("\\[" + L + "*(?:value|" + K + ")"), a.querySelectorAll("[id~=" + u + "-]").length || q.push("~="), a.querySelectorAll(":checked").length || q.push(":checked"), a.querySelectorAll("a#" + u + "+*").length || q.push(".#.+[+~]") }), ja(function (a) { var b = g.createElement("input"); b.setAttribute("type", "hidden"), a.appendChild(b).setAttribute("name", "D"), a.querySelectorAll("[name=d]").length && q.push("name" + L + "*[*^$|!~]?="), a.querySelectorAll(":enabled").length || q.push(":enabled", ":disabled"), a.querySelectorAll("*,:x"), q.push(",.*:") })), (c.matchesSelector = $.test(s = o.matches || o.webkitMatchesSelector || o.mozMatchesSelector || o.oMatchesSelector || o.msMatchesSelector)) && ja(function (a) { c.disconnectedMatch = s.call(a, "div"), s.call(a, "[s!='']:x"), r.push("!=", P) }), q = q.length && new RegExp(q.join("|")), r = r.length && new RegExp(r.join("|")), b = $.test(o.compareDocumentPosition), t = b || $.test(o.contains) ? function (a, b) { var c = 9 === a.nodeType ? a.documentElement : a, d = b && b.parentNode; return a === d || !(!d || 1 !== d.nodeType || !(c.contains ? c.contains(d) : a.compareDocumentPosition && 16 & a.compareDocumentPosition(d))) } : function (a, b) { if (b) while (b = b.parentNode) if (b === a) return !0; return !1 }, B = b ? function (a, b) { if (a === b) return l = !0, 0; var d = !a.compareDocumentPosition - !b.compareDocumentPosition; return d ? d : (d = (a.ownerDocument || a) === (b.ownerDocument || b) ? a.compareDocumentPosition(b) : 1, 1 & d || !c.sortDetached && b.compareDocumentPosition(a) === d ? a === g || a.ownerDocument === v && t(v, a) ? -1 : b === g || b.ownerDocument === v && t(v, b) ? 1 : k ? J(k, a) - J(k, b) : 0 : 4 & d ? -1 : 1) } : function (a, b) { if (a === b) return l = !0, 0; var c, d = 0, e = a.parentNode, f = b.parentNode, h = [a], i = [b]; if (!e || !f) return a === g ? -1 : b === g ? 1 : e ? -1 : f ? 1 : k ? J(k, a) - J(k, b) : 0; if (e === f) return la(a, b); c = a; while (c = c.parentNode) h.unshift(c); c = b; while (c = c.parentNode) i.unshift(c); while (h[d] === i[d]) d++; return d ? la(h[d], i[d]) : h[d] === v ? -1 : i[d] === v ? 1 : 0 }, g) : n }, ga.matches = function (a, b) { return ga(a, null, null, b) }, ga.matchesSelector = function (a, b) { if ((a.ownerDocument || a) !== n && m(a), b = b.replace(U, "='$1']"), !(!c.matchesSelector || !p || r && r.test(b) || q && q.test(b))) try { var d = s.call(a, b); if (d || c.disconnectedMatch || a.document && 11 !== a.document.nodeType) return d } catch (e) { } return ga(b, n, null, [a]).length > 0 }, ga.contains = function (a, b) { return (a.ownerDocument || a) !== n && m(a), t(a, b) }, ga.attr = function (a, b) { (a.ownerDocument || a) !== n && m(a); var e = d.attrHandle[b.toLowerCase()], f = e && D.call(d.attrHandle, b.toLowerCase()) ? e(a, b, !p) : void 0; return void 0 !== f ? f : c.attributes || !p ? a.getAttribute(b) : (f = a.getAttributeNode(b)) && f.specified ? f.value : null }, ga.error = function (a) { throw new Error("Syntax error, unrecognized expression: " + a) }, ga.uniqueSort = function (a) { var b, d = [], e = 0, f = 0; if (l = !c.detectDuplicates, k = !c.sortStable && a.slice(0), a.sort(B), l) { while (b = a[f++]) b === a[f] && (e = d.push(f)); while (e--) a.splice(d[e], 1) } return k = null, a }, e = ga.getText = function (a) { var b, c = "", d = 0, f = a.nodeType; if (f) { if (1 === f || 9 === f || 11 === f) { if ("string" == typeof a.textContent) return a.textContent; for (a = a.firstChild; a; a = a.nextSibling) c += e(a) } else if (3 === f || 4 === f) return a.nodeValue } else while (b = a[d++]) c += e(b); return c }, d = ga.selectors = { cacheLength: 50, createPseudo: ia, match: X, attrHandle: {}, find: {}, relative: { ">": { dir: "parentNode", first: !0 }, " ": { dir: "parentNode" }, "+": { dir: "previousSibling", first: !0 }, "~": { dir: "previousSibling" } }, preFilter: { ATTR: function (a) { return a[1] = a[1].replace(ca, da), a[3] = (a[3] || a[4] || a[5] || "").replace(ca, da), "~=" === a[2] && (a[3] = " " + a[3] + " "), a.slice(0, 4) }, CHILD: function (a) { return a[1] = a[1].toLowerCase(), "nth" === a[1].slice(0, 3) ? (a[3] || ga.error(a[0]), a[4] = +(a[4] ? a[5] + (a[6] || 1) : 2 * ("even" === a[3] || "odd" === a[3])), a[5] = +(a[7] + a[8] || "odd" === a[3])) : a[3] && ga.error(a[0]), a }, PSEUDO: function (a) { var b, c = !a[6] && a[2]; return X.CHILD.test(a[0]) ? null : (a[3] ? a[2] = a[4] || a[5] || "" : c && V.test(c) && (b = g(c, !0)) && (b = c.indexOf(")", c.length - b) - c.length) && (a[0] = a[0].slice(0, b), a[2] = c.slice(0, b)), a.slice(0, 3)) } }, filter: { TAG: function (a) { var b = a.replace(ca, da).toLowerCase(); return "*" === a ? function () { return !0 } : function (a) { return a.nodeName && a.nodeName.toLowerCase() === b } }, CLASS: function (a) { var b = y[a + " "]; return b || (b = new RegExp("(^|" + L + ")" + a + "(" + L + "|$)")) && y(a, function (a) { return b.test("string" == typeof a.className && a.className || "undefined" != typeof a.getAttribute && a.getAttribute("class") || "") }) }, ATTR: function (a, b, c) { return function (d) { var e = ga.attr(d, a); return null == e ? "!=" === b : b ? (e += "", "=" === b ? e === c : "!=" === b ? e !== c : "^=" === b ? c && 0 === e.indexOf(c) : "*=" === b ? c && e.indexOf(c) > -1 : "$=" === b ? c && e.slice(-c.length) === c : "~=" === b ? (" " + e.replace(Q, " ") + " ").indexOf(c) > -1 : "|=" === b ? e === c || e.slice(0, c.length + 1) === c + "-" : !1) : !0 } }, CHILD: function (a, b, c, d, e) { var f = "nth" !== a.slice(0, 3), g = "last" !== a.slice(-4), h = "of-type" === b; return 1 === d && 0 === e ? function (a) { return !!a.parentNode } : function (b, c, i) { var j, k, l, m, n, o, p = f !== g ? "nextSibling" : "previousSibling", q = b.parentNode, r = h && b.nodeName.toLowerCase(), s = !i && !h; if (q) { if (f) { while (p) { l = b; while (l = l[p]) if (h ? l.nodeName.toLowerCase() === r : 1 === l.nodeType) return !1; o = p = "only" === a && !o && "nextSibling" } return !0 } if (o = [g ? q.firstChild : q.lastChild], g && s) { k = q[u] || (q[u] = {}), j = k[a] || [], n = j[0] === w && j[1], m = j[0] === w && j[2], l = n && q.childNodes[n]; while (l = ++n && l && l[p] || (m = n = 0) || o.pop()) if (1 === l.nodeType && ++m && l === b) { k[a] = [w, n, m]; break } } else if (s && (j = (b[u] || (b[u] = {}))[a]) && j[0] === w) m = j[1]; else while (l = ++n && l && l[p] || (m = n = 0) || o.pop()) if ((h ? l.nodeName.toLowerCase() === r : 1 === l.nodeType) && ++m && (s && ((l[u] || (l[u] = {}))[a] = [w, m]), l === b)) break; return m -= e, m === d || m % d === 0 && m / d >= 0 } } }, PSEUDO: function (a, b) { var c, e = d.pseudos[a] || d.setFilters[a.toLowerCase()] || ga.error("unsupported pseudo: " + a); return e[u] ? e(b) : e.length > 1 ? (c = [a, a, "", b], d.setFilters.hasOwnProperty(a.toLowerCase()) ? ia(function (a, c) { var d, f = e(a, b), g = f.length; while (g--) d = J(a, f[g]), a[d] = !(c[d] = f[g]) }) : function (a) { return e(a, 0, c) }) : e } }, pseudos: { not: ia(function (a) { var b = [], c = [], d = h(a.replace(R, "$1")); return d[u] ? ia(function (a, b, c, e) { var f, g = d(a, null, e, []), h = a.length; while (h--) (f = g[h]) && (a[h] = !(b[h] = f)) }) : function (a, e, f) { return b[0] = a, d(b, null, f, c), b[0] = null, !c.pop() } }), has: ia(function (a) { return function (b) { return ga(a, b).length > 0 } }), contains: ia(function (a) { return a = a.replace(ca, da), function (b) { return (b.textContent || b.innerText || e(b)).indexOf(a) > -1 } }), lang: ia(function (a) { return W.test(a || "") || ga.error("unsupported lang: " + a), a = a.replace(ca, da).toLowerCase(), function (b) { var c; do if (c = p ? b.lang : b.getAttribute("xml:lang") || b.getAttribute("lang")) return c = c.toLowerCase(), c === a || 0 === c.indexOf(a + "-"); while ((b = b.parentNode) && 1 === b.nodeType); return !1 } }), target: function (b) { var c = a.location && a.location.hash; return c && c.slice(1) === b.id }, root: function (a) { return a === o }, focus: function (a) { return a === n.activeElement && (!n.hasFocus || n.hasFocus()) && !!(a.type || a.href || ~a.tabIndex) }, enabled: function (a) { return a.disabled === !1 }, disabled: function (a) { return a.disabled === !0 }, checked: function (a) { var b = a.nodeName.toLowerCase(); return "input" === b && !!a.checked || "option" === b && !!a.selected }, selected: function (a) { return a.parentNode && a.parentNode.selectedIndex, a.selected === !0 }, empty: function (a) { for (a = a.firstChild; a; a = a.nextSibling) if (a.nodeType < 6) return !1; return !0 }, parent: function (a) { return !d.pseudos.empty(a) }, header: function (a) { return Z.test(a.nodeName) }, input: function (a) { return Y.test(a.nodeName) }, button: function (a) { var b = a.nodeName.toLowerCase(); return "input" === b && "button" === a.type || "button" === b }, text: function (a) { var b; return "input" === a.nodeName.toLowerCase() && "text" === a.type && (null == (b = a.getAttribute("type")) || "text" === b.toLowerCase()) }, first: oa(function () { return [0] }), last: oa(function (a, b) { return [b - 1] }), eq: oa(function (a, b, c) { return [0 > c ? c + b : c] }), even: oa(function (a, b) { for (var c = 0; b > c; c += 2) a.push(c); return a }), odd: oa(function (a, b) { for (var c = 1; b > c; c += 2) a.push(c); return a }), lt: oa(function (a, b, c) { for (var d = 0 > c ? c + b : c; --d >= 0;) a.push(d); return a }), gt: oa(function (a, b, c) { for (var d = 0 > c ? c + b : c; ++d < b;) a.push(d); return a }) } }, d.pseudos.nth = d.pseudos.eq; for (b in { radio: !0, checkbox: !0, file: !0, password: !0, image: !0 }) d.pseudos[b] = ma(b); for (b in { submit: !0, reset: !0 }) d.pseudos[b] = na(b); function qa() { } qa.prototype = d.filters = d.pseudos, d.setFilters = new qa, g = ga.tokenize = function (a, b) { var c, e, f, g, h, i, j, k = z[a + " "]; if (k) return b ? 0 : k.slice(0); h = a, i = [], j = d.preFilter; while (h) { (!c || (e = S.exec(h))) && (e && (h = h.slice(e[0].length) || h), i.push(f = [])), c = !1, (e = T.exec(h)) && (c = e.shift(), f.push({ value: c, type: e[0].replace(R, " ") }), h = h.slice(c.length)); for (g in d.filter) !(e = X[g].exec(h)) || j[g] && !(e = j[g](e)) || (c = e.shift(), f.push({ value: c, type: g, matches: e }), h = h.slice(c.length)); if (!c) break } return b ? h.length : h ? ga.error(a) : z(a, i).slice(0) }; function ra(a) { for (var b = 0, c = a.length, d = ""; c > b; b++) d += a[b].value; return d } function sa(a, b, c) { var d = b.dir, e = c && "parentNode" === d, f = x++; return b.first ? function (b, c, f) { while (b = b[d]) if (1 === b.nodeType || e) return a(b, c, f) } : function (b, c, g) { var h, i, j = [w, f]; if (g) { while (b = b[d]) if ((1 === b.nodeType || e) && a(b, c, g)) return !0 } else while (b = b[d]) if (1 === b.nodeType || e) { if (i = b[u] || (b[u] = {}), (h = i[d]) && h[0] === w && h[1] === f) return j[2] = h[2]; if (i[d] = j, j[2] = a(b, c, g)) return !0 } } } function ta(a) { return a.length > 1 ? function (b, c, d) { var e = a.length; while (e--) if (!a[e](b, c, d)) return !1; return !0 } : a[0] } function ua(a, b, c) { for (var d = 0, e = b.length; e > d; d++) ga(a, b[d], c); return c } function va(a, b, c, d, e) { for (var f, g = [], h = 0, i = a.length, j = null != b; i > h; h++) (f = a[h]) && (!c || c(f, d, e)) && (g.push(f), j && b.push(h)); return g } function wa(a, b, c, d, e, f) { return d && !d[u] && (d = wa(d)), e && !e[u] && (e = wa(e, f)), ia(function (f, g, h, i) { var j, k, l, m = [], n = [], o = g.length, p = f || ua(b || "*", h.nodeType ? [h] : h, []), q = !a || !f && b ? p : va(p, m, a, h, i), r = c ? e || (f ? a : o || d) ? [] : g : q; if (c && c(q, r, h, i), d) { j = va(r, n), d(j, [], h, i), k = j.length; while (k--) (l = j[k]) && (r[n[k]] = !(q[n[k]] = l)) } if (f) { if (e || a) { if (e) { j = [], k = r.length; while (k--) (l = r[k]) && j.push(q[k] = l); e(null, r = [], j, i) } k = r.length; while (k--) (l = r[k]) && (j = e ? J(f, l) : m[k]) > -1 && (f[j] = !(g[j] = l)) } } else r = va(r === g ? r.splice(o, r.length) : r), e ? e(null, g, r, i) : H.apply(g, r) }) } function xa(a) { for (var b, c, e, f = a.length, g = d.relative[a[0].type], h = g || d.relative[" "], i = g ? 1 : 0, k = sa(function (a) { return a === b }, h, !0), l = sa(function (a) { return J(b, a) > -1 }, h, !0), m = [function (a, c, d) { var e = !g && (d || c !== j) || ((b = c).nodeType ? k(a, c, d) : l(a, c, d)); return b = null, e }]; f > i; i++) if (c = d.relative[a[i].type]) m = [sa(ta(m), c)]; else { if (c = d.filter[a[i].type].apply(null, a[i].matches), c[u]) { for (e = ++i; f > e; e++) if (d.relative[a[e].type]) break; return wa(i > 1 && ta(m), i > 1 && ra(a.slice(0, i - 1).concat({ value: " " === a[i - 2].type ? "*" : "" })).replace(R, "$1"), c, e > i && xa(a.slice(i, e)), f > e && xa(a = a.slice(e)), f > e && ra(a)) } m.push(c) } return ta(m) } function ya(a, b) { var c = b.length > 0, e = a.length > 0, f = function (f, g, h, i, k) { var l, m, o, p = 0, q = "0", r = f && [], s = [], t = j, u = f || e && d.find.TAG("*", k), v = w += null == t ? 1 : Math.random() || .1, x = u.length; for (k && (j = g !== n && g) ; q !== x && null != (l = u[q]) ; q++) { if (e && l) { m = 0; while (o = a[m++]) if (o(l, g, h)) { i.push(l); break } k && (w = v) } c && ((l = !o && l) && p--, f && r.push(l)) } if (p += q, c && q !== p) { m = 0; while (o = b[m++]) o(r, s, g, h); if (f) { if (p > 0) while (q--) r[q] || s[q] || (s[q] = F.call(i)); s = va(s) } H.apply(i, s), k && !f && s.length > 0 && p + b.length > 1 && ga.uniqueSort(i) } return k && (w = v, j = t), r }; return c ? ia(f) : f } return h = ga.compile = function (a, b) { var c, d = [], e = [], f = A[a + " "]; if (!f) { b || (b = g(a)), c = b.length; while (c--) f = xa(b[c]), f[u] ? d.push(f) : e.push(f); f = A(a, ya(e, d)), f.selector = a } return f }, i = ga.select = function (a, b, e, f) { var i, j, k, l, m, n = "function" == typeof a && a, o = !f && g(a = n.selector || a); if (e = e || [], 1 === o.length) { if (j = o[0] = o[0].slice(0), j.length > 2 && "ID" === (k = j[0]).type && c.getById && 9 === b.nodeType && p && d.relative[j[1].type]) { if (b = (d.find.ID(k.matches[0].replace(ca, da), b) || [])[0], !b) return e; n && (b = b.parentNode), a = a.slice(j.shift().value.length) } i = X.needsContext.test(a) ? 0 : j.length; while (i--) { if (k = j[i], d.relative[l = k.type]) break; if ((m = d.find[l]) && (f = m(k.matches[0].replace(ca, da), aa.test(j[0].type) && pa(b.parentNode) || b))) { if (j.splice(i, 1), a = f.length && ra(j), !a) return H.apply(e, f), e; break } } } return (n || h(a, o))(f, b, !p, e, aa.test(a) && pa(b.parentNode) || b), e }, c.sortStable = u.split("").sort(B).join("") === u, c.detectDuplicates = !!l, m(), c.sortDetached = ja(function (a) { return 1 & a.compareDocumentPosition(n.createElement("div")) }), ja(function (a) { return a.innerHTML = "<a href='#'></a>", "#" === a.firstChild.getAttribute("href") }) || ka("type|href|height|width", function (a, b, c) { return c ? void 0 : a.getAttribute(b, "type" === b.toLowerCase() ? 1 : 2) }), c.attributes && ja(function (a) { return a.innerHTML = "<input/>", a.firstChild.setAttribute("value", ""), "" === a.firstChild.getAttribute("value") }) || ka("value", function (a, b, c) { return c || "input" !== a.nodeName.toLowerCase() ? void 0 : a.defaultValue }), ja(function (a) { return null == a.getAttribute("disabled") }) || ka(K, function (a, b, c) { var d; return c ? void 0 : a[b] === !0 ? b.toLowerCase() : (d = a.getAttributeNode(b)) && d.specified ? d.value : null }), ga }(a); n.find = t, n.expr = t.selectors, n.expr[":"] = n.expr.pseudos, n.unique = t.uniqueSort, n.text = t.getText, n.isXMLDoc = t.isXML, n.contains = t.contains; var u = n.expr.match.needsContext, v = /^<(\w+)\s*\/?>(?:<\/\1>|)$/, w = /^.[^:#\[\.,]*$/; function x(a, b, c) { if (n.isFunction(b)) return n.grep(a, function (a, d) { return !!b.call(a, d, a) !== c }); if (b.nodeType) return n.grep(a, function (a) { return a === b !== c }); if ("string" == typeof b) { if (w.test(b)) return n.filter(b, a, c); b = n.filter(b, a) } return n.grep(a, function (a) { return g.call(b, a) >= 0 !== c }) } n.filter = function (a, b, c) { var d = b[0]; return c && (a = ":not(" + a + ")"), 1 === b.length && 1 === d.nodeType ? n.find.matchesSelector(d, a) ? [d] : [] : n.find.matches(a, n.grep(b, function (a) { return 1 === a.nodeType })) }, n.fn.extend({ find: function (a) { var b, c = this.length, d = [], e = this; if ("string" != typeof a) return this.pushStack(n(a).filter(function () { for (b = 0; c > b; b++) if (n.contains(e[b], this)) return !0 })); for (b = 0; c > b; b++) n.find(a, e[b], d); return d = this.pushStack(c > 1 ? n.unique(d) : d), d.selector = this.selector ? this.selector + " " + a : a, d }, filter: function (a) { return this.pushStack(x(this, a || [], !1)) }, not: function (a) { return this.pushStack(x(this, a || [], !0)) }, is: function (a) { return !!x(this, "string" == typeof a && u.test(a) ? n(a) : a || [], !1).length } }); var y, z = /^(?:\s*(<[\w\W]+>)[^>]*|#([\w-]*))$/, A = n.fn.init = function (a, b) { var c, d; if (!a) return this; if ("string" == typeof a) { if (c = "<" === a[0] && ">" === a[a.length - 1] && a.length >= 3 ? [null, a, null] : z.exec(a), !c || !c[1] && b) return !b || b.jquery ? (b || y).find(a) : this.constructor(b).find(a); if (c[1]) { if (b = b instanceof n ? b[0] : b, n.merge(this, n.parseHTML(c[1], b && b.nodeType ? b.ownerDocument || b : l, !0)), v.test(c[1]) && n.isPlainObject(b)) for (c in b) n.isFunction(this[c]) ? this[c](b[c]) : this.attr(c, b[c]); return this } return d = l.getElementById(c[2]), d && d.parentNode && (this.length = 1, this[0] = d), this.context = l, this.selector = a, this } return a.nodeType ? (this.context = this[0] = a, this.length = 1, this) : n.isFunction(a) ? "undefined" != typeof y.ready ? y.ready(a) : a(n) : (void 0 !== a.selector && (this.selector = a.selector, this.context = a.context), n.makeArray(a, this)) }; A.prototype = n.fn, y = n(l); var B = /^(?:parents|prev(?:Until|All))/, C = { children: !0, contents: !0, next: !0, prev: !0 }; n.extend({ dir: function (a, b, c) { var d = [], e = void 0 !== c; while ((a = a[b]) && 9 !== a.nodeType) if (1 === a.nodeType) { if (e && n(a).is(c)) break; d.push(a) } return d }, sibling: function (a, b) { for (var c = []; a; a = a.nextSibling) 1 === a.nodeType && a !== b && c.push(a); return c } }), n.fn.extend({ has: function (a) { var b = n(a, this), c = b.length; return this.filter(function () { for (var a = 0; c > a; a++) if (n.contains(this, b[a])) return !0 }) }, closest: function (a, b) { for (var c, d = 0, e = this.length, f = [], g = u.test(a) || "string" != typeof a ? n(a, b || this.context) : 0; e > d; d++) for (c = this[d]; c && c !== b; c = c.parentNode) if (c.nodeType < 11 && (g ? g.index(c) > -1 : 1 === c.nodeType && n.find.matchesSelector(c, a))) { f.push(c); break } return this.pushStack(f.length > 1 ? n.unique(f) : f) }, index: function (a) { return a ? "string" == typeof a ? g.call(n(a), this[0]) : g.call(this, a.jquery ? a[0] : a) : this[0] && this[0].parentNode ? this.first().prevAll().length : -1 }, add: function (a, b) { return this.pushStack(n.unique(n.merge(this.get(), n(a, b)))) }, addBack: function (a) { return this.add(null == a ? this.prevObject : this.prevObject.filter(a)) } }); function D(a, b) { while ((a = a[b]) && 1 !== a.nodeType); return a } n.each({ parent: function (a) { var b = a.parentNode; return b && 11 !== b.nodeType ? b : null }, parents: function (a) { return n.dir(a, "parentNode") }, parentsUntil: function (a, b, c) { return n.dir(a, "parentNode", c) }, next: function (a) { return D(a, "nextSibling") }, prev: function (a) { return D(a, "previousSibling") }, nextAll: function (a) { return n.dir(a, "nextSibling") }, prevAll: function (a) { return n.dir(a, "previousSibling") }, nextUntil: function (a, b, c) { return n.dir(a, "nextSibling", c) }, prevUntil: function (a, b, c) { return n.dir(a, "previousSibling", c) }, siblings: function (a) { return n.sibling((a.parentNode || {}).firstChild, a) }, children: function (a) { return n.sibling(a.firstChild) }, contents: function (a) { return a.contentDocument || n.merge([], a.childNodes) } }, function (a, b) { n.fn[a] = function (c, d) { var e = n.map(this, b, c); return "Until" !== a.slice(-5) && (d = c), d && "string" == typeof d && (e = n.filter(d, e)), this.length > 1 && (C[a] || n.unique(e), B.test(a) && e.reverse()), this.pushStack(e) } }); var E = /\S+/g, F = {}; function G(a) { var b = F[a] = {}; return n.each(a.match(E) || [], function (a, c) { b[c] = !0 }), b } n.Callbacks = function (a) { a = "string" == typeof a ? F[a] || G(a) : n.extend({}, a); var b, c, d, e, f, g, h = [], i = !a.once && [], j = function (l) { for (b = a.memory && l, c = !0, g = e || 0, e = 0, f = h.length, d = !0; h && f > g; g++) if (h[g].apply(l[0], l[1]) === !1 && a.stopOnFalse) { b = !1; break } d = !1, h && (i ? i.length && j(i.shift()) : b ? h = [] : k.disable()) }, k = { add: function () { if (h) { var c = h.length; !function g(b) { n.each(b, function (b, c) { var d = n.type(c); "function" === d ? a.unique && k.has(c) || h.push(c) : c && c.length && "string" !== d && g(c) }) }(arguments), d ? f = h.length : b && (e = c, j(b)) } return this }, remove: function () { return h && n.each(arguments, function (a, b) { var c; while ((c = n.inArray(b, h, c)) > -1) h.splice(c, 1), d && (f >= c && f--, g >= c && g--) }), this }, has: function (a) { return a ? n.inArray(a, h) > -1 : !(!h || !h.length) }, empty: function () { return h = [], f = 0, this }, disable: function () { return h = i = b = void 0, this }, disabled: function () { return !h }, lock: function () { return i = void 0, b || k.disable(), this }, locked: function () { return !i }, fireWith: function (a, b) { return !h || c && !i || (b = b || [], b = [a, b.slice ? b.slice() : b], d ? i.push(b) : j(b)), this }, fire: function () { return k.fireWith(this, arguments), this }, fired: function () { return !!c } }; return k }, n.extend({ Deferred: function (a) { var b = [["resolve", "done", n.Callbacks("once memory"), "resolved"], ["reject", "fail", n.Callbacks("once memory"), "rejected"], ["notify", "progress", n.Callbacks("memory")]], c = "pending", d = { state: function () { return c }, always: function () { return e.done(arguments).fail(arguments), this }, then: function () { var a = arguments; return n.Deferred(function (c) { n.each(b, function (b, f) { var g = n.isFunction(a[b]) && a[b]; e[f[1]](function () { var a = g && g.apply(this, arguments); a && n.isFunction(a.promise) ? a.promise().done(c.resolve).fail(c.reject).progress(c.notify) : c[f[0] + "With"](this === d ? c.promise() : this, g ? [a] : arguments) }) }), a = null }).promise() }, promise: function (a) { return null != a ? n.extend(a, d) : d } }, e = {}; return d.pipe = d.then, n.each(b, function (a, f) { var g = f[2], h = f[3]; d[f[1]] = g.add, h && g.add(function () { c = h }, b[1 ^ a][2].disable, b[2][2].lock), e[f[0]] = function () { return e[f[0] + "With"](this === e ? d : this, arguments), this }, e[f[0] + "With"] = g.fireWith }), d.promise(e), a && a.call(e, e), e }, when: function (a) { var b = 0, c = d.call(arguments), e = c.length, f = 1 !== e || a && n.isFunction(a.promise) ? e : 0, g = 1 === f ? a : n.Deferred(), h = function (a, b, c) { return function (e) { b[a] = this, c[a] = arguments.length > 1 ? d.call(arguments) : e, c === i ? g.notifyWith(b, c) : --f || g.resolveWith(b, c) } }, i, j, k; if (e > 1) for (i = new Array(e), j = new Array(e), k = new Array(e) ; e > b; b++) c[b] && n.isFunction(c[b].promise) ? c[b].promise().done(h(b, k, c)).fail(g.reject).progress(h(b, j, i)) : --f; return f || g.resolveWith(k, c), g.promise() } }); var H; n.fn.ready = function (a) { return n.ready.promise().done(a), this }, n.extend({ isReady: !1, readyWait: 1, holdReady: function (a) { a ? n.readyWait++ : n.ready(!0) }, ready: function (a) { (a === !0 ? --n.readyWait : n.isReady) || (n.isReady = !0, a !== !0 && --n.readyWait > 0 || (H.resolveWith(l, [n]), n.fn.triggerHandler && (n(l).triggerHandler("ready"), n(l).off("ready")))) } }); function I() { l.removeEventListener("DOMContentLoaded", I, !1), a.removeEventListener("load", I, !1), n.ready() } n.ready.promise = function (b) { return H || (H = n.Deferred(), "complete" === l.readyState ? setTimeout(n.ready) : (l.addEventListener("DOMContentLoaded", I, !1), a.addEventListener("load", I, !1))), H.promise(b) }, n.ready.promise(); var J = n.access = function (a, b, c, d, e, f, g) { var h = 0, i = a.length, j = null == c; if ("object" === n.type(c)) { e = !0; for (h in c) n.access(a, b, h, c[h], !0, f, g) } else if (void 0 !== d && (e = !0, n.isFunction(d) || (g = !0), j && (g ? (b.call(a, d), b = null) : (j = b, b = function (a, b, c) { return j.call(n(a), c) })), b)) for (; i > h; h++) b(a[h], c, g ? d : d.call(a[h], h, b(a[h], c))); return e ? a : j ? b.call(a) : i ? b(a[0], c) : f }; n.acceptData = function (a) { return 1 === a.nodeType || 9 === a.nodeType || !+a.nodeType }; function K() { Object.defineProperty(this.cache = {}, 0, { get: function () { return {} } }), this.expando = n.expando + K.uid++ } K.uid = 1, K.accepts = n.acceptData, K.prototype = { key: function (a) { if (!K.accepts(a)) return 0; var b = {}, c = a[this.expando]; if (!c) { c = K.uid++; try { b[this.expando] = { value: c }, Object.defineProperties(a, b) } catch (d) { b[this.expando] = c, n.extend(a, b) } } return this.cache[c] || (this.cache[c] = {}), c }, set: function (a, b, c) { var d, e = this.key(a), f = this.cache[e]; if ("string" == typeof b) f[b] = c; else if (n.isEmptyObject(f)) n.extend(this.cache[e], b); else for (d in b) f[d] = b[d]; return f }, get: function (a, b) { var c = this.cache[this.key(a)]; return void 0 === b ? c : c[b] }, access: function (a, b, c) { var d; return void 0 === b || b && "string" == typeof b && void 0 === c ? (d = this.get(a, b), void 0 !== d ? d : this.get(a, n.camelCase(b))) : (this.set(a, b, c), void 0 !== c ? c : b) }, remove: function (a, b) { var c, d, e, f = this.key(a), g = this.cache[f]; if (void 0 === b) this.cache[f] = {}; else { n.isArray(b) ? d = b.concat(b.map(n.camelCase)) : (e = n.camelCase(b), b in g ? d = [b, e] : (d = e, d = d in g ? [d] : d.match(E) || [])), c = d.length; while (c--) delete g[d[c]] } }, hasData: function (a) { return !n.isEmptyObject(this.cache[a[this.expando]] || {}) }, discard: function (a) { a[this.expando] && delete this.cache[a[this.expando]] } }; var L = new K, M = new K, N = /^(?:\{[\w\W]*\}|\[[\w\W]*\])$/, O = /([A-Z])/g; function P(a, b, c) { var d; if (void 0 === c && 1 === a.nodeType) if (d = "data-" + b.replace(O, "-$1").toLowerCase(), c = a.getAttribute(d), "string" == typeof c) { try { c = "true" === c ? !0 : "false" === c ? !1 : "null" === c ? null : +c + "" === c ? +c : N.test(c) ? n.parseJSON(c) : c } catch (e) { } M.set(a, b, c) } else c = void 0; return c } n.extend({
		hasData: function (a) { return M.hasData(a) || L.hasData(a) }, data: function (a, b, c) {
			return M.access(a, b, c)
		}, removeData: function (a, b) { M.remove(a, b) }, _data: function (a, b, c) { return L.access(a, b, c) }, _removeData: function (a, b) { L.remove(a, b) }
	}), n.fn.extend({ data: function (a, b) { var c, d, e, f = this[0], g = f && f.attributes; if (void 0 === a) { if (this.length && (e = M.get(f), 1 === f.nodeType && !L.get(f, "hasDataAttrs"))) { c = g.length; while (c--) g[c] && (d = g[c].name, 0 === d.indexOf("data-") && (d = n.camelCase(d.slice(5)), P(f, d, e[d]))); L.set(f, "hasDataAttrs", !0) } return e } return "object" == typeof a ? this.each(function () { M.set(this, a) }) : J(this, function (b) { var c, d = n.camelCase(a); if (f && void 0 === b) { if (c = M.get(f, a), void 0 !== c) return c; if (c = M.get(f, d), void 0 !== c) return c; if (c = P(f, d, void 0), void 0 !== c) return c } else this.each(function () { var c = M.get(this, d); M.set(this, d, b), -1 !== a.indexOf("-") && void 0 !== c && M.set(this, a, b) }) }, null, b, arguments.length > 1, null, !0) }, removeData: function (a) { return this.each(function () { M.remove(this, a) }) } }), n.extend({ queue: function (a, b, c) { var d; return a ? (b = (b || "fx") + "queue", d = L.get(a, b), c && (!d || n.isArray(c) ? d = L.access(a, b, n.makeArray(c)) : d.push(c)), d || []) : void 0 }, dequeue: function (a, b) { b = b || "fx"; var c = n.queue(a, b), d = c.length, e = c.shift(), f = n._queueHooks(a, b), g = function () { n.dequeue(a, b) }; "inprogress" === e && (e = c.shift(), d--), e && ("fx" === b && c.unshift("inprogress"), delete f.stop, e.call(a, g, f)), !d && f && f.empty.fire() }, _queueHooks: function (a, b) { var c = b + "queueHooks"; return L.get(a, c) || L.access(a, c, { empty: n.Callbacks("once memory").add(function () { L.remove(a, [b + "queue", c]) }) }) } }), n.fn.extend({ queue: function (a, b) { var c = 2; return "string" != typeof a && (b = a, a = "fx", c--), arguments.length < c ? n.queue(this[0], a) : void 0 === b ? this : this.each(function () { var c = n.queue(this, a, b); n._queueHooks(this, a), "fx" === a && "inprogress" !== c[0] && n.dequeue(this, a) }) }, dequeue: function (a) { return this.each(function () { n.dequeue(this, a) }) }, clearQueue: function (a) { return this.queue(a || "fx", []) }, promise: function (a, b) { var c, d = 1, e = n.Deferred(), f = this, g = this.length, h = function () { --d || e.resolveWith(f, [f]) }; "string" != typeof a && (b = a, a = void 0), a = a || "fx"; while (g--) c = L.get(f[g], a + "queueHooks"), c && c.empty && (d++, c.empty.add(h)); return h(), e.promise(b) } }); var Q = /[+-]?(?:\d*\.|)\d+(?:[eE][+-]?\d+|)/.source, R = ["Top", "Right", "Bottom", "Left"], S = function (a, b) { return a = b || a, "none" === n.css(a, "display") || !n.contains(a.ownerDocument, a) }, T = /^(?:checkbox|radio)$/i; !function () { var a = l.createDocumentFragment(), b = a.appendChild(l.createElement("div")), c = l.createElement("input"); c.setAttribute("type", "radio"), c.setAttribute("checked", "checked"), c.setAttribute("name", "t"), b.appendChild(c), k.checkClone = b.cloneNode(!0).cloneNode(!0).lastChild.checked, b.innerHTML = "<textarea>x</textarea>", k.noCloneChecked = !!b.cloneNode(!0).lastChild.defaultValue }(); var U = "undefined"; k.focusinBubbles = "onfocusin" in a; var V = /^key/, W = /^(?:mouse|pointer|contextmenu)|click/, X = /^(?:focusinfocus|focusoutblur)$/, Y = /^([^.]*)(?:\.(.+)|)$/; function Z() { return !0 } function $() { return !1 } function _() { try { return l.activeElement } catch (a) { } } n.event = { global: {}, add: function (a, b, c, d, e) { var f, g, h, i, j, k, l, m, o, p, q, r = L.get(a); if (r) { c.handler && (f = c, c = f.handler, e = f.selector), c.guid || (c.guid = n.guid++), (i = r.events) || (i = r.events = {}), (g = r.handle) || (g = r.handle = function (b) { return typeof n !== U && n.event.triggered !== b.type ? n.event.dispatch.apply(a, arguments) : void 0 }), b = (b || "").match(E) || [""], j = b.length; while (j--) h = Y.exec(b[j]) || [], o = q = h[1], p = (h[2] || "").split(".").sort(), o && (l = n.event.special[o] || {}, o = (e ? l.delegateType : l.bindType) || o, l = n.event.special[o] || {}, k = n.extend({ type: o, origType: q, data: d, handler: c, guid: c.guid, selector: e, needsContext: e && n.expr.match.needsContext.test(e), namespace: p.join(".") }, f), (m = i[o]) || (m = i[o] = [], m.delegateCount = 0, l.setup && l.setup.call(a, d, p, g) !== !1 || a.addEventListener && a.addEventListener(o, g, !1)), l.add && (l.add.call(a, k), k.handler.guid || (k.handler.guid = c.guid)), e ? m.splice(m.delegateCount++, 0, k) : m.push(k), n.event.global[o] = !0) } }, remove: function (a, b, c, d, e) { var f, g, h, i, j, k, l, m, o, p, q, r = L.hasData(a) && L.get(a); if (r && (i = r.events)) { b = (b || "").match(E) || [""], j = b.length; while (j--) if (h = Y.exec(b[j]) || [], o = q = h[1], p = (h[2] || "").split(".").sort(), o) { l = n.event.special[o] || {}, o = (d ? l.delegateType : l.bindType) || o, m = i[o] || [], h = h[2] && new RegExp("(^|\\.)" + p.join("\\.(?:.*\\.|)") + "(\\.|$)"), g = f = m.length; while (f--) k = m[f], !e && q !== k.origType || c && c.guid !== k.guid || h && !h.test(k.namespace) || d && d !== k.selector && ("**" !== d || !k.selector) || (m.splice(f, 1), k.selector && m.delegateCount--, l.remove && l.remove.call(a, k)); g && !m.length && (l.teardown && l.teardown.call(a, p, r.handle) !== !1 || n.removeEvent(a, o, r.handle), delete i[o]) } else for (o in i) n.event.remove(a, o + b[j], c, d, !0); n.isEmptyObject(i) && (delete r.handle, L.remove(a, "events")) } }, trigger: function (b, c, d, e) { var f, g, h, i, k, m, o, p = [d || l], q = j.call(b, "type") ? b.type : b, r = j.call(b, "namespace") ? b.namespace.split(".") : []; if (g = h = d = d || l, 3 !== d.nodeType && 8 !== d.nodeType && !X.test(q + n.event.triggered) && (q.indexOf(".") >= 0 && (r = q.split("."), q = r.shift(), r.sort()), k = q.indexOf(":") < 0 && "on" + q, b = b[n.expando] ? b : new n.Event(q, "object" == typeof b && b), b.isTrigger = e ? 2 : 3, b.namespace = r.join("."), b.namespace_re = b.namespace ? new RegExp("(^|\\.)" + r.join("\\.(?:.*\\.|)") + "(\\.|$)") : null, b.result = void 0, b.target || (b.target = d), c = null == c ? [b] : n.makeArray(c, [b]), o = n.event.special[q] || {}, e || !o.trigger || o.trigger.apply(d, c) !== !1)) { if (!e && !o.noBubble && !n.isWindow(d)) { for (i = o.delegateType || q, X.test(i + q) || (g = g.parentNode) ; g; g = g.parentNode) p.push(g), h = g; h === (d.ownerDocument || l) && p.push(h.defaultView || h.parentWindow || a) } f = 0; while ((g = p[f++]) && !b.isPropagationStopped()) b.type = f > 1 ? i : o.bindType || q, m = (L.get(g, "events") || {})[b.type] && L.get(g, "handle"), m && m.apply(g, c), m = k && g[k], m && m.apply && n.acceptData(g) && (b.result = m.apply(g, c), b.result === !1 && b.preventDefault()); return b.type = q, e || b.isDefaultPrevented() || o._default && o._default.apply(p.pop(), c) !== !1 || !n.acceptData(d) || k && n.isFunction(d[q]) && !n.isWindow(d) && (h = d[k], h && (d[k] = null), n.event.triggered = q, d[q](), n.event.triggered = void 0, h && (d[k] = h)), b.result } }, dispatch: function (a) { a = n.event.fix(a); var b, c, e, f, g, h = [], i = d.call(arguments), j = (L.get(this, "events") || {})[a.type] || [], k = n.event.special[a.type] || {}; if (i[0] = a, a.delegateTarget = this, !k.preDispatch || k.preDispatch.call(this, a) !== !1) { h = n.event.handlers.call(this, a, j), b = 0; while ((f = h[b++]) && !a.isPropagationStopped()) { a.currentTarget = f.elem, c = 0; while ((g = f.handlers[c++]) && !a.isImmediatePropagationStopped()) (!a.namespace_re || a.namespace_re.test(g.namespace)) && (a.handleObj = g, a.data = g.data, e = ((n.event.special[g.origType] || {}).handle || g.handler).apply(f.elem, i), void 0 !== e && (a.result = e) === !1 && (a.preventDefault(), a.stopPropagation())) } return k.postDispatch && k.postDispatch.call(this, a), a.result } }, handlers: function (a, b) { var c, d, e, f, g = [], h = b.delegateCount, i = a.target; if (h && i.nodeType && (!a.button || "click" !== a.type)) for (; i !== this; i = i.parentNode || this) if (i.disabled !== !0 || "click" !== a.type) { for (d = [], c = 0; h > c; c++) f = b[c], e = f.selector + " ", void 0 === d[e] && (d[e] = f.needsContext ? n(e, this).index(i) >= 0 : n.find(e, this, null, [i]).length), d[e] && d.push(f); d.length && g.push({ elem: i, handlers: d }) } return h < b.length && g.push({ elem: this, handlers: b.slice(h) }), g }, props: "altKey bubbles cancelable ctrlKey currentTarget eventPhase metaKey relatedTarget shiftKey target timeStamp view which".split(" "), fixHooks: {}, keyHooks: { props: "char charCode key keyCode".split(" "), filter: function (a, b) { return null == a.which && (a.which = null != b.charCode ? b.charCode : b.keyCode), a } }, mouseHooks: { props: "button buttons clientX clientY offsetX offsetY pageX pageY screenX screenY toElement".split(" "), filter: function (a, b) { var c, d, e, f = b.button; return null == a.pageX && null != b.clientX && (c = a.target.ownerDocument || l, d = c.documentElement, e = c.body, a.pageX = b.clientX + (d && d.scrollLeft || e && e.scrollLeft || 0) - (d && d.clientLeft || e && e.clientLeft || 0), a.pageY = b.clientY + (d && d.scrollTop || e && e.scrollTop || 0) - (d && d.clientTop || e && e.clientTop || 0)), a.which || void 0 === f || (a.which = 1 & f ? 1 : 2 & f ? 3 : 4 & f ? 2 : 0), a } }, fix: function (a) { if (a[n.expando]) return a; var b, c, d, e = a.type, f = a, g = this.fixHooks[e]; g || (this.fixHooks[e] = g = W.test(e) ? this.mouseHooks : V.test(e) ? this.keyHooks : {}), d = g.props ? this.props.concat(g.props) : this.props, a = new n.Event(f), b = d.length; while (b--) c = d[b], a[c] = f[c]; return a.target || (a.target = l), 3 === a.target.nodeType && (a.target = a.target.parentNode), g.filter ? g.filter(a, f) : a }, special: { load: { noBubble: !0 }, focus: { trigger: function () { return this !== _() && this.focus ? (this.focus(), !1) : void 0 }, delegateType: "focusin" }, blur: { trigger: function () { return this === _() && this.blur ? (this.blur(), !1) : void 0 }, delegateType: "focusout" }, click: { trigger: function () { return "checkbox" === this.type && this.click && n.nodeName(this, "input") ? (this.click(), !1) : void 0 }, _default: function (a) { return n.nodeName(a.target, "a") } }, beforeunload: { postDispatch: function (a) { void 0 !== a.result && a.originalEvent && (a.originalEvent.returnValue = a.result) } } }, simulate: function (a, b, c, d) { var e = n.extend(new n.Event, c, { type: a, isSimulated: !0, originalEvent: {} }); d ? n.event.trigger(e, null, b) : n.event.dispatch.call(b, e), e.isDefaultPrevented() && c.preventDefault() } }, n.removeEvent = function (a, b, c) { a.removeEventListener && a.removeEventListener(b, c, !1) }, n.Event = function (a, b) { return this instanceof n.Event ? (a && a.type ? (this.originalEvent = a, this.type = a.type, this.isDefaultPrevented = a.defaultPrevented || void 0 === a.defaultPrevented && a.returnValue === !1 ? Z : $) : this.type = a, b && n.extend(this, b), this.timeStamp = a && a.timeStamp || n.now(), void (this[n.expando] = !0)) : new n.Event(a, b) }, n.Event.prototype = { isDefaultPrevented: $, isPropagationStopped: $, isImmediatePropagationStopped: $, preventDefault: function () { var a = this.originalEvent; this.isDefaultPrevented = Z, a && a.preventDefault && a.preventDefault() }, stopPropagation: function () { var a = this.originalEvent; this.isPropagationStopped = Z, a && a.stopPropagation && a.stopPropagation() }, stopImmediatePropagation: function () { var a = this.originalEvent; this.isImmediatePropagationStopped = Z, a && a.stopImmediatePropagation && a.stopImmediatePropagation(), this.stopPropagation() } }, n.each({ mouseenter: "mouseover", mouseleave: "mouseout", pointerenter: "pointerover", pointerleave: "pointerout" }, function (a, b) { n.event.special[a] = { delegateType: b, bindType: b, handle: function (a) { var c, d = this, e = a.relatedTarget, f = a.handleObj; return (!e || e !== d && !n.contains(d, e)) && (a.type = f.origType, c = f.handler.apply(this, arguments), a.type = b), c } } }), k.focusinBubbles || n.each({ focus: "focusin", blur: "focusout" }, function (a, b) { var c = function (a) { n.event.simulate(b, a.target, n.event.fix(a), !0) }; n.event.special[b] = { setup: function () { var d = this.ownerDocument || this, e = L.access(d, b); e || d.addEventListener(a, c, !0), L.access(d, b, (e || 0) + 1) }, teardown: function () { var d = this.ownerDocument || this, e = L.access(d, b) - 1; e ? L.access(d, b, e) : (d.removeEventListener(a, c, !0), L.remove(d, b)) } } }), n.fn.extend({ on: function (a, b, c, d, e) { var f, g; if ("object" == typeof a) { "string" != typeof b && (c = c || b, b = void 0); for (g in a) this.on(g, b, c, a[g], e); return this } if (null == c && null == d ? (d = b, c = b = void 0) : null == d && ("string" == typeof b ? (d = c, c = void 0) : (d = c, c = b, b = void 0)), d === !1) d = $; else if (!d) return this; return 1 === e && (f = d, d = function (a) { return n().off(a), f.apply(this, arguments) }, d.guid = f.guid || (f.guid = n.guid++)), this.each(function () { n.event.add(this, a, d, c, b) }) }, one: function (a, b, c, d) { return this.on(a, b, c, d, 1) }, off: function (a, b, c) { var d, e; if (a && a.preventDefault && a.handleObj) return d = a.handleObj, n(a.delegateTarget).off(d.namespace ? d.origType + "." + d.namespace : d.origType, d.selector, d.handler), this; if ("object" == typeof a) { for (e in a) this.off(e, b, a[e]); return this } return (b === !1 || "function" == typeof b) && (c = b, b = void 0), c === !1 && (c = $), this.each(function () { n.event.remove(this, a, c, b) }) }, trigger: function (a, b) { return this.each(function () { n.event.trigger(a, b, this) }) }, triggerHandler: function (a, b) { var c = this[0]; return c ? n.event.trigger(a, b, c, !0) : void 0 } }); var aa = /<(?!area|br|col|embed|hr|img|input|link|meta|param)(([\w:]+)[^>]*)\/>/gi, ba = /<([\w:]+)/, ca = /<|&#?\w+;/, da = /<(?:script|style|link)/i, ea = /checked\s*(?:[^=]|=\s*.checked.)/i, fa = /^$|\/(?:java|ecma)script/i, ga = /^true\/(.*)/, ha = /^\s*<!(?:\[CDATA\[|--)|(?:\]\]|--)>\s*$/g, ia = { option: [1, "<select multiple='multiple'>", "</select>"], thead: [1, "<table>", "</table>"], col: [2, "<table><colgroup>", "</colgroup></table>"], tr: [2, "<table><tbody>", "</tbody></table>"], td: [3, "<table><tbody><tr>", "</tr></tbody></table>"], _default: [0, "", ""] }; ia.optgroup = ia.option, ia.tbody = ia.tfoot = ia.colgroup = ia.caption = ia.thead, ia.th = ia.td; function ja(a, b) { return n.nodeName(a, "table") && n.nodeName(11 !== b.nodeType ? b : b.firstChild, "tr") ? a.getElementsByTagName("tbody")[0] || a.appendChild(a.ownerDocument.createElement("tbody")) : a } function ka(a) { return a.type = (null !== a.getAttribute("type")) + "/" + a.type, a } function la(a) { var b = ga.exec(a.type); return b ? a.type = b[1] : a.removeAttribute("type"), a } function ma(a, b) { for (var c = 0, d = a.length; d > c; c++) L.set(a[c], "globalEval", !b || L.get(b[c], "globalEval")) } function na(a, b) { var c, d, e, f, g, h, i, j; if (1 === b.nodeType) { if (L.hasData(a) && (f = L.access(a), g = L.set(b, f), j = f.events)) { delete g.handle, g.events = {}; for (e in j) for (c = 0, d = j[e].length; d > c; c++) n.event.add(b, e, j[e][c]) } M.hasData(a) && (h = M.access(a), i = n.extend({}, h), M.set(b, i)) } } function oa(a, b) { var c = a.getElementsByTagName ? a.getElementsByTagName(b || "*") : a.querySelectorAll ? a.querySelectorAll(b || "*") : []; return void 0 === b || b && n.nodeName(a, b) ? n.merge([a], c) : c } function pa(a, b) { var c = b.nodeName.toLowerCase(); "input" === c && T.test(a.type) ? b.checked = a.checked : ("input" === c || "textarea" === c) && (b.defaultValue = a.defaultValue) } n.extend({ clone: function (a, b, c) { var d, e, f, g, h = a.cloneNode(!0), i = n.contains(a.ownerDocument, a); if (!(k.noCloneChecked || 1 !== a.nodeType && 11 !== a.nodeType || n.isXMLDoc(a))) for (g = oa(h), f = oa(a), d = 0, e = f.length; e > d; d++) pa(f[d], g[d]); if (b) if (c) for (f = f || oa(a), g = g || oa(h), d = 0, e = f.length; e > d; d++) na(f[d], g[d]); else na(a, h); return g = oa(h, "script"), g.length > 0 && ma(g, !i && oa(a, "script")), h }, buildFragment: function (a, b, c, d) { for (var e, f, g, h, i, j, k = b.createDocumentFragment(), l = [], m = 0, o = a.length; o > m; m++) if (e = a[m], e || 0 === e) if ("object" === n.type(e)) n.merge(l, e.nodeType ? [e] : e); else if (ca.test(e)) { f = f || k.appendChild(b.createElement("div")), g = (ba.exec(e) || ["", ""])[1].toLowerCase(), h = ia[g] || ia._default, f.innerHTML = h[1] + e.replace(aa, "<$1></$2>") + h[2], j = h[0]; while (j--) f = f.lastChild; n.merge(l, f.childNodes), f = k.firstChild, f.textContent = "" } else l.push(b.createTextNode(e)); k.textContent = "", m = 0; while (e = l[m++]) if ((!d || -1 === n.inArray(e, d)) && (i = n.contains(e.ownerDocument, e), f = oa(k.appendChild(e), "script"), i && ma(f), c)) { j = 0; while (e = f[j++]) fa.test(e.type || "") && c.push(e) } return k }, cleanData: function (a) { for (var b, c, d, e, f = n.event.special, g = 0; void 0 !== (c = a[g]) ; g++) { if (n.acceptData(c) && (e = c[L.expando], e && (b = L.cache[e]))) { if (b.events) for (d in b.events) f[d] ? n.event.remove(c, d) : n.removeEvent(c, d, b.handle); L.cache[e] && delete L.cache[e] } delete M.cache[c[M.expando]] } } }), n.fn.extend({ text: function (a) { return J(this, function (a) { return void 0 === a ? n.text(this) : this.empty().each(function () { (1 === this.nodeType || 11 === this.nodeType || 9 === this.nodeType) && (this.textContent = a) }) }, null, a, arguments.length) }, append: function () { return this.domManip(arguments, function (a) { if (1 === this.nodeType || 11 === this.nodeType || 9 === this.nodeType) { var b = ja(this, a); b.appendChild(a) } }) }, prepend: function () { return this.domManip(arguments, function (a) { if (1 === this.nodeType || 11 === this.nodeType || 9 === this.nodeType) { var b = ja(this, a); b.insertBefore(a, b.firstChild) } }) }, before: function () { return this.domManip(arguments, function (a) { this.parentNode && this.parentNode.insertBefore(a, this) }) }, after: function () { return this.domManip(arguments, function (a) { this.parentNode && this.parentNode.insertBefore(a, this.nextSibling) }) }, remove: function (a, b) { for (var c, d = a ? n.filter(a, this) : this, e = 0; null != (c = d[e]) ; e++) b || 1 !== c.nodeType || n.cleanData(oa(c)), c.parentNode && (b && n.contains(c.ownerDocument, c) && ma(oa(c, "script")), c.parentNode.removeChild(c)); return this }, empty: function () { for (var a, b = 0; null != (a = this[b]) ; b++) 1 === a.nodeType && (n.cleanData(oa(a, !1)), a.textContent = ""); return this }, clone: function (a, b) { return a = null == a ? !1 : a, b = null == b ? a : b, this.map(function () { return n.clone(this, a, b) }) }, html: function (a) { return J(this, function (a) { var b = this[0] || {}, c = 0, d = this.length; if (void 0 === a && 1 === b.nodeType) return b.innerHTML; if ("string" == typeof a && !da.test(a) && !ia[(ba.exec(a) || ["", ""])[1].toLowerCase()]) { a = a.replace(aa, "<$1></$2>"); try { for (; d > c; c++) b = this[c] || {}, 1 === b.nodeType && (n.cleanData(oa(b, !1)), b.innerHTML = a); b = 0 } catch (e) { } } b && this.empty().append(a) }, null, a, arguments.length) }, replaceWith: function () { var a = arguments[0]; return this.domManip(arguments, function (b) { a = this.parentNode, n.cleanData(oa(this)), a && a.replaceChild(b, this) }), a && (a.length || a.nodeType) ? this : this.remove() }, detach: function (a) { return this.remove(a, !0) }, domManip: function (a, b) { a = e.apply([], a); var c, d, f, g, h, i, j = 0, l = this.length, m = this, o = l - 1, p = a[0], q = n.isFunction(p); if (q || l > 1 && "string" == typeof p && !k.checkClone && ea.test(p)) return this.each(function (c) { var d = m.eq(c); q && (a[0] = p.call(this, c, d.html())), d.domManip(a, b) }); if (l && (c = n.buildFragment(a, this[0].ownerDocument, !1, this), d = c.firstChild, 1 === c.childNodes.length && (c = d), d)) { for (f = n.map(oa(c, "script"), ka), g = f.length; l > j; j++) h = c, j !== o && (h = n.clone(h, !0, !0), g && n.merge(f, oa(h, "script"))), b.call(this[j], h, j); if (g) for (i = f[f.length - 1].ownerDocument, n.map(f, la), j = 0; g > j; j++) h = f[j], fa.test(h.type || "") && !L.access(h, "globalEval") && n.contains(i, h) && (h.src ? n._evalUrl && n._evalUrl(h.src) : n.globalEval(h.textContent.replace(ha, ""))) } return this } }), n.each({ appendTo: "append", prependTo: "prepend", insertBefore: "before", insertAfter: "after", replaceAll: "replaceWith" }, function (a, b) { n.fn[a] = function (a) { for (var c, d = [], e = n(a), g = e.length - 1, h = 0; g >= h; h++) c = h === g ? this : this.clone(!0), n(e[h])[b](c), f.apply(d, c.get()); return this.pushStack(d) } }); var qa, ra = {}; function sa(b, c) { var d, e = n(c.createElement(b)).appendTo(c.body), f = a.getDefaultComputedStyle && (d = a.getDefaultComputedStyle(e[0])) ? d.display : n.css(e[0], "display"); return e.detach(), f } function ta(a) { var b = l, c = ra[a]; return c || (c = sa(a, b), "none" !== c && c || (qa = (qa || n("<iframe frameborder='0' width='0' height='0'/>")).appendTo(b.documentElement), b = qa[0].contentDocument, b.write(), b.close(), c = sa(a, b), qa.detach()), ra[a] = c), c } var ua = /^margin/, va = new RegExp("^(" + Q + ")(?!px)[a-z%]+$", "i"), wa = function (b) { return b.ownerDocument.defaultView.opener ? b.ownerDocument.defaultView.getComputedStyle(b, null) : a.getComputedStyle(b, null) }; function xa(a, b, c) { var d, e, f, g, h = a.style; return c = c || wa(a), c && (g = c.getPropertyValue(b) || c[b]), c && ("" !== g || n.contains(a.ownerDocument, a) || (g = n.style(a, b)), va.test(g) && ua.test(b) && (d = h.width, e = h.minWidth, f = h.maxWidth, h.minWidth = h.maxWidth = h.width = g, g = c.width, h.width = d, h.minWidth = e, h.maxWidth = f)), void 0 !== g ? g + "" : g } function ya(a, b) { return { get: function () { return a() ? void delete this.get : (this.get = b).apply(this, arguments) } } } !function () { var b, c, d = l.documentElement, e = l.createElement("div"), f = l.createElement("div"); if (f.style) { f.style.backgroundClip = "content-box", f.cloneNode(!0).style.backgroundClip = "", k.clearCloneStyle = "content-box" === f.style.backgroundClip, e.style.cssText = "border:0;width:0;height:0;top:0;left:-9999px;margin-top:1px;position:absolute", e.appendChild(f); function g() { f.style.cssText = "-webkit-box-sizing:border-box;-moz-box-sizing:border-box;box-sizing:border-box;display:block;margin-top:1%;top:1%;border:1px;padding:1px;width:4px;position:absolute", f.innerHTML = "", d.appendChild(e); var g = a.getComputedStyle(f, null); b = "1%" !== g.top, c = "4px" === g.width, d.removeChild(e) } a.getComputedStyle && n.extend(k, { pixelPosition: function () { return g(), b }, boxSizingReliable: function () { return null == c && g(), c }, reliableMarginRight: function () { var b, c = f.appendChild(l.createElement("div")); return c.style.cssText = f.style.cssText = "-webkit-box-sizing:content-box;-moz-box-sizing:content-box;box-sizing:content-box;display:block;margin:0;border:0;padding:0", c.style.marginRight = c.style.width = "0", f.style.width = "1px", d.appendChild(e), b = !parseFloat(a.getComputedStyle(c, null).marginRight), d.removeChild(e), f.removeChild(c), b } }) } }(), n.swap = function (a, b, c, d) { var e, f, g = {}; for (f in b) g[f] = a.style[f], a.style[f] = b[f]; e = c.apply(a, d || []); for (f in b) a.style[f] = g[f]; return e }; var za = /^(none|table(?!-c[ea]).+)/, Aa = new RegExp("^(" + Q + ")(.*)$", "i"), Ba = new RegExp("^([+-])=(" + Q + ")", "i"), Ca = { position: "absolute", visibility: "hidden", display: "block" }, Da = { letterSpacing: "0", fontWeight: "400" }, Ea = ["Webkit", "O", "Moz", "ms"]; function Fa(a, b) { if (b in a) return b; var c = b[0].toUpperCase() + b.slice(1), d = b, e = Ea.length; while (e--) if (b = Ea[e] + c, b in a) return b; return d } function Ga(a, b, c) { var d = Aa.exec(b); return d ? Math.max(0, d[1] - (c || 0)) + (d[2] || "px") : b } function Ha(a, b, c, d, e) { for (var f = c === (d ? "border" : "content") ? 4 : "width" === b ? 1 : 0, g = 0; 4 > f; f += 2) "margin" === c && (g += n.css(a, c + R[f], !0, e)), d ? ("content" === c && (g -= n.css(a, "padding" + R[f], !0, e)), "margin" !== c && (g -= n.css(a, "border" + R[f] + "Width", !0, e))) : (g += n.css(a, "padding" + R[f], !0, e), "padding" !== c && (g += n.css(a, "border" + R[f] + "Width", !0, e))); return g } function Ia(a, b, c) { var d = !0, e = "width" === b ? a.offsetWidth : a.offsetHeight, f = wa(a), g = "border-box" === n.css(a, "boxSizing", !1, f); if (0 >= e || null == e) { if (e = xa(a, b, f), (0 > e || null == e) && (e = a.style[b]), va.test(e)) return e; d = g && (k.boxSizingReliable() || e === a.style[b]), e = parseFloat(e) || 0 } return e + Ha(a, b, c || (g ? "border" : "content"), d, f) + "px" } function Ja(a, b) { for (var c, d, e, f = [], g = 0, h = a.length; h > g; g++) d = a[g], d.style && (f[g] = L.get(d, "olddisplay"), c = d.style.display, b ? (f[g] || "none" !== c || (d.style.display = ""), "" === d.style.display && S(d) && (f[g] = L.access(d, "olddisplay", ta(d.nodeName)))) : (e = S(d), "none" === c && e || L.set(d, "olddisplay", e ? c : n.css(d, "display")))); for (g = 0; h > g; g++) d = a[g], d.style && (b && "none" !== d.style.display && "" !== d.style.display || (d.style.display = b ? f[g] || "" : "none")); return a } n.extend({ cssHooks: { opacity: { get: function (a, b) { if (b) { var c = xa(a, "opacity"); return "" === c ? "1" : c } } } }, cssNumber: { columnCount: !0, fillOpacity: !0, flexGrow: !0, flexShrink: !0, fontWeight: !0, lineHeight: !0, opacity: !0, order: !0, orphans: !0, widows: !0, zIndex: !0, zoom: !0 }, cssProps: { "float": "cssFloat" }, style: function (a, b, c, d) { if (a && 3 !== a.nodeType && 8 !== a.nodeType && a.style) { var e, f, g, h = n.camelCase(b), i = a.style; return b = n.cssProps[h] || (n.cssProps[h] = Fa(i, h)), g = n.cssHooks[b] || n.cssHooks[h], void 0 === c ? g && "get" in g && void 0 !== (e = g.get(a, !1, d)) ? e : i[b] : (f = typeof c, "string" === f && (e = Ba.exec(c)) && (c = (e[1] + 1) * e[2] + parseFloat(n.css(a, b)), f = "number"), null != c && c === c && ("number" !== f || n.cssNumber[h] || (c += "px"), k.clearCloneStyle || "" !== c || 0 !== b.indexOf("background") || (i[b] = "inherit"), g && "set" in g && void 0 === (c = g.set(a, c, d)) || (i[b] = c)), void 0) } }, css: function (a, b, c, d) { var e, f, g, h = n.camelCase(b); return b = n.cssProps[h] || (n.cssProps[h] = Fa(a.style, h)), g = n.cssHooks[b] || n.cssHooks[h], g && "get" in g && (e = g.get(a, !0, c)), void 0 === e && (e = xa(a, b, d)), "normal" === e && b in Da && (e = Da[b]), "" === c || c ? (f = parseFloat(e), c === !0 || n.isNumeric(f) ? f || 0 : e) : e } }), n.each(["height", "width"], function (a, b) { n.cssHooks[b] = { get: function (a, c, d) { return c ? za.test(n.css(a, "display")) && 0 === a.offsetWidth ? n.swap(a, Ca, function () { return Ia(a, b, d) }) : Ia(a, b, d) : void 0 }, set: function (a, c, d) { var e = d && wa(a); return Ga(a, c, d ? Ha(a, b, d, "border-box" === n.css(a, "boxSizing", !1, e), e) : 0) } } }), n.cssHooks.marginRight = ya(k.reliableMarginRight, function (a, b) { return b ? n.swap(a, { display: "inline-block" }, xa, [a, "marginRight"]) : void 0 }), n.each({ margin: "", padding: "", border: "Width" }, function (a, b) { n.cssHooks[a + b] = { expand: function (c) { for (var d = 0, e = {}, f = "string" == typeof c ? c.split(" ") : [c]; 4 > d; d++) e[a + R[d] + b] = f[d] || f[d - 2] || f[0]; return e } }, ua.test(a) || (n.cssHooks[a + b].set = Ga) }), n.fn.extend({ css: function (a, b) { return J(this, function (a, b, c) { var d, e, f = {}, g = 0; if (n.isArray(b)) { for (d = wa(a), e = b.length; e > g; g++) f[b[g]] = n.css(a, b[g], !1, d); return f } return void 0 !== c ? n.style(a, b, c) : n.css(a, b) }, a, b, arguments.length > 1) }, show: function () { return Ja(this, !0) }, hide: function () { return Ja(this) }, toggle: function (a) { return "boolean" == typeof a ? a ? this.show() : this.hide() : this.each(function () { S(this) ? n(this).show() : n(this).hide() }) } }); function Ka(a, b, c, d, e) { return new Ka.prototype.init(a, b, c, d, e) } n.Tween = Ka, Ka.prototype = { constructor: Ka, init: function (a, b, c, d, e, f) { this.elem = a, this.prop = c, this.easing = e || "swing", this.options = b, this.start = this.now = this.cur(), this.end = d, this.unit = f || (n.cssNumber[c] ? "" : "px") }, cur: function () { var a = Ka.propHooks[this.prop]; return a && a.get ? a.get(this) : Ka.propHooks._default.get(this) }, run: function (a) { var b, c = Ka.propHooks[this.prop]; return this.options.duration ? this.pos = b = n.easing[this.easing](a, this.options.duration * a, 0, 1, this.options.duration) : this.pos = b = a, this.now = (this.end - this.start) * b + this.start, this.options.step && this.options.step.call(this.elem, this.now, this), c && c.set ? c.set(this) : Ka.propHooks._default.set(this), this } }, Ka.prototype.init.prototype = Ka.prototype, Ka.propHooks = { _default: { get: function (a) { var b; return null == a.elem[a.prop] || a.elem.style && null != a.elem.style[a.prop] ? (b = n.css(a.elem, a.prop, ""), b && "auto" !== b ? b : 0) : a.elem[a.prop] }, set: function (a) { n.fx.step[a.prop] ? n.fx.step[a.prop](a) : a.elem.style && (null != a.elem.style[n.cssProps[a.prop]] || n.cssHooks[a.prop]) ? n.style(a.elem, a.prop, a.now + a.unit) : a.elem[a.prop] = a.now } } }, Ka.propHooks.scrollTop = Ka.propHooks.scrollLeft = { set: function (a) { a.elem.nodeType && a.elem.parentNode && (a.elem[a.prop] = a.now) } }, n.easing = { linear: function (a) { return a }, swing: function (a) { return .5 - Math.cos(a * Math.PI) / 2 } }, n.fx = Ka.prototype.init, n.fx.step = {}; var La, Ma, Na = /^(?:toggle|show|hide)$/, Oa = new RegExp("^(?:([+-])=|)(" + Q + ")([a-z%]*)$", "i"), Pa = /queueHooks$/, Qa = [Va], Ra = { "*": [function (a, b) { var c = this.createTween(a, b), d = c.cur(), e = Oa.exec(b), f = e && e[3] || (n.cssNumber[a] ? "" : "px"), g = (n.cssNumber[a] || "px" !== f && +d) && Oa.exec(n.css(c.elem, a)), h = 1, i = 20; if (g && g[3] !== f) { f = f || g[3], e = e || [], g = +d || 1; do h = h || ".5", g /= h, n.style(c.elem, a, g + f); while (h !== (h = c.cur() / d) && 1 !== h && --i) } return e && (g = c.start = +g || +d || 0, c.unit = f, c.end = e[1] ? g + (e[1] + 1) * e[2] : +e[2]), c }] }; function Sa() { return setTimeout(function () { La = void 0 }), La = n.now() } function Ta(a, b) { var c, d = 0, e = { height: a }; for (b = b ? 1 : 0; 4 > d; d += 2 - b) c = R[d], e["margin" + c] = e["padding" + c] = a; return b && (e.opacity = e.width = a), e } function Ua(a, b, c) { for (var d, e = (Ra[b] || []).concat(Ra["*"]), f = 0, g = e.length; g > f; f++) if (d = e[f].call(c, b, a)) return d } function Va(a, b, c) { var d, e, f, g, h, i, j, k, l = this, m = {}, o = a.style, p = a.nodeType && S(a), q = L.get(a, "fxshow"); c.queue || (h = n._queueHooks(a, "fx"), null == h.unqueued && (h.unqueued = 0, i = h.empty.fire, h.empty.fire = function () { h.unqueued || i() }), h.unqueued++, l.always(function () { l.always(function () { h.unqueued--, n.queue(a, "fx").length || h.empty.fire() }) })), 1 === a.nodeType && ("height" in b || "width" in b) && (c.overflow = [o.overflow, o.overflowX, o.overflowY], j = n.css(a, "display"), k = "none" === j ? L.get(a, "olddisplay") || ta(a.nodeName) : j, "inline" === k && "none" === n.css(a, "float") && (o.display = "inline-block")), c.overflow && (o.overflow = "hidden", l.always(function () { o.overflow = c.overflow[0], o.overflowX = c.overflow[1], o.overflowY = c.overflow[2] })); for (d in b) if (e = b[d], Na.exec(e)) { if (delete b[d], f = f || "toggle" === e, e === (p ? "hide" : "show")) { if ("show" !== e || !q || void 0 === q[d]) continue; p = !0 } m[d] = q && q[d] || n.style(a, d) } else j = void 0; if (n.isEmptyObject(m)) "inline" === ("none" === j ? ta(a.nodeName) : j) && (o.display = j); else { q ? "hidden" in q && (p = q.hidden) : q = L.access(a, "fxshow", {}), f && (q.hidden = !p), p ? n(a).show() : l.done(function () { n(a).hide() }), l.done(function () { var b; L.remove(a, "fxshow"); for (b in m) n.style(a, b, m[b]) }); for (d in m) g = Ua(p ? q[d] : 0, d, l), d in q || (q[d] = g.start, p && (g.end = g.start, g.start = "width" === d || "height" === d ? 1 : 0)) } } function Wa(a, b) { var c, d, e, f, g; for (c in a) if (d = n.camelCase(c), e = b[d], f = a[c], n.isArray(f) && (e = f[1], f = a[c] = f[0]), c !== d && (a[d] = f, delete a[c]), g = n.cssHooks[d], g && "expand" in g) { f = g.expand(f), delete a[d]; for (c in f) c in a || (a[c] = f[c], b[c] = e) } else b[d] = e } function Xa(a, b, c) { var d, e, f = 0, g = Qa.length, h = n.Deferred().always(function () { delete i.elem }), i = function () { if (e) return !1; for (var b = La || Sa(), c = Math.max(0, j.startTime + j.duration - b), d = c / j.duration || 0, f = 1 - d, g = 0, i = j.tweens.length; i > g; g++) j.tweens[g].run(f); return h.notifyWith(a, [j, f, c]), 1 > f && i ? c : (h.resolveWith(a, [j]), !1) }, j = h.promise({ elem: a, props: n.extend({}, b), opts: n.extend(!0, { specialEasing: {} }, c), originalProperties: b, originalOptions: c, startTime: La || Sa(), duration: c.duration, tweens: [], createTween: function (b, c) { var d = n.Tween(a, j.opts, b, c, j.opts.specialEasing[b] || j.opts.easing); return j.tweens.push(d), d }, stop: function (b) { var c = 0, d = b ? j.tweens.length : 0; if (e) return this; for (e = !0; d > c; c++) j.tweens[c].run(1); return b ? h.resolveWith(a, [j, b]) : h.rejectWith(a, [j, b]), this } }), k = j.props; for (Wa(k, j.opts.specialEasing) ; g > f; f++) if (d = Qa[f].call(j, a, k, j.opts)) return d; return n.map(k, Ua, j), n.isFunction(j.opts.start) && j.opts.start.call(a, j), n.fx.timer(n.extend(i, { elem: a, anim: j, queue: j.opts.queue })), j.progress(j.opts.progress).done(j.opts.done, j.opts.complete).fail(j.opts.fail).always(j.opts.always) } n.Animation = n.extend(Xa, { tweener: function (a, b) { n.isFunction(a) ? (b = a, a = ["*"]) : a = a.split(" "); for (var c, d = 0, e = a.length; e > d; d++) c = a[d], Ra[c] = Ra[c] || [], Ra[c].unshift(b) }, prefilter: function (a, b) { b ? Qa.unshift(a) : Qa.push(a) } }), n.speed = function (a, b, c) { var d = a && "object" == typeof a ? n.extend({}, a) : { complete: c || !c && b || n.isFunction(a) && a, duration: a, easing: c && b || b && !n.isFunction(b) && b }; return d.duration = n.fx.off ? 0 : "number" == typeof d.duration ? d.duration : d.duration in n.fx.speeds ? n.fx.speeds[d.duration] : n.fx.speeds._default, (null == d.queue || d.queue === !0) && (d.queue = "fx"), d.old = d.complete, d.complete = function () { n.isFunction(d.old) && d.old.call(this), d.queue && n.dequeue(this, d.queue) }, d }, n.fn.extend({ fadeTo: function (a, b, c, d) { return this.filter(S).css("opacity", 0).show().end().animate({ opacity: b }, a, c, d) }, animate: function (a, b, c, d) { var e = n.isEmptyObject(a), f = n.speed(b, c, d), g = function () { var b = Xa(this, n.extend({}, a), f); (e || L.get(this, "finish")) && b.stop(!0) }; return g.finish = g, e || f.queue === !1 ? this.each(g) : this.queue(f.queue, g) }, stop: function (a, b, c) { var d = function (a) { var b = a.stop; delete a.stop, b(c) }; return "string" != typeof a && (c = b, b = a, a = void 0), b && a !== !1 && this.queue(a || "fx", []), this.each(function () { var b = !0, e = null != a && a + "queueHooks", f = n.timers, g = L.get(this); if (e) g[e] && g[e].stop && d(g[e]); else for (e in g) g[e] && g[e].stop && Pa.test(e) && d(g[e]); for (e = f.length; e--;) f[e].elem !== this || null != a && f[e].queue !== a || (f[e].anim.stop(c), b = !1, f.splice(e, 1)); (b || !c) && n.dequeue(this, a) }) }, finish: function (a) { return a !== !1 && (a = a || "fx"), this.each(function () { var b, c = L.get(this), d = c[a + "queue"], e = c[a + "queueHooks"], f = n.timers, g = d ? d.length : 0; for (c.finish = !0, n.queue(this, a, []), e && e.stop && e.stop.call(this, !0), b = f.length; b--;) f[b].elem === this && f[b].queue === a && (f[b].anim.stop(!0), f.splice(b, 1)); for (b = 0; g > b; b++) d[b] && d[b].finish && d[b].finish.call(this); delete c.finish }) } }), n.each(["toggle", "show", "hide"], function (a, b) { var c = n.fn[b]; n.fn[b] = function (a, d, e) { return null == a || "boolean" == typeof a ? c.apply(this, arguments) : this.animate(Ta(b, !0), a, d, e) } }), n.each({ slideDown: Ta("show"), slideUp: Ta("hide"), slideToggle: Ta("toggle"), fadeIn: { opacity: "show" }, fadeOut: { opacity: "hide" }, fadeToggle: { opacity: "toggle" } }, function (a, b) { n.fn[a] = function (a, c, d) { return this.animate(b, a, c, d) } }), n.timers = [], n.fx.tick = function () { var a, b = 0, c = n.timers; for (La = n.now() ; b < c.length; b++) a = c[b], a() || c[b] !== a || c.splice(b--, 1); c.length || n.fx.stop(), La = void 0 }, n.fx.timer = function (a) { n.timers.push(a), a() ? n.fx.start() : n.timers.pop() }, n.fx.interval = 13, n.fx.start = function () { Ma || (Ma = setInterval(n.fx.tick, n.fx.interval)) }, n.fx.stop = function () { clearInterval(Ma), Ma = null }, n.fx.speeds = { slow: 600, fast: 200, _default: 400 }, n.fn.delay = function (a, b) { return a = n.fx ? n.fx.speeds[a] || a : a, b = b || "fx", this.queue(b, function (b, c) { var d = setTimeout(b, a); c.stop = function () { clearTimeout(d) } }) }, function () { var a = l.createElement("input"), b = l.createElement("select"), c = b.appendChild(l.createElement("option")); a.type = "checkbox", k.checkOn = "" !== a.value, k.optSelected = c.selected, b.disabled = !0, k.optDisabled = !c.disabled, a = l.createElement("input"), a.value = "t", a.type = "radio", k.radioValue = "t" === a.value }(); var Ya, Za, $a = n.expr.attrHandle; n.fn.extend({ attr: function (a, b) { return J(this, n.attr, a, b, arguments.length > 1) }, removeAttr: function (a) { return this.each(function () { n.removeAttr(this, a) }) } }), n.extend({
		attr: function (a, b, c) {
			var d, e, f = a.nodeType; if (a && 3 !== f && 8 !== f && 2 !== f) return typeof a.getAttribute === U ? n.prop(a, b, c) : (1 === f && n.isXMLDoc(a) || (b = b.toLowerCase(), d = n.attrHooks[b] || (n.expr.match.bool.test(b) ? Za : Ya)),
			void 0 === c ? d && "get" in d && null !== (e = d.get(a, b)) ? e : (e = n.find.attr(a, b), null == e ? void 0 : e) : null !== c ? d && "set" in d && void 0 !== (e = d.set(a, c, b)) ? e : (a.setAttribute(b, c + ""), c) : void n.removeAttr(a, b))
		}, removeAttr: function (a, b) { var c, d, e = 0, f = b && b.match(E); if (f && 1 === a.nodeType) while (c = f[e++]) d = n.propFix[c] || c, n.expr.match.bool.test(c) && (a[d] = !1), a.removeAttribute(c) }, attrHooks: { type: { set: function (a, b) { if (!k.radioValue && "radio" === b && n.nodeName(a, "input")) { var c = a.value; return a.setAttribute("type", b), c && (a.value = c), b } } } }
	}), Za = { set: function (a, b, c) { return b === !1 ? n.removeAttr(a, c) : a.setAttribute(c, c), c } }, n.each(n.expr.match.bool.source.match(/\w+/g), function (a, b) { var c = $a[b] || n.find.attr; $a[b] = function (a, b, d) { var e, f; return d || (f = $a[b], $a[b] = e, e = null != c(a, b, d) ? b.toLowerCase() : null, $a[b] = f), e } }); var _a = /^(?:input|select|textarea|button)$/i; n.fn.extend({ prop: function (a, b) { return J(this, n.prop, a, b, arguments.length > 1) }, removeProp: function (a) { return this.each(function () { delete this[n.propFix[a] || a] }) } }), n.extend({ propFix: { "for": "htmlFor", "class": "className" }, prop: function (a, b, c) { var d, e, f, g = a.nodeType; if (a && 3 !== g && 8 !== g && 2 !== g) return f = 1 !== g || !n.isXMLDoc(a), f && (b = n.propFix[b] || b, e = n.propHooks[b]), void 0 !== c ? e && "set" in e && void 0 !== (d = e.set(a, c, b)) ? d : a[b] = c : e && "get" in e && null !== (d = e.get(a, b)) ? d : a[b] }, propHooks: { tabIndex: { get: function (a) { return a.hasAttribute("tabindex") || _a.test(a.nodeName) || a.href ? a.tabIndex : -1 } } } }), k.optSelected || (n.propHooks.selected = { get: function (a) { var b = a.parentNode; return b && b.parentNode && b.parentNode.selectedIndex, null } }), n.each(["tabIndex", "readOnly", "maxLength", "cellSpacing", "cellPadding", "rowSpan", "colSpan", "useMap", "frameBorder", "contentEditable"], function () { n.propFix[this.toLowerCase()] = this }); var ab = /[\t\r\n\f]/g; n.fn.extend({ addClass: function (a) { var b, c, d, e, f, g, h = "string" == typeof a && a, i = 0, j = this.length; if (n.isFunction(a)) return this.each(function (b) { n(this).addClass(a.call(this, b, this.className)) }); if (h) for (b = (a || "").match(E) || []; j > i; i++) if (c = this[i], d = 1 === c.nodeType && (c.className ? (" " + c.className + " ").replace(ab, " ") : " ")) { f = 0; while (e = b[f++]) d.indexOf(" " + e + " ") < 0 && (d += e + " "); g = n.trim(d), c.className !== g && (c.className = g) } return this }, removeClass: function (a) { var b, c, d, e, f, g, h = 0 === arguments.length || "string" == typeof a && a, i = 0, j = this.length; if (n.isFunction(a)) return this.each(function (b) { n(this).removeClass(a.call(this, b, this.className)) }); if (h) for (b = (a || "").match(E) || []; j > i; i++) if (c = this[i], d = 1 === c.nodeType && (c.className ? (" " + c.className + " ").replace(ab, " ") : "")) { f = 0; while (e = b[f++]) while (d.indexOf(" " + e + " ") >= 0) d = d.replace(" " + e + " ", " "); g = a ? n.trim(d) : "", c.className !== g && (c.className = g) } return this }, toggleClass: function (a, b) { var c = typeof a; return "boolean" == typeof b && "string" === c ? b ? this.addClass(a) : this.removeClass(a) : this.each(n.isFunction(a) ? function (c) { n(this).toggleClass(a.call(this, c, this.className, b), b) } : function () { if ("string" === c) { var b, d = 0, e = n(this), f = a.match(E) || []; while (b = f[d++]) e.hasClass(b) ? e.removeClass(b) : e.addClass(b) } else (c === U || "boolean" === c) && (this.className && L.set(this, "__className__", this.className), this.className = this.className || a === !1 ? "" : L.get(this, "__className__") || "") }) }, hasClass: function (a) { for (var b = " " + a + " ", c = 0, d = this.length; d > c; c++) if (1 === this[c].nodeType && (" " + this[c].className + " ").replace(ab, " ").indexOf(b) >= 0) return !0; return !1 } }); var bb = /\r/g; n.fn.extend({ val: function (a) { var b, c, d, e = this[0]; { if (arguments.length) return d = n.isFunction(a), this.each(function (c) { var e; 1 === this.nodeType && (e = d ? a.call(this, c, n(this).val()) : a, null == e ? e = "" : "number" == typeof e ? e += "" : n.isArray(e) && (e = n.map(e, function (a) { return null == a ? "" : a + "" })), b = n.valHooks[this.type] || n.valHooks[this.nodeName.toLowerCase()], b && "set" in b && void 0 !== b.set(this, e, "value") || (this.value = e)) }); if (e) return b = n.valHooks[e.type] || n.valHooks[e.nodeName.toLowerCase()], b && "get" in b && void 0 !== (c = b.get(e, "value")) ? c : (c = e.value, "string" == typeof c ? c.replace(bb, "") : null == c ? "" : c) } } }), n.extend({ valHooks: { option: { get: function (a) { var b = n.find.attr(a, "value"); return null != b ? b : n.trim(n.text(a)) } }, select: { get: function (a) { for (var b, c, d = a.options, e = a.selectedIndex, f = "select-one" === a.type || 0 > e, g = f ? null : [], h = f ? e + 1 : d.length, i = 0 > e ? h : f ? e : 0; h > i; i++) if (c = d[i], !(!c.selected && i !== e || (k.optDisabled ? c.disabled : null !== c.getAttribute("disabled")) || c.parentNode.disabled && n.nodeName(c.parentNode, "optgroup"))) { if (b = n(c).val(), f) return b; g.push(b) } return g }, set: function (a, b) { var c, d, e = a.options, f = n.makeArray(b), g = e.length; while (g--) d = e[g], (d.selected = n.inArray(d.value, f) >= 0) && (c = !0); return c || (a.selectedIndex = -1), f } } } }), n.each(["radio", "checkbox"], function () { n.valHooks[this] = { set: function (a, b) { return n.isArray(b) ? a.checked = n.inArray(n(a).val(), b) >= 0 : void 0 } }, k.checkOn || (n.valHooks[this].get = function (a) { return null === a.getAttribute("value") ? "on" : a.value }) }), n.each("blur focus focusin focusout load resize scroll unload click dblclick mousedown mouseup mousemove mouseover mouseout mouseenter mouseleave change select submit keydown keypress keyup error contextmenu".split(" "), function (a, b) { n.fn[b] = function (a, c) { return arguments.length > 0 ? this.on(b, null, a, c) : this.trigger(b) } }), n.fn.extend({ hover: function (a, b) { return this.mouseenter(a).mouseleave(b || a) }, bind: function (a, b, c) { return this.on(a, null, b, c) }, unbind: function (a, b) { return this.off(a, null, b) }, delegate: function (a, b, c, d) { return this.on(b, a, c, d) }, undelegate: function (a, b, c) { return 1 === arguments.length ? this.off(a, "**") : this.off(b, a || "**", c) } }); var cb = n.now(), db = /\?/; n.parseJSON = function (a) { return JSON.parse(a + "") }, n.parseXML = function (a) { var b, c; if (!a || "string" != typeof a) return null; try { c = new DOMParser, b = c.parseFromString(a, "text/xml") } catch (d) { b = void 0 } return (!b || b.getElementsByTagName("parsererror").length) && n.error("Invalid XML: " + a), b }; var eb = /#.*$/, fb = /([?&])_=[^&]*/, gb = /^(.*?):[ \t]*([^\r\n]*)$/gm, hb = /^(?:about|app|app-storage|.+-extension|file|res|widget):$/, ib = /^(?:GET|HEAD)$/, jb = /^\/\//, kb = /^([\w.+-]+:)(?:\/\/(?:[^\/?#]*@|)([^\/?#:]*)(?::(\d+)|)|)/, lb = {}, mb = {}, nb = "*/".concat("*"), ob = a.location.href, pb = kb.exec(ob.toLowerCase()) || []; function qb(a) { return function (b, c) { "string" != typeof b && (c = b, b = "*"); var d, e = 0, f = b.toLowerCase().match(E) || []; if (n.isFunction(c)) while (d = f[e++]) "+" === d[0] ? (d = d.slice(1) || "*", (a[d] = a[d] || []).unshift(c)) : (a[d] = a[d] || []).push(c) } } function rb(a, b, c, d) { var e = {}, f = a === mb; function g(h) { var i; return e[h] = !0, n.each(a[h] || [], function (a, h) { var j = h(b, c, d); return "string" != typeof j || f || e[j] ? f ? !(i = j) : void 0 : (b.dataTypes.unshift(j), g(j), !1) }), i } return g(b.dataTypes[0]) || !e["*"] && g("*") } function sb(a, b) { var c, d, e = n.ajaxSettings.flatOptions || {}; for (c in b) void 0 !== b[c] && ((e[c] ? a : d || (d = {}))[c] = b[c]); return d && n.extend(!0, a, d), a } function tb(a, b, c) { var d, e, f, g, h = a.contents, i = a.dataTypes; while ("*" === i[0]) i.shift(), void 0 === d && (d = a.mimeType || b.getResponseHeader("Content-Type")); if (d) for (e in h) if (h[e] && h[e].test(d)) { i.unshift(e); break } if (i[0] in c) f = i[0]; else { for (e in c) { if (!i[0] || a.converters[e + " " + i[0]]) { f = e; break } g || (g = e) } f = f || g } return f ? (f !== i[0] && i.unshift(f), c[f]) : void 0 } function ub(a, b, c, d) { var e, f, g, h, i, j = {}, k = a.dataTypes.slice(); if (k[1]) for (g in a.converters) j[g.toLowerCase()] = a.converters[g]; f = k.shift(); while (f) if (a.responseFields[f] && (c[a.responseFields[f]] = b), !i && d && a.dataFilter && (b = a.dataFilter(b, a.dataType)), i = f, f = k.shift()) if ("*" === f) f = i; else if ("*" !== i && i !== f) { if (g = j[i + " " + f] || j["* " + f], !g) for (e in j) if (h = e.split(" "), h[1] === f && (g = j[i + " " + h[0]] || j["* " + h[0]])) { g === !0 ? g = j[e] : j[e] !== !0 && (f = h[0], k.unshift(h[1])); break } if (g !== !0) if (g && a["throws"]) b = g(b); else try { b = g(b) } catch (l) { return { state: "parsererror", error: g ? l : "No conversion from " + i + " to " + f } } } return { state: "success", data: b } } n.extend({ active: 0, lastModified: {}, etag: {}, ajaxSettings: { url: ob, type: "GET", isLocal: hb.test(pb[1]), global: !0, processData: !0, async: !0, contentType: "application/x-www-form-urlencoded; charset=UTF-8", accepts: { "*": nb, text: "text/plain", html: "text/html", xml: "application/xml, text/xml", json: "application/json, text/javascript" }, contents: { xml: /xml/, html: /html/, json: /json/ }, responseFields: { xml: "responseXML", text: "responseText", json: "responseJSON" }, converters: { "* text": String, "text html": !0, "text json": n.parseJSON, "text xml": n.parseXML }, flatOptions: { url: !0, context: !0 } }, ajaxSetup: function (a, b) { return b ? sb(sb(a, n.ajaxSettings), b) : sb(n.ajaxSettings, a) }, ajaxPrefilter: qb(lb), ajaxTransport: qb(mb), ajax: function (a, b) { "object" == typeof a && (b = a, a = void 0), b = b || {}; var c, d, e, f, g, h, i, j, k = n.ajaxSetup({}, b), l = k.context || k, m = k.context && (l.nodeType || l.jquery) ? n(l) : n.event, o = n.Deferred(), p = n.Callbacks("once memory"), q = k.statusCode || {}, r = {}, s = {}, t = 0, u = "canceled", v = { readyState: 0, getResponseHeader: function (a) { var b; if (2 === t) { if (!f) { f = {}; while (b = gb.exec(e)) f[b[1].toLowerCase()] = b[2] } b = f[a.toLowerCase()] } return null == b ? null : b }, getAllResponseHeaders: function () { return 2 === t ? e : null }, setRequestHeader: function (a, b) { var c = a.toLowerCase(); return t || (a = s[c] = s[c] || a, r[a] = b), this }, overrideMimeType: function (a) { return t || (k.mimeType = a), this }, statusCode: function (a) { var b; if (a) if (2 > t) for (b in a) q[b] = [q[b], a[b]]; else v.always(a[v.status]); return this }, abort: function (a) { var b = a || u; return c && c.abort(b), x(0, b), this } }; if (o.promise(v).complete = p.add, v.success = v.done, v.error = v.fail, k.url = ((a || k.url || ob) + "").replace(eb, "").replace(jb, pb[1] + "//"), k.type = b.method || b.type || k.method || k.type, k.dataTypes = n.trim(k.dataType || "*").toLowerCase().match(E) || [""], null == k.crossDomain && (h = kb.exec(k.url.toLowerCase()), k.crossDomain = !(!h || h[1] === pb[1] && h[2] === pb[2] && (h[3] || ("http:" === h[1] ? "80" : "443")) === (pb[3] || ("http:" === pb[1] ? "80" : "443")))), k.data && k.processData && "string" != typeof k.data && (k.data = n.param(k.data, k.traditional)), rb(lb, k, b, v), 2 === t) return v; i = n.event && k.global, i && 0 === n.active++ && n.event.trigger("ajaxStart"), k.type = k.type.toUpperCase(), k.hasContent = !ib.test(k.type), d = k.url, k.hasContent || (k.data && (d = k.url += (db.test(d) ? "&" : "?") + k.data, delete k.data), k.cache === !1 && (k.url = fb.test(d) ? d.replace(fb, "$1_=" + cb++) : d + (db.test(d) ? "&" : "?") + "_=" + cb++)), k.ifModified && (n.lastModified[d] && v.setRequestHeader("If-Modified-Since", n.lastModified[d]), n.etag[d] && v.setRequestHeader("If-None-Match", n.etag[d])), (k.data && k.hasContent && k.contentType !== !1 || b.contentType) && v.setRequestHeader("Content-Type", k.contentType), v.setRequestHeader("Accept", k.dataTypes[0] && k.accepts[k.dataTypes[0]] ? k.accepts[k.dataTypes[0]] + ("*" !== k.dataTypes[0] ? ", " + nb + "; q=0.01" : "") : k.accepts["*"]); for (j in k.headers) v.setRequestHeader(j, k.headers[j]); if (k.beforeSend && (k.beforeSend.call(l, v, k) === !1 || 2 === t)) return v.abort(); u = "abort"; for (j in { success: 1, error: 1, complete: 1 }) v[j](k[j]); if (c = rb(mb, k, b, v)) { v.readyState = 1, i && m.trigger("ajaxSend", [v, k]), k.async && k.timeout > 0 && (g = setTimeout(function () { v.abort("timeout") }, k.timeout)); try { t = 1, c.send(r, x) } catch (w) { if (!(2 > t)) throw w; x(-1, w) } } else x(-1, "No Transport"); function x(a, b, f, h) { var j, r, s, u, w, x = b; 2 !== t && (t = 2, g && clearTimeout(g), c = void 0, e = h || "", v.readyState = a > 0 ? 4 : 0, j = a >= 200 && 300 > a || 304 === a, f && (u = tb(k, v, f)), u = ub(k, u, v, j), j ? (k.ifModified && (w = v.getResponseHeader("Last-Modified"), w && (n.lastModified[d] = w), w = v.getResponseHeader("etag"), w && (n.etag[d] = w)), 204 === a || "HEAD" === k.type ? x = "nocontent" : 304 === a ? x = "notmodified" : (x = u.state, r = u.data, s = u.error, j = !s)) : (s = x, (a || !x) && (x = "error", 0 > a && (a = 0))), v.status = a, v.statusText = (b || x) + "", j ? o.resolveWith(l, [r, x, v]) : o.rejectWith(l, [v, x, s]), v.statusCode(q), q = void 0, i && m.trigger(j ? "ajaxSuccess" : "ajaxError", [v, k, j ? r : s]), p.fireWith(l, [v, x]), i && (m.trigger("ajaxComplete", [v, k]), --n.active || n.event.trigger("ajaxStop"))) } return v }, getJSON: function (a, b, c) { return n.get(a, b, c, "json") }, getScript: function (a, b) { return n.get(a, void 0, b, "script") } }), n.each(["get", "post"], function (a, b) { n[b] = function (a, c, d, e) { return n.isFunction(c) && (e = e || d, d = c, c = void 0), n.ajax({ url: a, type: b, dataType: e, data: c, success: d }) } }), n._evalUrl = function (a) { return n.ajax({ url: a, type: "GET", dataType: "script", async: !1, global: !1, "throws": !0 }) }, n.fn.extend({ wrapAll: function (a) { var b; return n.isFunction(a) ? this.each(function (b) { n(this).wrapAll(a.call(this, b)) }) : (this[0] && (b = n(a, this[0].ownerDocument).eq(0).clone(!0), this[0].parentNode && b.insertBefore(this[0]), b.map(function () { var a = this; while (a.firstElementChild) a = a.firstElementChild; return a }).append(this)), this) }, wrapInner: function (a) { return this.each(n.isFunction(a) ? function (b) { n(this).wrapInner(a.call(this, b)) } : function () { var b = n(this), c = b.contents(); c.length ? c.wrapAll(a) : b.append(a) }) }, wrap: function (a) { var b = n.isFunction(a); return this.each(function (c) { n(this).wrapAll(b ? a.call(this, c) : a) }) }, unwrap: function () { return this.parent().each(function () { n.nodeName(this, "body") || n(this).replaceWith(this.childNodes) }).end() } }), n.expr.filters.hidden = function (a) { return a.offsetWidth <= 0 && a.offsetHeight <= 0 }, n.expr.filters.visible = function (a) { return !n.expr.filters.hidden(a) }; var vb = /%20/g, wb = /\[\]$/, xb = /\r?\n/g, yb = /^(?:submit|button|image|reset|file)$/i, zb = /^(?:input|select|textarea|keygen)/i; function Ab(a, b, c, d) { var e; if (n.isArray(b)) n.each(b, function (b, e) { c || wb.test(a) ? d(a, e) : Ab(a + "[" + ("object" == typeof e ? b : "") + "]", e, c, d) }); else if (c || "object" !== n.type(b)) d(a, b); else for (e in b) Ab(a + "[" + e + "]", b[e], c, d) } n.param = function (a, b) { var c, d = [], e = function (a, b) { b = n.isFunction(b) ? b() : null == b ? "" : b, d[d.length] = encodeURIComponent(a) + "=" + encodeURIComponent(b) }; if (void 0 === b && (b = n.ajaxSettings && n.ajaxSettings.traditional), n.isArray(a) || a.jquery && !n.isPlainObject(a)) n.each(a, function () { e(this.name, this.value) }); else for (c in a) Ab(c, a[c], b, e); return d.join("&").replace(vb, "+") }, n.fn.extend({ serialize: function () { return n.param(this.serializeArray()) }, serializeArray: function () { return this.map(function () { var a = n.prop(this, "elements"); return a ? n.makeArray(a) : this }).filter(function () { var a = this.type; return this.name && !n(this).is(":disabled") && zb.test(this.nodeName) && !yb.test(a) && (this.checked || !T.test(a)) }).map(function (a, b) { var c = n(this).val(); return null == c ? null : n.isArray(c) ? n.map(c, function (a) { return { name: b.name, value: a.replace(xb, "\r\n") } }) : { name: b.name, value: c.replace(xb, "\r\n") } }).get() } }), n.ajaxSettings.xhr = function () { try { return new XMLHttpRequest } catch (a) { } }; var Bb = 0, Cb = {}, Db = { 0: 200, 1223: 204 }, Eb = n.ajaxSettings.xhr(); a.attachEvent && a.attachEvent("onunload", function () { for (var a in Cb) Cb[a]() }), k.cors = !!Eb && "withCredentials" in Eb, k.ajax = Eb = !!Eb, n.ajaxTransport(function (a) { var b; return k.cors || Eb && !a.crossDomain ? { send: function (c, d) { var e, f = a.xhr(), g = ++Bb; if (f.open(a.type, a.url, a.async, a.username, a.password), a.xhrFields) for (e in a.xhrFields) f[e] = a.xhrFields[e]; a.mimeType && f.overrideMimeType && f.overrideMimeType(a.mimeType), a.crossDomain || c["X-Requested-With"] || (c["X-Requested-With"] = "XMLHttpRequest"); for (e in c) f.setRequestHeader(e, c[e]); b = function (a) { return function () { b && (delete Cb[g], b = f.onload = f.onerror = null, "abort" === a ? f.abort() : "error" === a ? d(f.status, f.statusText) : d(Db[f.status] || f.status, f.statusText, "string" == typeof f.responseText ? { text: f.responseText } : void 0, f.getAllResponseHeaders())) } }, f.onload = b(), f.onerror = b("error"), b = Cb[g] = b("abort"); try { f.send(a.hasContent && a.data || null) } catch (h) { if (b) throw h } }, abort: function () { b && b() } } : void 0 }), n.ajaxSetup({ accepts: { script: "text/javascript, application/javascript, application/ecmascript, application/x-ecmascript" }, contents: { script: /(?:java|ecma)script/ }, converters: { "text script": function (a) { return n.globalEval(a), a } } }), n.ajaxPrefilter("script", function (a) { void 0 === a.cache && (a.cache = !1), a.crossDomain && (a.type = "GET") }), n.ajaxTransport("script", function (a) { if (a.crossDomain) { var b, c; return { send: function (d, e) { b = n("<script>").prop({ async: !0, charset: a.scriptCharset, src: a.url }).on("load error", c = function (a) { b.remove(), c = null, a && e("error" === a.type ? 404 : 200, a.type) }), l.head.appendChild(b[0]) }, abort: function () { c && c() } } } }); var Fb = [], Gb = /(=)\?(?=&|$)|\?\?/; n.ajaxSetup({ jsonp: "callback", jsonpCallback: function () { var a = Fb.pop() || n.expando + "_" + cb++; return this[a] = !0, a } }), n.ajaxPrefilter("json jsonp", function (b, c, d) { var e, f, g, h = b.jsonp !== !1 && (Gb.test(b.url) ? "url" : "string" == typeof b.data && !(b.contentType || "").indexOf("application/x-www-form-urlencoded") && Gb.test(b.data) && "data"); return h || "jsonp" === b.dataTypes[0] ? (e = b.jsonpCallback = n.isFunction(b.jsonpCallback) ? b.jsonpCallback() : b.jsonpCallback, h ? b[h] = b[h].replace(Gb, "$1" + e) : b.jsonp !== !1 && (b.url += (db.test(b.url) ? "&" : "?") + b.jsonp + "=" + e), b.converters["script json"] = function () { return g || n.error(e + " was not called"), g[0] }, b.dataTypes[0] = "json", f = a[e], a[e] = function () { g = arguments }, d.always(function () { a[e] = f, b[e] && (b.jsonpCallback = c.jsonpCallback, Fb.push(e)), g && n.isFunction(f) && f(g[0]), g = f = void 0 }), "script") : void 0 }), n.parseHTML = function (a, b, c) { if (!a || "string" != typeof a) return null; "boolean" == typeof b && (c = b, b = !1), b = b || l; var d = v.exec(a), e = !c && []; return d ? [b.createElement(d[1])] : (d = n.buildFragment([a], b, e), e && e.length && n(e).remove(), n.merge([], d.childNodes)) }; var Hb = n.fn.load; n.fn.load = function (a, b, c) { if ("string" != typeof a && Hb) return Hb.apply(this, arguments); var d, e, f, g = this, h = a.indexOf(" "); return h >= 0 && (d = n.trim(a.slice(h)), a = a.slice(0, h)), n.isFunction(b) ? (c = b, b = void 0) : b && "object" == typeof b && (e = "POST"), g.length > 0 && n.ajax({ url: a, type: e, dataType: "html", data: b }).done(function (a) { f = arguments, g.html(d ? n("<div>").append(n.parseHTML(a)).find(d) : a) }).complete(c && function (a, b) { g.each(c, f || [a.responseText, b, a]) }), this }, n.each(["ajaxStart", "ajaxStop", "ajaxComplete", "ajaxError", "ajaxSuccess", "ajaxSend"], function (a, b) { n.fn[b] = function (a) { return this.on(b, a) } }), n.expr.filters.animated = function (a) { return n.grep(n.timers, function (b) { return a === b.elem }).length }; var Ib = a.document.documentElement; function Jb(a) { return n.isWindow(a) ? a : 9 === a.nodeType && a.defaultView } n.offset = { setOffset: function (a, b, c) { var d, e, f, g, h, i, j, k = n.css(a, "position"), l = n(a), m = {}; "static" === k && (a.style.position = "relative"), h = l.offset(), f = n.css(a, "top"), i = n.css(a, "left"), j = ("absolute" === k || "fixed" === k) && (f + i).indexOf("auto") > -1, j ? (d = l.position(), g = d.top, e = d.left) : (g = parseFloat(f) || 0, e = parseFloat(i) || 0), n.isFunction(b) && (b = b.call(a, c, h)), null != b.top && (m.top = b.top - h.top + g), null != b.left && (m.left = b.left - h.left + e), "using" in b ? b.using.call(a, m) : l.css(m) } }, n.fn.extend({ offset: function (a) { if (arguments.length) return void 0 === a ? this : this.each(function (b) { n.offset.setOffset(this, a, b) }); var b, c, d = this[0], e = { top: 0, left: 0 }, f = d && d.ownerDocument; if (f) return b = f.documentElement, n.contains(b, d) ? (typeof d.getBoundingClientRect !== U && (e = d.getBoundingClientRect()), c = Jb(f), { top: e.top + c.pageYOffset - b.clientTop, left: e.left + c.pageXOffset - b.clientLeft }) : e }, position: function () { if (this[0]) { var a, b, c = this[0], d = { top: 0, left: 0 }; return "fixed" === n.css(c, "position") ? b = c.getBoundingClientRect() : (a = this.offsetParent(), b = this.offset(), n.nodeName(a[0], "html") || (d = a.offset()), d.top += n.css(a[0], "borderTopWidth", !0), d.left += n.css(a[0], "borderLeftWidth", !0)), { top: b.top - d.top - n.css(c, "marginTop", !0), left: b.left - d.left - n.css(c, "marginLeft", !0) } } }, offsetParent: function () { return this.map(function () { var a = this.offsetParent || Ib; while (a && !n.nodeName(a, "html") && "static" === n.css(a, "position")) a = a.offsetParent; return a || Ib }) } }), n.each({ scrollLeft: "pageXOffset", scrollTop: "pageYOffset" }, function (b, c) { var d = "pageYOffset" === c; n.fn[b] = function (e) { return J(this, function (b, e, f) { var g = Jb(b); return void 0 === f ? g ? g[c] : b[e] : void (g ? g.scrollTo(d ? a.pageXOffset : f, d ? f : a.pageYOffset) : b[e] = f) }, b, e, arguments.length, null) } }), n.each(["top", "left"], function (a, b) { n.cssHooks[b] = ya(k.pixelPosition, function (a, c) { return c ? (c = xa(a, b), va.test(c) ? n(a).position()[b] + "px" : c) : void 0 }) }), n.each({ Height: "height", Width: "width" }, function (a, b) { n.each({ padding: "inner" + a, content: b, "": "outer" + a }, function (c, d) { n.fn[d] = function (d, e) { var f = arguments.length && (c || "boolean" != typeof d), g = c || (d === !0 || e === !0 ? "margin" : "border"); return J(this, function (b, c, d) { var e; return n.isWindow(b) ? b.document.documentElement["client" + a] : 9 === b.nodeType ? (e = b.documentElement, Math.max(b.body["scroll" + a], e["scroll" + a], b.body["offset" + a], e["offset" + a], e["client" + a])) : void 0 === d ? n.css(b, c, g) : n.style(b, c, d, g) }, b, f ? d : void 0, f, null) } }) }), n.fn.size = function () { return this.length }, n.fn.andSelf = n.fn.addBack, "function" == typeof define && define.amd && define("jquery", [], function () { return n }); var Kb = a.jQuery, Lb = a.$; return n.noConflict = function (b) { return a.$ === n && (a.$ = Lb), b && a.jQuery === n && (a.jQuery = Kb), n }, typeof b === U && (a.jQuery = a.$ = n), n
});


/*! jQuery UI - v1.11.4 - 2015-03-11
* http://jqueryui.com
* Includes: core.js, widget.js, mouse.js, position.js, accordion.js, autocomplete.js, button.js, datepicker.js, dialog.js, draggable.js, droppable.js, effect.js, effect-blind.js, effect-bounce.js, effect-clip.js, effect-drop.js, effect-explode.js, effect-fade.js, effect-fold.js, effect-highlight.js, effect-puff.js, effect-pulsate.js, effect-scale.js, effect-shake.js, effect-size.js, effect-slide.js, effect-transfer.js, menu.js, progressbar.js, resizable.js, selectable.js, selectmenu.js, slider.js, sortable.js, spinner.js, tabs.js, tooltip.js
* Copyright 2015 jQuery Foundation and other contributors; Licensed MIT */

(function(e){"function"==typeof define&&define.amd?define(["jquery"],e):e(jQuery)})(function(e){function t(t,s){var n,a,o,r=t.nodeName.toLowerCase();return"area"===r?(n=t.parentNode,a=n.name,t.href&&a&&"map"===n.nodeName.toLowerCase()?(o=e("img[usemap='#"+a+"']")[0],!!o&&i(o)):!1):(/^(input|select|textarea|button|object)$/.test(r)?!t.disabled:"a"===r?t.href||s:s)&&i(t)}function i(t){return e.expr.filters.visible(t)&&!e(t).parents().addBack().filter(function(){return"hidden"===e.css(this,"visibility")}).length}function s(e){for(var t,i;e.length&&e[0]!==document;){if(t=e.css("position"),("absolute"===t||"relative"===t||"fixed"===t)&&(i=parseInt(e.css("zIndex"),10),!isNaN(i)&&0!==i))return i;e=e.parent()}return 0}function n(){this._curInst=null,this._keyEvent=!1,this._disabledInputs=[],this._datepickerShowing=!1,this._inDialog=!1,this._mainDivId="ui-datepicker-div",this._inlineClass="ui-datepicker-inline",this._appendClass="ui-datepicker-append",this._triggerClass="ui-datepicker-trigger",this._dialogClass="ui-datepicker-dialog",this._disableClass="ui-datepicker-disabled",this._unselectableClass="ui-datepicker-unselectable",this._currentClass="ui-datepicker-current-day",this._dayOverClass="ui-datepicker-days-cell-over",this.regional=[],this.regional[""]={closeText:"Done",prevText:"Prev",nextText:"Next",currentText:"Today",monthNames:["January","February","March","April","May","June","July","August","September","October","November","December"],monthNamesShort:["Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"],dayNames:["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"],dayNamesShort:["Sun","Mon","Tue","Wed","Thu","Fri","Sat"],dayNamesMin:["Su","Mo","Tu","We","Th","Fr","Sa"],weekHeader:"Wk",dateFormat:"mm/dd/yy",firstDay:0,isRTL:!1,showMonthAfterYear:!1,yearSuffix:""},this._defaults={showOn:"focus",showAnim:"fadeIn",showOptions:{},defaultDate:null,appendText:"",buttonText:"...",buttonImage:"",buttonImageOnly:!1,hideIfNoPrevNext:!1,navigationAsDateFormat:!1,gotoCurrent:!1,changeMonth:!1,changeYear:!1,yearRange:"c-10:c+10",showOtherMonths:!1,selectOtherMonths:!1,showWeek:!1,calculateWeek:this.iso8601Week,shortYearCutoff:"+10",minDate:null,maxDate:null,duration:"fast",beforeShowDay:null,beforeShow:null,onSelect:null,onChangeMonthYear:null,onClose:null,numberOfMonths:1,showCurrentAtPos:0,stepMonths:1,stepBigMonths:12,altField:"",altFormat:"",constrainInput:!0,showButtonPanel:!1,autoSize:!1,disabled:!1},e.extend(this._defaults,this.regional[""]),this.regional.en=e.extend(!0,{},this.regional[""]),this.regional["en-US"]=e.extend(!0,{},this.regional.en),this.dpDiv=a(e("<div id='"+this._mainDivId+"' class='ui-datepicker ui-widget ui-widget-content ui-helper-clearfix ui-corner-all'></div>"))}function a(t){var i="button, .ui-datepicker-prev, .ui-datepicker-next, .ui-datepicker-calendar td a";return t.delegate(i,"mouseout",function(){e(this).removeClass("ui-state-hover"),-1!==this.className.indexOf("ui-datepicker-prev")&&e(this).removeClass("ui-datepicker-prev-hover"),-1!==this.className.indexOf("ui-datepicker-next")&&e(this).removeClass("ui-datepicker-next-hover")}).delegate(i,"mouseover",o)}function o(){e.datepicker._isDisabledDatepicker(v.inline?v.dpDiv.parent()[0]:v.input[0])||(e(this).parents(".ui-datepicker-calendar").find("a").removeClass("ui-state-hover"),e(this).addClass("ui-state-hover"),-1!==this.className.indexOf("ui-datepicker-prev")&&e(this).addClass("ui-datepicker-prev-hover"),-1!==this.className.indexOf("ui-datepicker-next")&&e(this).addClass("ui-datepicker-next-hover"))}function r(t,i){e.extend(t,i);for(var s in i)null==i[s]&&(t[s]=i[s]);return t}function h(e){return function(){var t=this.element.val();e.apply(this,arguments),this._refresh(),t!==this.element.val()&&this._trigger("change")}}e.ui=e.ui||{},e.extend(e.ui,{version:"1.11.4",keyCode:{BACKSPACE:8,COMMA:188,DELETE:46,DOWN:40,END:35,ENTER:13,ESCAPE:27,HOME:36,LEFT:37,PAGE_DOWN:34,PAGE_UP:33,PERIOD:190,RIGHT:39,SPACE:32,TAB:9,UP:38}}),e.fn.extend({scrollParent:function(t){var i=this.css("position"),s="absolute"===i,n=t?/(auto|scroll|hidden)/:/(auto|scroll)/,a=this.parents().filter(function(){var t=e(this);return s&&"static"===t.css("position")?!1:n.test(t.css("overflow")+t.css("overflow-y")+t.css("overflow-x"))}).eq(0);return"fixed"!==i&&a.length?a:e(this[0].ownerDocument||document)},uniqueId:function(){var e=0;return function(){return this.each(function(){this.id||(this.id="ui-id-"+ ++e)})}}(),removeUniqueId:function(){return this.each(function(){/^ui-id-\d+$/.test(this.id)&&e(this).removeAttr("id")})}}),e.extend(e.expr[":"],{data:e.expr.createPseudo?e.expr.createPseudo(function(t){return function(i){return!!e.data(i,t)}}):function(t,i,s){return!!e.data(t,s[3])},focusable:function(i){return t(i,!isNaN(e.attr(i,"tabindex")))},tabbable:function(i){var s=e.attr(i,"tabindex"),n=isNaN(s);return(n||s>=0)&&t(i,!n)}}),e("<a>").outerWidth(1).jquery||e.each(["Width","Height"],function(t,i){function s(t,i,s,a){return e.each(n,function(){i-=parseFloat(e.css(t,"padding"+this))||0,s&&(i-=parseFloat(e.css(t,"border"+this+"Width"))||0),a&&(i-=parseFloat(e.css(t,"margin"+this))||0)}),i}var n="Width"===i?["Left","Right"]:["Top","Bottom"],a=i.toLowerCase(),o={innerWidth:e.fn.innerWidth,innerHeight:e.fn.innerHeight,outerWidth:e.fn.outerWidth,outerHeight:e.fn.outerHeight};e.fn["inner"+i]=function(t){return void 0===t?o["inner"+i].call(this):this.each(function(){e(this).css(a,s(this,t)+"px")})},e.fn["outer"+i]=function(t,n){return"number"!=typeof t?o["outer"+i].call(this,t):this.each(function(){e(this).css(a,s(this,t,!0,n)+"px")})}}),e.fn.addBack||(e.fn.addBack=function(e){return this.add(null==e?this.prevObject:this.prevObject.filter(e))}),e("<a>").data("a-b","a").removeData("a-b").data("a-b")&&(e.fn.removeData=function(t){return function(i){return arguments.length?t.call(this,e.camelCase(i)):t.call(this)}}(e.fn.removeData)),e.ui.ie=!!/msie [\w.]+/.exec(navigator.userAgent.toLowerCase()),e.fn.extend({focus:function(t){return function(i,s){return"number"==typeof i?this.each(function(){var t=this;setTimeout(function(){e(t).focus(),s&&s.call(t)},i)}):t.apply(this,arguments)}}(e.fn.focus),disableSelection:function(){var e="onselectstart"in document.createElement("div")?"selectstart":"mousedown";return function(){return this.bind(e+".ui-disableSelection",function(e){e.preventDefault()})}}(),enableSelection:function(){return this.unbind(".ui-disableSelection")},zIndex:function(t){if(void 0!==t)return this.css("zIndex",t);if(this.length)for(var i,s,n=e(this[0]);n.length&&n[0]!==document;){if(i=n.css("position"),("absolute"===i||"relative"===i||"fixed"===i)&&(s=parseInt(n.css("zIndex"),10),!isNaN(s)&&0!==s))return s;n=n.parent()}return 0}}),e.ui.plugin={add:function(t,i,s){var n,a=e.ui[t].prototype;for(n in s)a.plugins[n]=a.plugins[n]||[],a.plugins[n].push([i,s[n]])},call:function(e,t,i,s){var n,a=e.plugins[t];if(a&&(s||e.element[0].parentNode&&11!==e.element[0].parentNode.nodeType))for(n=0;a.length>n;n++)e.options[a[n][0]]&&a[n][1].apply(e.element,i)}};var l=0,u=Array.prototype.slice;e.cleanData=function(t){return function(i){var s,n,a;for(a=0;null!=(n=i[a]);a++)try{s=e._data(n,"events"),s&&s.remove&&e(n).triggerHandler("remove")}catch(o){}t(i)}}(e.cleanData),e.widget=function(t,i,s){var n,a,o,r,h={},l=t.split(".")[0];return t=t.split(".")[1],n=l+"-"+t,s||(s=i,i=e.Widget),e.expr[":"][n.toLowerCase()]=function(t){return!!e.data(t,n)},e[l]=e[l]||{},a=e[l][t],o=e[l][t]=function(e,t){return this._createWidget?(arguments.length&&this._createWidget(e,t),void 0):new o(e,t)},e.extend(o,a,{version:s.version,_proto:e.extend({},s),_childConstructors:[]}),r=new i,r.options=e.widget.extend({},r.options),e.each(s,function(t,s){return e.isFunction(s)?(h[t]=function(){var e=function(){return i.prototype[t].apply(this,arguments)},n=function(e){return i.prototype[t].apply(this,e)};return function(){var t,i=this._super,a=this._superApply;return this._super=e,this._superApply=n,t=s.apply(this,arguments),this._super=i,this._superApply=a,t}}(),void 0):(h[t]=s,void 0)}),o.prototype=e.widget.extend(r,{widgetEventPrefix:a?r.widgetEventPrefix||t:t},h,{constructor:o,namespace:l,widgetName:t,widgetFullName:n}),a?(e.each(a._childConstructors,function(t,i){var s=i.prototype;e.widget(s.namespace+"."+s.widgetName,o,i._proto)}),delete a._childConstructors):i._childConstructors.push(o),e.widget.bridge(t,o),o},e.widget.extend=function(t){for(var i,s,n=u.call(arguments,1),a=0,o=n.length;o>a;a++)for(i in n[a])s=n[a][i],n[a].hasOwnProperty(i)&&void 0!==s&&(t[i]=e.isPlainObject(s)?e.isPlainObject(t[i])?e.widget.extend({},t[i],s):e.widget.extend({},s):s);return t},e.widget.bridge=function(t,i){var s=i.prototype.widgetFullName||t;e.fn[t]=function(n){var a="string"==typeof n,o=u.call(arguments,1),r=this;return a?this.each(function(){var i,a=e.data(this,s);return"instance"===n?(r=a,!1):a?e.isFunction(a[n])&&"_"!==n.charAt(0)?(i=a[n].apply(a,o),i!==a&&void 0!==i?(r=i&&i.jquery?r.pushStack(i.get()):i,!1):void 0):e.error("no such method '"+n+"' for "+t+" widget instance"):e.error("cannot call methods on "+t+" prior to initialization; "+"attempted to call method '"+n+"'")}):(o.length&&(n=e.widget.extend.apply(null,[n].concat(o))),this.each(function(){var t=e.data(this,s);t?(t.option(n||{}),t._init&&t._init()):e.data(this,s,new i(n,this))})),r}},e.Widget=function(){},e.Widget._childConstructors=[],e.Widget.prototype={widgetName:"widget",widgetEventPrefix:"",defaultElement:"<div>",options:{disabled:!1,create:null},_createWidget:function(t,i){i=e(i||this.defaultElement||this)[0],this.element=e(i),this.uuid=l++,this.eventNamespace="."+this.widgetName+this.uuid,this.bindings=e(),this.hoverable=e(),this.focusable=e(),i!==this&&(e.data(i,this.widgetFullName,this),this._on(!0,this.element,{remove:function(e){e.target===i&&this.destroy()}}),this.document=e(i.style?i.ownerDocument:i.document||i),this.window=e(this.document[0].defaultView||this.document[0].parentWindow)),this.options=e.widget.extend({},this.options,this._getCreateOptions(),t),this._create(),this._trigger("create",null,this._getCreateEventData()),this._init()},_getCreateOptions:e.noop,_getCreateEventData:e.noop,_create:e.noop,_init:e.noop,destroy:function(){this._destroy(),this.element.unbind(this.eventNamespace).removeData(this.widgetFullName).removeData(e.camelCase(this.widgetFullName)),this.widget().unbind(this.eventNamespace).removeAttr("aria-disabled").removeClass(this.widgetFullName+"-disabled "+"ui-state-disabled"),this.bindings.unbind(this.eventNamespace),this.hoverable.removeClass("ui-state-hover"),this.focusable.removeClass("ui-state-focus")},_destroy:e.noop,widget:function(){return this.element},option:function(t,i){var s,n,a,o=t;if(0===arguments.length)return e.widget.extend({},this.options);if("string"==typeof t)if(o={},s=t.split("."),t=s.shift(),s.length){for(n=o[t]=e.widget.extend({},this.options[t]),a=0;s.length-1>a;a++)n[s[a]]=n[s[a]]||{},n=n[s[a]];if(t=s.pop(),1===arguments.length)return void 0===n[t]?null:n[t];n[t]=i}else{if(1===arguments.length)return void 0===this.options[t]?null:this.options[t];o[t]=i}return this._setOptions(o),this},_setOptions:function(e){var t;for(t in e)this._setOption(t,e[t]);return this},_setOption:function(e,t){return this.options[e]=t,"disabled"===e&&(this.widget().toggleClass(this.widgetFullName+"-disabled",!!t),t&&(this.hoverable.removeClass("ui-state-hover"),this.focusable.removeClass("ui-state-focus"))),this},enable:function(){return this._setOptions({disabled:!1})},disable:function(){return this._setOptions({disabled:!0})},_on:function(t,i,s){var n,a=this;"boolean"!=typeof t&&(s=i,i=t,t=!1),s?(i=n=e(i),this.bindings=this.bindings.add(i)):(s=i,i=this.element,n=this.widget()),e.each(s,function(s,o){function r(){return t||a.options.disabled!==!0&&!e(this).hasClass("ui-state-disabled")?("string"==typeof o?a[o]:o).apply(a,arguments):void 0}"string"!=typeof o&&(r.guid=o.guid=o.guid||r.guid||e.guid++);var h=s.match(/^([\w:-]*)\s*(.*)$/),l=h[1]+a.eventNamespace,u=h[2];u?n.delegate(u,l,r):i.bind(l,r)})},_off:function(t,i){i=(i||"").split(" ").join(this.eventNamespace+" ")+this.eventNamespace,t.unbind(i).undelegate(i),this.bindings=e(this.bindings.not(t).get()),this.focusable=e(this.focusable.not(t).get()),this.hoverable=e(this.hoverable.not(t).get())},_delay:function(e,t){function i(){return("string"==typeof e?s[e]:e).apply(s,arguments)}var s=this;return setTimeout(i,t||0)},_hoverable:function(t){this.hoverable=this.hoverable.add(t),this._on(t,{mouseenter:function(t){e(t.currentTarget).addClass("ui-state-hover")},mouseleave:function(t){e(t.currentTarget).removeClass("ui-state-hover")}})},_focusable:function(t){this.focusable=this.focusable.add(t),this._on(t,{focusin:function(t){e(t.currentTarget).addClass("ui-state-focus")},focusout:function(t){e(t.currentTarget).removeClass("ui-state-focus")}})},_trigger:function(t,i,s){var n,a,o=this.options[t];if(s=s||{},i=e.Event(i),i.type=(t===this.widgetEventPrefix?t:this.widgetEventPrefix+t).toLowerCase(),i.target=this.element[0],a=i.originalEvent)for(n in a)n in i||(i[n]=a[n]);return this.element.trigger(i,s),!(e.isFunction(o)&&o.apply(this.element[0],[i].concat(s))===!1||i.isDefaultPrevented())}},e.each({show:"fadeIn",hide:"fadeOut"},function(t,i){e.Widget.prototype["_"+t]=function(s,n,a){"string"==typeof n&&(n={effect:n});var o,r=n?n===!0||"number"==typeof n?i:n.effect||i:t;n=n||{},"number"==typeof n&&(n={duration:n}),o=!e.isEmptyObject(n),n.complete=a,n.delay&&s.delay(n.delay),o&&e.effects&&e.effects.effect[r]?s[t](n):r!==t&&s[r]?s[r](n.duration,n.easing,a):s.queue(function(i){e(this)[t](),a&&a.call(s[0]),i()})}}),e.widget;var d=!1;e(document).mouseup(function(){d=!1}),e.widget("ui.mouse",{version:"1.11.4",options:{cancel:"input,textarea,button,select,option",distance:1,delay:0},_mouseInit:function(){var t=this;this.element.bind("mousedown."+this.widgetName,function(e){return t._mouseDown(e)}).bind("click."+this.widgetName,function(i){return!0===e.data(i.target,t.widgetName+".preventClickEvent")?(e.removeData(i.target,t.widgetName+".preventClickEvent"),i.stopImmediatePropagation(),!1):void 0}),this.started=!1},_mouseDestroy:function(){this.element.unbind("."+this.widgetName),this._mouseMoveDelegate&&this.document.unbind("mousemove."+this.widgetName,this._mouseMoveDelegate).unbind("mouseup."+this.widgetName,this._mouseUpDelegate)},_mouseDown:function(t){if(!d){this._mouseMoved=!1,this._mouseStarted&&this._mouseUp(t),this._mouseDownEvent=t;var i=this,s=1===t.which,n="string"==typeof this.options.cancel&&t.target.nodeName?e(t.target).closest(this.options.cancel).length:!1;return s&&!n&&this._mouseCapture(t)?(this.mouseDelayMet=!this.options.delay,this.mouseDelayMet||(this._mouseDelayTimer=setTimeout(function(){i.mouseDelayMet=!0},this.options.delay)),this._mouseDistanceMet(t)&&this._mouseDelayMet(t)&&(this._mouseStarted=this._mouseStart(t)!==!1,!this._mouseStarted)?(t.preventDefault(),!0):(!0===e.data(t.target,this.widgetName+".preventClickEvent")&&e.removeData(t.target,this.widgetName+".preventClickEvent"),this._mouseMoveDelegate=function(e){return i._mouseMove(e)},this._mouseUpDelegate=function(e){return i._mouseUp(e)},this.document.bind("mousemove."+this.widgetName,this._mouseMoveDelegate).bind("mouseup."+this.widgetName,this._mouseUpDelegate),t.preventDefault(),d=!0,!0)):!0}},_mouseMove:function(t){if(this._mouseMoved){if(e.ui.ie&&(!document.documentMode||9>document.documentMode)&&!t.button)return this._mouseUp(t);if(!t.which)return this._mouseUp(t)}return(t.which||t.button)&&(this._mouseMoved=!0),this._mouseStarted?(this._mouseDrag(t),t.preventDefault()):(this._mouseDistanceMet(t)&&this._mouseDelayMet(t)&&(this._mouseStarted=this._mouseStart(this._mouseDownEvent,t)!==!1,this._mouseStarted?this._mouseDrag(t):this._mouseUp(t)),!this._mouseStarted)},_mouseUp:function(t){return this.document.unbind("mousemove."+this.widgetName,this._mouseMoveDelegate).unbind("mouseup."+this.widgetName,this._mouseUpDelegate),this._mouseStarted&&(this._mouseStarted=!1,t.target===this._mouseDownEvent.target&&e.data(t.target,this.widgetName+".preventClickEvent",!0),this._mouseStop(t)),d=!1,!1},_mouseDistanceMet:function(e){return Math.max(Math.abs(this._mouseDownEvent.pageX-e.pageX),Math.abs(this._mouseDownEvent.pageY-e.pageY))>=this.options.distance},_mouseDelayMet:function(){return this.mouseDelayMet},_mouseStart:function(){},_mouseDrag:function(){},_mouseStop:function(){},_mouseCapture:function(){return!0}}),function(){function t(e,t,i){return[parseFloat(e[0])*(p.test(e[0])?t/100:1),parseFloat(e[1])*(p.test(e[1])?i/100:1)]}function i(t,i){return parseInt(e.css(t,i),10)||0}function s(t){var i=t[0];return 9===i.nodeType?{width:t.width(),height:t.height(),offset:{top:0,left:0}}:e.isWindow(i)?{width:t.width(),height:t.height(),offset:{top:t.scrollTop(),left:t.scrollLeft()}}:i.preventDefault?{width:0,height:0,offset:{top:i.pageY,left:i.pageX}}:{width:t.outerWidth(),height:t.outerHeight(),offset:t.offset()}}e.ui=e.ui||{};var n,a,o=Math.max,r=Math.abs,h=Math.round,l=/left|center|right/,u=/top|center|bottom/,d=/[\+\-]\d+(\.[\d]+)?%?/,c=/^\w+/,p=/%$/,f=e.fn.position;e.position={scrollbarWidth:function(){if(void 0!==n)return n;var t,i,s=e("<div style='display:block;position:absolute;width:50px;height:50px;overflow:hidden;'><div style='height:100px;width:auto;'></div></div>"),a=s.children()[0];return e("body").append(s),t=a.offsetWidth,s.css("overflow","scroll"),i=a.offsetWidth,t===i&&(i=s[0].clientWidth),s.remove(),n=t-i},getScrollInfo:function(t){var i=t.isWindow||t.isDocument?"":t.element.css("overflow-x"),s=t.isWindow||t.isDocument?"":t.element.css("overflow-y"),n="scroll"===i||"auto"===i&&t.width<t.element[0].scrollWidth,a="scroll"===s||"auto"===s&&t.height<t.element[0].scrollHeight;return{width:a?e.position.scrollbarWidth():0,height:n?e.position.scrollbarWidth():0}},getWithinInfo:function(t){var i=e(t||window),s=e.isWindow(i[0]),n=!!i[0]&&9===i[0].nodeType;return{element:i,isWindow:s,isDocument:n,offset:i.offset()||{left:0,top:0},scrollLeft:i.scrollLeft(),scrollTop:i.scrollTop(),width:s||n?i.width():i.outerWidth(),height:s||n?i.height():i.outerHeight()}}},e.fn.position=function(n){if(!n||!n.of)return f.apply(this,arguments);n=e.extend({},n);var p,m,g,v,y,b,_=e(n.of),x=e.position.getWithinInfo(n.within),w=e.position.getScrollInfo(x),k=(n.collision||"flip").split(" "),T={};return b=s(_),_[0].preventDefault&&(n.at="left top"),m=b.width,g=b.height,v=b.offset,y=e.extend({},v),e.each(["my","at"],function(){var e,t,i=(n[this]||"").split(" ");1===i.length&&(i=l.test(i[0])?i.concat(["center"]):u.test(i[0])?["center"].concat(i):["center","center"]),i[0]=l.test(i[0])?i[0]:"center",i[1]=u.test(i[1])?i[1]:"center",e=d.exec(i[0]),t=d.exec(i[1]),T[this]=[e?e[0]:0,t?t[0]:0],n[this]=[c.exec(i[0])[0],c.exec(i[1])[0]]}),1===k.length&&(k[1]=k[0]),"right"===n.at[0]?y.left+=m:"center"===n.at[0]&&(y.left+=m/2),"bottom"===n.at[1]?y.top+=g:"center"===n.at[1]&&(y.top+=g/2),p=t(T.at,m,g),y.left+=p[0],y.top+=p[1],this.each(function(){var s,l,u=e(this),d=u.outerWidth(),c=u.outerHeight(),f=i(this,"marginLeft"),b=i(this,"marginTop"),D=d+f+i(this,"marginRight")+w.width,S=c+b+i(this,"marginBottom")+w.height,M=e.extend({},y),C=t(T.my,u.outerWidth(),u.outerHeight());"right"===n.my[0]?M.left-=d:"center"===n.my[0]&&(M.left-=d/2),"bottom"===n.my[1]?M.top-=c:"center"===n.my[1]&&(M.top-=c/2),M.left+=C[0],M.top+=C[1],a||(M.left=h(M.left),M.top=h(M.top)),s={marginLeft:f,marginTop:b},e.each(["left","top"],function(t,i){e.ui.position[k[t]]&&e.ui.position[k[t]][i](M,{targetWidth:m,targetHeight:g,elemWidth:d,elemHeight:c,collisionPosition:s,collisionWidth:D,collisionHeight:S,offset:[p[0]+C[0],p[1]+C[1]],my:n.my,at:n.at,within:x,elem:u})}),n.using&&(l=function(e){var t=v.left-M.left,i=t+m-d,s=v.top-M.top,a=s+g-c,h={target:{element:_,left:v.left,top:v.top,width:m,height:g},element:{element:u,left:M.left,top:M.top,width:d,height:c},horizontal:0>i?"left":t>0?"right":"center",vertical:0>a?"top":s>0?"bottom":"middle"};d>m&&m>r(t+i)&&(h.horizontal="center"),c>g&&g>r(s+a)&&(h.vertical="middle"),h.important=o(r(t),r(i))>o(r(s),r(a))?"horizontal":"vertical",n.using.call(this,e,h)}),u.offset(e.extend(M,{using:l}))})},e.ui.position={fit:{left:function(e,t){var i,s=t.within,n=s.isWindow?s.scrollLeft:s.offset.left,a=s.width,r=e.left-t.collisionPosition.marginLeft,h=n-r,l=r+t.collisionWidth-a-n;t.collisionWidth>a?h>0&&0>=l?(i=e.left+h+t.collisionWidth-a-n,e.left+=h-i):e.left=l>0&&0>=h?n:h>l?n+a-t.collisionWidth:n:h>0?e.left+=h:l>0?e.left-=l:e.left=o(e.left-r,e.left)},top:function(e,t){var i,s=t.within,n=s.isWindow?s.scrollTop:s.offset.top,a=t.within.height,r=e.top-t.collisionPosition.marginTop,h=n-r,l=r+t.collisionHeight-a-n;t.collisionHeight>a?h>0&&0>=l?(i=e.top+h+t.collisionHeight-a-n,e.top+=h-i):e.top=l>0&&0>=h?n:h>l?n+a-t.collisionHeight:n:h>0?e.top+=h:l>0?e.top-=l:e.top=o(e.top-r,e.top)}},flip:{left:function(e,t){var i,s,n=t.within,a=n.offset.left+n.scrollLeft,o=n.width,h=n.isWindow?n.scrollLeft:n.offset.left,l=e.left-t.collisionPosition.marginLeft,u=l-h,d=l+t.collisionWidth-o-h,c="left"===t.my[0]?-t.elemWidth:"right"===t.my[0]?t.elemWidth:0,p="left"===t.at[0]?t.targetWidth:"right"===t.at[0]?-t.targetWidth:0,f=-2*t.offset[0];0>u?(i=e.left+c+p+f+t.collisionWidth-o-a,(0>i||r(u)>i)&&(e.left+=c+p+f)):d>0&&(s=e.left-t.collisionPosition.marginLeft+c+p+f-h,(s>0||d>r(s))&&(e.left+=c+p+f))},top:function(e,t){var i,s,n=t.within,a=n.offset.top+n.scrollTop,o=n.height,h=n.isWindow?n.scrollTop:n.offset.top,l=e.top-t.collisionPosition.marginTop,u=l-h,d=l+t.collisionHeight-o-h,c="top"===t.my[1],p=c?-t.elemHeight:"bottom"===t.my[1]?t.elemHeight:0,f="top"===t.at[1]?t.targetHeight:"bottom"===t.at[1]?-t.targetHeight:0,m=-2*t.offset[1];0>u?(s=e.top+p+f+m+t.collisionHeight-o-a,(0>s||r(u)>s)&&(e.top+=p+f+m)):d>0&&(i=e.top-t.collisionPosition.marginTop+p+f+m-h,(i>0||d>r(i))&&(e.top+=p+f+m))}},flipfit:{left:function(){e.ui.position.flip.left.apply(this,arguments),e.ui.position.fit.left.apply(this,arguments)},top:function(){e.ui.position.flip.top.apply(this,arguments),e.ui.position.fit.top.apply(this,arguments)}}},function(){var t,i,s,n,o,r=document.getElementsByTagName("body")[0],h=document.createElement("div");t=document.createElement(r?"div":"body"),s={visibility:"hidden",width:0,height:0,border:0,margin:0,background:"none"},r&&e.extend(s,{position:"absolute",left:"-1000px",top:"-1000px"});for(o in s)t.style[o]=s[o];t.appendChild(h),i=r||document.documentElement,i.insertBefore(t,i.firstChild),h.style.cssText="position: absolute; left: 10.7432222px;",n=e(h).offset().left,a=n>10&&11>n,t.innerHTML="",i.removeChild(t)}()}(),e.ui.position,e.widget("ui.accordion",{version:"1.11.4",options:{active:0,animate:{},collapsible:!1,event:"click",header:"> li > :first-child,> :not(li):even",heightStyle:"auto",icons:{activeHeader:"ui-icon-triangle-1-s",header:"ui-icon-triangle-1-e"},activate:null,beforeActivate:null},hideProps:{borderTopWidth:"hide",borderBottomWidth:"hide",paddingTop:"hide",paddingBottom:"hide",height:"hide"},showProps:{borderTopWidth:"show",borderBottomWidth:"show",paddingTop:"show",paddingBottom:"show",height:"show"},_create:function(){var t=this.options;this.prevShow=this.prevHide=e(),this.element.addClass("ui-accordion ui-widget ui-helper-reset").attr("role","tablist"),t.collapsible||t.active!==!1&&null!=t.active||(t.active=0),this._processPanels(),0>t.active&&(t.active+=this.headers.length),this._refresh()},_getCreateEventData:function(){return{header:this.active,panel:this.active.length?this.active.next():e()}},_createIcons:function(){var t=this.options.icons;t&&(e("<span>").addClass("ui-accordion-header-icon ui-icon "+t.header).prependTo(this.headers),this.active.children(".ui-accordion-header-icon").removeClass(t.header).addClass(t.activeHeader),this.headers.addClass("ui-accordion-icons"))},_destroyIcons:function(){this.headers.removeClass("ui-accordion-icons").children(".ui-accordion-header-icon").remove()},_destroy:function(){var e;this.element.removeClass("ui-accordion ui-widget ui-helper-reset").removeAttr("role"),this.headers.removeClass("ui-accordion-header ui-accordion-header-active ui-state-default ui-corner-all ui-state-active ui-state-disabled ui-corner-top").removeAttr("role").removeAttr("aria-expanded").removeAttr("aria-selected").removeAttr("aria-controls").removeAttr("tabIndex").removeUniqueId(),this._destroyIcons(),e=this.headers.next().removeClass("ui-helper-reset ui-widget-content ui-corner-bottom ui-accordion-content ui-accordion-content-active ui-state-disabled").css("display","").removeAttr("role").removeAttr("aria-hidden").removeAttr("aria-labelledby").removeUniqueId(),"content"!==this.options.heightStyle&&e.css("height","")},_setOption:function(e,t){return"active"===e?(this._activate(t),void 0):("event"===e&&(this.options.event&&this._off(this.headers,this.options.event),this._setupEvents(t)),this._super(e,t),"collapsible"!==e||t||this.options.active!==!1||this._activate(0),"icons"===e&&(this._destroyIcons(),t&&this._createIcons()),"disabled"===e&&(this.element.toggleClass("ui-state-disabled",!!t).attr("aria-disabled",t),this.headers.add(this.headers.next()).toggleClass("ui-state-disabled",!!t)),void 0)},_keydown:function(t){if(!t.altKey&&!t.ctrlKey){var i=e.ui.keyCode,s=this.headers.length,n=this.headers.index(t.target),a=!1;switch(t.keyCode){case i.RIGHT:case i.DOWN:a=this.headers[(n+1)%s];break;case i.LEFT:case i.UP:a=this.headers[(n-1+s)%s];break;case i.SPACE:case i.ENTER:this._eventHandler(t);break;case i.HOME:a=this.headers[0];break;case i.END:a=this.headers[s-1]}a&&(e(t.target).attr("tabIndex",-1),e(a).attr("tabIndex",0),a.focus(),t.preventDefault())}},_panelKeyDown:function(t){t.keyCode===e.ui.keyCode.UP&&t.ctrlKey&&e(t.currentTarget).prev().focus()},refresh:function(){var t=this.options;this._processPanels(),t.active===!1&&t.collapsible===!0||!this.headers.length?(t.active=!1,this.active=e()):t.active===!1?this._activate(0):this.active.length&&!e.contains(this.element[0],this.active[0])?this.headers.length===this.headers.find(".ui-state-disabled").length?(t.active=!1,this.active=e()):this._activate(Math.max(0,t.active-1)):t.active=this.headers.index(this.active),this._destroyIcons(),this._refresh()},_processPanels:function(){var e=this.headers,t=this.panels;this.headers=this.element.find(this.options.header).addClass("ui-accordion-header ui-state-default ui-corner-all"),this.panels=this.headers.next().addClass("ui-accordion-content ui-helper-reset ui-widget-content ui-corner-bottom").filter(":not(.ui-accordion-content-active)").hide(),t&&(this._off(e.not(this.headers)),this._off(t.not(this.panels)))},_refresh:function(){var t,i=this.options,s=i.heightStyle,n=this.element.parent();this.active=this._findActive(i.active).addClass("ui-accordion-header-active ui-state-active ui-corner-top").removeClass("ui-corner-all"),this.active.next().addClass("ui-accordion-content-active").show(),this.headers.attr("role","tab").each(function(){var t=e(this),i=t.uniqueId().attr("id"),s=t.next(),n=s.uniqueId().attr("id");t.attr("aria-controls",n),s.attr("aria-labelledby",i)}).next().attr("role","tabpanel"),this.headers.not(this.active).attr({"aria-selected":"false","aria-expanded":"false",tabIndex:-1}).next().attr({"aria-hidden":"true"}).hide(),this.active.length?this.active.attr({"aria-selected":"true","aria-expanded":"true",tabIndex:0}).next().attr({"aria-hidden":"false"}):this.headers.eq(0).attr("tabIndex",0),this._createIcons(),this._setupEvents(i.event),"fill"===s?(t=n.height(),this.element.siblings(":visible").each(function(){var i=e(this),s=i.css("position");"absolute"!==s&&"fixed"!==s&&(t-=i.outerHeight(!0))}),this.headers.each(function(){t-=e(this).outerHeight(!0)}),this.headers.next().each(function(){e(this).height(Math.max(0,t-e(this).innerHeight()+e(this).height()))}).css("overflow","auto")):"auto"===s&&(t=0,this.headers.next().each(function(){t=Math.max(t,e(this).css("height","").height())}).height(t))},_activate:function(t){var i=this._findActive(t)[0];i!==this.active[0]&&(i=i||this.active[0],this._eventHandler({target:i,currentTarget:i,preventDefault:e.noop}))},_findActive:function(t){return"number"==typeof t?this.headers.eq(t):e()},_setupEvents:function(t){var i={keydown:"_keydown"};t&&e.each(t.split(" "),function(e,t){i[t]="_eventHandler"}),this._off(this.headers.add(this.headers.next())),this._on(this.headers,i),this._on(this.headers.next(),{keydown:"_panelKeyDown"}),this._hoverable(this.headers),this._focusable(this.headers)},_eventHandler:function(t){var i=this.options,s=this.active,n=e(t.currentTarget),a=n[0]===s[0],o=a&&i.collapsible,r=o?e():n.next(),h=s.next(),l={oldHeader:s,oldPanel:h,newHeader:o?e():n,newPanel:r};t.preventDefault(),a&&!i.collapsible||this._trigger("beforeActivate",t,l)===!1||(i.active=o?!1:this.headers.index(n),this.active=a?e():n,this._toggle(l),s.removeClass("ui-accordion-header-active ui-state-active"),i.icons&&s.children(".ui-accordion-header-icon").removeClass(i.icons.activeHeader).addClass(i.icons.header),a||(n.removeClass("ui-corner-all").addClass("ui-accordion-header-active ui-state-active ui-corner-top"),i.icons&&n.children(".ui-accordion-header-icon").removeClass(i.icons.header).addClass(i.icons.activeHeader),n.next().addClass("ui-accordion-content-active")))},_toggle:function(t){var i=t.newPanel,s=this.prevShow.length?this.prevShow:t.oldPanel;this.prevShow.add(this.prevHide).stop(!0,!0),this.prevShow=i,this.prevHide=s,this.options.animate?this._animate(i,s,t):(s.hide(),i.show(),this._toggleComplete(t)),s.attr({"aria-hidden":"true"}),s.prev().attr({"aria-selected":"false","aria-expanded":"false"}),i.length&&s.length?s.prev().attr({tabIndex:-1,"aria-expanded":"false"}):i.length&&this.headers.filter(function(){return 0===parseInt(e(this).attr("tabIndex"),10)}).attr("tabIndex",-1),i.attr("aria-hidden","false").prev().attr({"aria-selected":"true","aria-expanded":"true",tabIndex:0})},_animate:function(e,t,i){var s,n,a,o=this,r=0,h=e.css("box-sizing"),l=e.length&&(!t.length||e.index()<t.index()),u=this.options.animate||{},d=l&&u.down||u,c=function(){o._toggleComplete(i)};return"number"==typeof d&&(a=d),"string"==typeof d&&(n=d),n=n||d.easing||u.easing,a=a||d.duration||u.duration,t.length?e.length?(s=e.show().outerHeight(),t.animate(this.hideProps,{duration:a,easing:n,step:function(e,t){t.now=Math.round(e)}}),e.hide().animate(this.showProps,{duration:a,easing:n,complete:c,step:function(e,i){i.now=Math.round(e),"height"!==i.prop?"content-box"===h&&(r+=i.now):"content"!==o.options.heightStyle&&(i.now=Math.round(s-t.outerHeight()-r),r=0)}}),void 0):t.animate(this.hideProps,a,n,c):e.animate(this.showProps,a,n,c)},_toggleComplete:function(e){var t=e.oldPanel;t.removeClass("ui-accordion-content-active").prev().removeClass("ui-corner-top").addClass("ui-corner-all"),t.length&&(t.parent()[0].className=t.parent()[0].className),this._trigger("activate",null,e)}}),e.widget("ui.menu",{version:"1.11.4",defaultElement:"<ul>",delay:300,options:{icons:{submenu:"ui-icon-carat-1-e"},items:"> *",menus:"ul",position:{my:"left-1 top",at:"right top"},role:"menu",blur:null,focus:null,select:null},_create:function(){this.activeMenu=this.element,this.mouseHandled=!1,this.element.uniqueId().addClass("ui-menu ui-widget ui-widget-content").toggleClass("ui-menu-icons",!!this.element.find(".ui-icon").length).attr({role:this.options.role,tabIndex:0}),this.options.disabled&&this.element.addClass("ui-state-disabled").attr("aria-disabled","true"),this._on({"mousedown .ui-menu-item":function(e){e.preventDefault()},"click .ui-menu-item":function(t){var i=e(t.target);!this.mouseHandled&&i.not(".ui-state-disabled").length&&(this.select(t),t.isPropagationStopped()||(this.mouseHandled=!0),i.has(".ui-menu").length?this.expand(t):!this.element.is(":focus")&&e(this.document[0].activeElement).closest(".ui-menu").length&&(this.element.trigger("focus",[!0]),this.active&&1===this.active.parents(".ui-menu").length&&clearTimeout(this.timer)))},"mouseenter .ui-menu-item":function(t){if(!this.previousFilter){var i=e(t.currentTarget);
i.siblings(".ui-state-active").removeClass("ui-state-active"),this.focus(t,i)}},mouseleave:"collapseAll","mouseleave .ui-menu":"collapseAll",focus:function(e,t){var i=this.active||this.element.find(this.options.items).eq(0);t||this.focus(e,i)},blur:function(t){this._delay(function(){e.contains(this.element[0],this.document[0].activeElement)||this.collapseAll(t)})},keydown:"_keydown"}),this.refresh(),this._on(this.document,{click:function(e){this._closeOnDocumentClick(e)&&this.collapseAll(e),this.mouseHandled=!1}})},_destroy:function(){this.element.removeAttr("aria-activedescendant").find(".ui-menu").addBack().removeClass("ui-menu ui-widget ui-widget-content ui-menu-icons ui-front").removeAttr("role").removeAttr("tabIndex").removeAttr("aria-labelledby").removeAttr("aria-expanded").removeAttr("aria-hidden").removeAttr("aria-disabled").removeUniqueId().show(),this.element.find(".ui-menu-item").removeClass("ui-menu-item").removeAttr("role").removeAttr("aria-disabled").removeUniqueId().removeClass("ui-state-hover").removeAttr("tabIndex").removeAttr("role").removeAttr("aria-haspopup").children().each(function(){var t=e(this);t.data("ui-menu-submenu-carat")&&t.remove()}),this.element.find(".ui-menu-divider").removeClass("ui-menu-divider ui-widget-content")},_keydown:function(t){var i,s,n,a,o=!0;switch(t.keyCode){case e.ui.keyCode.PAGE_UP:this.previousPage(t);break;case e.ui.keyCode.PAGE_DOWN:this.nextPage(t);break;case e.ui.keyCode.HOME:this._move("first","first",t);break;case e.ui.keyCode.END:this._move("last","last",t);break;case e.ui.keyCode.UP:this.previous(t);break;case e.ui.keyCode.DOWN:this.next(t);break;case e.ui.keyCode.LEFT:this.collapse(t);break;case e.ui.keyCode.RIGHT:this.active&&!this.active.is(".ui-state-disabled")&&this.expand(t);break;case e.ui.keyCode.ENTER:case e.ui.keyCode.SPACE:this._activate(t);break;case e.ui.keyCode.ESCAPE:this.collapse(t);break;default:o=!1,s=this.previousFilter||"",n=String.fromCharCode(t.keyCode),a=!1,clearTimeout(this.filterTimer),n===s?a=!0:n=s+n,i=this._filterMenuItems(n),i=a&&-1!==i.index(this.active.next())?this.active.nextAll(".ui-menu-item"):i,i.length||(n=String.fromCharCode(t.keyCode),i=this._filterMenuItems(n)),i.length?(this.focus(t,i),this.previousFilter=n,this.filterTimer=this._delay(function(){delete this.previousFilter},1e3)):delete this.previousFilter}o&&t.preventDefault()},_activate:function(e){this.active.is(".ui-state-disabled")||(this.active.is("[aria-haspopup='true']")?this.expand(e):this.select(e))},refresh:function(){var t,i,s=this,n=this.options.icons.submenu,a=this.element.find(this.options.menus);this.element.toggleClass("ui-menu-icons",!!this.element.find(".ui-icon").length),a.filter(":not(.ui-menu)").addClass("ui-menu ui-widget ui-widget-content ui-front").hide().attr({role:this.options.role,"aria-hidden":"true","aria-expanded":"false"}).each(function(){var t=e(this),i=t.parent(),s=e("<span>").addClass("ui-menu-icon ui-icon "+n).data("ui-menu-submenu-carat",!0);i.attr("aria-haspopup","true").prepend(s),t.attr("aria-labelledby",i.attr("id"))}),t=a.add(this.element),i=t.find(this.options.items),i.not(".ui-menu-item").each(function(){var t=e(this);s._isDivider(t)&&t.addClass("ui-widget-content ui-menu-divider")}),i.not(".ui-menu-item, .ui-menu-divider").addClass("ui-menu-item").uniqueId().attr({tabIndex:-1,role:this._itemRole()}),i.filter(".ui-state-disabled").attr("aria-disabled","true"),this.active&&!e.contains(this.element[0],this.active[0])&&this.blur()},_itemRole:function(){return{menu:"menuitem",listbox:"option"}[this.options.role]},_setOption:function(e,t){"icons"===e&&this.element.find(".ui-menu-icon").removeClass(this.options.icons.submenu).addClass(t.submenu),"disabled"===e&&this.element.toggleClass("ui-state-disabled",!!t).attr("aria-disabled",t),this._super(e,t)},focus:function(e,t){var i,s;this.blur(e,e&&"focus"===e.type),this._scrollIntoView(t),this.active=t.first(),s=this.active.addClass("ui-state-focus").removeClass("ui-state-active"),this.options.role&&this.element.attr("aria-activedescendant",s.attr("id")),this.active.parent().closest(".ui-menu-item").addClass("ui-state-active"),e&&"keydown"===e.type?this._close():this.timer=this._delay(function(){this._close()},this.delay),i=t.children(".ui-menu"),i.length&&e&&/^mouse/.test(e.type)&&this._startOpening(i),this.activeMenu=t.parent(),this._trigger("focus",e,{item:t})},_scrollIntoView:function(t){var i,s,n,a,o,r;this._hasScroll()&&(i=parseFloat(e.css(this.activeMenu[0],"borderTopWidth"))||0,s=parseFloat(e.css(this.activeMenu[0],"paddingTop"))||0,n=t.offset().top-this.activeMenu.offset().top-i-s,a=this.activeMenu.scrollTop(),o=this.activeMenu.height(),r=t.outerHeight(),0>n?this.activeMenu.scrollTop(a+n):n+r>o&&this.activeMenu.scrollTop(a+n-o+r))},blur:function(e,t){t||clearTimeout(this.timer),this.active&&(this.active.removeClass("ui-state-focus"),this.active=null,this._trigger("blur",e,{item:this.active}))},_startOpening:function(e){clearTimeout(this.timer),"true"===e.attr("aria-hidden")&&(this.timer=this._delay(function(){this._close(),this._open(e)},this.delay))},_open:function(t){var i=e.extend({of:this.active},this.options.position);clearTimeout(this.timer),this.element.find(".ui-menu").not(t.parents(".ui-menu")).hide().attr("aria-hidden","true"),t.show().removeAttr("aria-hidden").attr("aria-expanded","true").position(i)},collapseAll:function(t,i){clearTimeout(this.timer),this.timer=this._delay(function(){var s=i?this.element:e(t&&t.target).closest(this.element.find(".ui-menu"));s.length||(s=this.element),this._close(s),this.blur(t),this.activeMenu=s},this.delay)},_close:function(e){e||(e=this.active?this.active.parent():this.element),e.find(".ui-menu").hide().attr("aria-hidden","true").attr("aria-expanded","false").end().find(".ui-state-active").not(".ui-state-focus").removeClass("ui-state-active")},_closeOnDocumentClick:function(t){return!e(t.target).closest(".ui-menu").length},_isDivider:function(e){return!/[^\-\u2014\u2013\s]/.test(e.text())},collapse:function(e){var t=this.active&&this.active.parent().closest(".ui-menu-item",this.element);t&&t.length&&(this._close(),this.focus(e,t))},expand:function(e){var t=this.active&&this.active.children(".ui-menu ").find(this.options.items).first();t&&t.length&&(this._open(t.parent()),this._delay(function(){this.focus(e,t)}))},next:function(e){this._move("next","first",e)},previous:function(e){this._move("prev","last",e)},isFirstItem:function(){return this.active&&!this.active.prevAll(".ui-menu-item").length},isLastItem:function(){return this.active&&!this.active.nextAll(".ui-menu-item").length},_move:function(e,t,i){var s;this.active&&(s="first"===e||"last"===e?this.active["first"===e?"prevAll":"nextAll"](".ui-menu-item").eq(-1):this.active[e+"All"](".ui-menu-item").eq(0)),s&&s.length&&this.active||(s=this.activeMenu.find(this.options.items)[t]()),this.focus(i,s)},nextPage:function(t){var i,s,n;return this.active?(this.isLastItem()||(this._hasScroll()?(s=this.active.offset().top,n=this.element.height(),this.active.nextAll(".ui-menu-item").each(function(){return i=e(this),0>i.offset().top-s-n}),this.focus(t,i)):this.focus(t,this.activeMenu.find(this.options.items)[this.active?"last":"first"]())),void 0):(this.next(t),void 0)},previousPage:function(t){var i,s,n;return this.active?(this.isFirstItem()||(this._hasScroll()?(s=this.active.offset().top,n=this.element.height(),this.active.prevAll(".ui-menu-item").each(function(){return i=e(this),i.offset().top-s+n>0}),this.focus(t,i)):this.focus(t,this.activeMenu.find(this.options.items).first())),void 0):(this.next(t),void 0)},_hasScroll:function(){return this.element.outerHeight()<this.element.prop("scrollHeight")},select:function(t){this.active=this.active||e(t.target).closest(".ui-menu-item");var i={item:this.active};this.active.has(".ui-menu").length||this.collapseAll(t,!0),this._trigger("select",t,i)},_filterMenuItems:function(t){var i=t.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g,"\\$&"),s=RegExp("^"+i,"i");return this.activeMenu.find(this.options.items).filter(".ui-menu-item").filter(function(){return s.test(e.trim(e(this).text()))})}}),e.widget("ui.autocomplete",{version:"1.11.4",defaultElement:"<input>",options:{appendTo:null,autoFocus:!1,delay:300,minLength:1,position:{my:"left top",at:"left bottom",collision:"none"},source:null,change:null,close:null,focus:null,open:null,response:null,search:null,select:null},requestIndex:0,pending:0,_create:function(){var t,i,s,n=this.element[0].nodeName.toLowerCase(),a="textarea"===n,o="input"===n;this.isMultiLine=a?!0:o?!1:this.element.prop("isContentEditable"),this.valueMethod=this.element[a||o?"val":"text"],this.isNewMenu=!0,this.element.addClass("ui-autocomplete-input").attr("autocomplete","off"),this._on(this.element,{keydown:function(n){if(this.element.prop("readOnly"))return t=!0,s=!0,i=!0,void 0;t=!1,s=!1,i=!1;var a=e.ui.keyCode;switch(n.keyCode){case a.PAGE_UP:t=!0,this._move("previousPage",n);break;case a.PAGE_DOWN:t=!0,this._move("nextPage",n);break;case a.UP:t=!0,this._keyEvent("previous",n);break;case a.DOWN:t=!0,this._keyEvent("next",n);break;case a.ENTER:this.menu.active&&(t=!0,n.preventDefault(),this.menu.select(n));break;case a.TAB:this.menu.active&&this.menu.select(n);break;case a.ESCAPE:this.menu.element.is(":visible")&&(this.isMultiLine||this._value(this.term),this.close(n),n.preventDefault());break;default:i=!0,this._searchTimeout(n)}},keypress:function(s){if(t)return t=!1,(!this.isMultiLine||this.menu.element.is(":visible"))&&s.preventDefault(),void 0;if(!i){var n=e.ui.keyCode;switch(s.keyCode){case n.PAGE_UP:this._move("previousPage",s);break;case n.PAGE_DOWN:this._move("nextPage",s);break;case n.UP:this._keyEvent("previous",s);break;case n.DOWN:this._keyEvent("next",s)}}},input:function(e){return s?(s=!1,e.preventDefault(),void 0):(this._searchTimeout(e),void 0)},focus:function(){this.selectedItem=null,this.previous=this._value()},blur:function(e){return this.cancelBlur?(delete this.cancelBlur,void 0):(clearTimeout(this.searching),this.close(e),this._change(e),void 0)}}),this._initSource(),this.menu=e("<ul>").addClass("ui-autocomplete ui-front").appendTo(this._appendTo()).menu({role:null}).hide().menu("instance"),this._on(this.menu.element,{mousedown:function(t){t.preventDefault(),this.cancelBlur=!0,this._delay(function(){delete this.cancelBlur});var i=this.menu.element[0];e(t.target).closest(".ui-menu-item").length||this._delay(function(){var t=this;this.document.one("mousedown",function(s){s.target===t.element[0]||s.target===i||e.contains(i,s.target)||t.close()})})},menufocus:function(t,i){var s,n;return this.isNewMenu&&(this.isNewMenu=!1,t.originalEvent&&/^mouse/.test(t.originalEvent.type))?(this.menu.blur(),this.document.one("mousemove",function(){e(t.target).trigger(t.originalEvent)}),void 0):(n=i.item.data("ui-autocomplete-item"),!1!==this._trigger("focus",t,{item:n})&&t.originalEvent&&/^key/.test(t.originalEvent.type)&&this._value(n.value),s=i.item.attr("aria-label")||n.value,s&&e.trim(s).length&&(this.liveRegion.children().hide(),e("<div>").text(s).appendTo(this.liveRegion)),void 0)},menuselect:function(e,t){var i=t.item.data("ui-autocomplete-item"),s=this.previous;this.element[0]!==this.document[0].activeElement&&(this.element.focus(),this.previous=s,this._delay(function(){this.previous=s,this.selectedItem=i})),!1!==this._trigger("select",e,{item:i})&&this._value(i.value),this.term=this._value(),this.close(e),this.selectedItem=i}}),this.liveRegion=e("<span>",{role:"status","aria-live":"assertive","aria-relevant":"additions"}).addClass("ui-helper-hidden-accessible").appendTo(this.document[0].body),this._on(this.window,{beforeunload:function(){this.element.removeAttr("autocomplete")}})},_destroy:function(){clearTimeout(this.searching),this.element.removeClass("ui-autocomplete-input").removeAttr("autocomplete"),this.menu.element.remove(),this.liveRegion.remove()},_setOption:function(e,t){this._super(e,t),"source"===e&&this._initSource(),"appendTo"===e&&this.menu.element.appendTo(this._appendTo()),"disabled"===e&&t&&this.xhr&&this.xhr.abort()},_appendTo:function(){var t=this.options.appendTo;return t&&(t=t.jquery||t.nodeType?e(t):this.document.find(t).eq(0)),t&&t[0]||(t=this.element.closest(".ui-front")),t.length||(t=this.document[0].body),t},_initSource:function(){var t,i,s=this;e.isArray(this.options.source)?(t=this.options.source,this.source=function(i,s){s(e.ui.autocomplete.filter(t,i.term))}):"string"==typeof this.options.source?(i=this.options.source,this.source=function(t,n){s.xhr&&s.xhr.abort(),s.xhr=e.ajax({url:i,data:t,dataType:"json",success:function(e){n(e)},error:function(){n([])}})}):this.source=this.options.source},_searchTimeout:function(e){clearTimeout(this.searching),this.searching=this._delay(function(){var t=this.term===this._value(),i=this.menu.element.is(":visible"),s=e.altKey||e.ctrlKey||e.metaKey||e.shiftKey;(!t||t&&!i&&!s)&&(this.selectedItem=null,this.search(null,e))},this.options.delay)},search:function(e,t){return e=null!=e?e:this._value(),this.term=this._value(),e.length<this.options.minLength?this.close(t):this._trigger("search",t)!==!1?this._search(e):void 0},_search:function(e){this.pending++,this.element.addClass("ui-autocomplete-loading"),this.cancelSearch=!1,this.source({term:e},this._response())},_response:function(){var t=++this.requestIndex;return e.proxy(function(e){t===this.requestIndex&&this.__response(e),this.pending--,this.pending||this.element.removeClass("ui-autocomplete-loading")},this)},__response:function(e){e&&(e=this._normalize(e)),this._trigger("response",null,{content:e}),!this.options.disabled&&e&&e.length&&!this.cancelSearch?(this._suggest(e),this._trigger("open")):this._close()},close:function(e){this.cancelSearch=!0,this._close(e)},_close:function(e){this.menu.element.is(":visible")&&(this.menu.element.hide(),this.menu.blur(),this.isNewMenu=!0,this._trigger("close",e))},_change:function(e){this.previous!==this._value()&&this._trigger("change",e,{item:this.selectedItem})},_normalize:function(t){return t.length&&t[0].label&&t[0].value?t:e.map(t,function(t){return"string"==typeof t?{label:t,value:t}:e.extend({},t,{label:t.label||t.value,value:t.value||t.label})})},_suggest:function(t){var i=this.menu.element.empty();this._renderMenu(i,t),this.isNewMenu=!0,this.menu.refresh(),i.show(),this._resizeMenu(),i.position(e.extend({of:this.element},this.options.position)),this.options.autoFocus&&this.menu.next()},_resizeMenu:function(){var e=this.menu.element;e.outerWidth(Math.max(e.width("").outerWidth()+1,this.element.outerWidth()))},_renderMenu:function(t,i){var s=this;e.each(i,function(e,i){s._renderItemData(t,i)})},_renderItemData:function(e,t){return this._renderItem(e,t).data("ui-autocomplete-item",t)},_renderItem:function(t,i){return e("<li>").text(i.label).appendTo(t)},_move:function(e,t){return this.menu.element.is(":visible")?this.menu.isFirstItem()&&/^previous/.test(e)||this.menu.isLastItem()&&/^next/.test(e)?(this.isMultiLine||this._value(this.term),this.menu.blur(),void 0):(this.menu[e](t),void 0):(this.search(null,t),void 0)},widget:function(){return this.menu.element},_value:function(){return this.valueMethod.apply(this.element,arguments)},_keyEvent:function(e,t){(!this.isMultiLine||this.menu.element.is(":visible"))&&(this._move(e,t),t.preventDefault())}}),e.extend(e.ui.autocomplete,{escapeRegex:function(e){return e.replace(/[\-\[\]{}()*+?.,\\\^$|#\s]/g,"\\$&")},filter:function(t,i){var s=RegExp(e.ui.autocomplete.escapeRegex(i),"i");return e.grep(t,function(e){return s.test(e.label||e.value||e)})}}),e.widget("ui.autocomplete",e.ui.autocomplete,{options:{messages:{noResults:"No search results.",results:function(e){return e+(e>1?" results are":" result is")+" available, use up and down arrow keys to navigate."}}},__response:function(t){var i;this._superApply(arguments),this.options.disabled||this.cancelSearch||(i=t&&t.length?this.options.messages.results(t.length):this.options.messages.noResults,this.liveRegion.children().hide(),e("<div>").text(i).appendTo(this.liveRegion))}}),e.ui.autocomplete;var c,p="ui-button ui-widget ui-state-default ui-corner-all",f="ui-button-icons-only ui-button-icon-only ui-button-text-icons ui-button-text-icon-primary ui-button-text-icon-secondary ui-button-text-only",m=function(){var t=e(this);setTimeout(function(){t.find(":ui-button").button("refresh")},1)},g=function(t){var i=t.name,s=t.form,n=e([]);return i&&(i=i.replace(/'/g,"\\'"),n=s?e(s).find("[name='"+i+"'][type=radio]"):e("[name='"+i+"'][type=radio]",t.ownerDocument).filter(function(){return!this.form})),n};e.widget("ui.button",{version:"1.11.4",defaultElement:"<button>",options:{disabled:null,text:!0,label:null,icons:{primary:null,secondary:null}},_create:function(){this.element.closest("form").unbind("reset"+this.eventNamespace).bind("reset"+this.eventNamespace,m),"boolean"!=typeof this.options.disabled?this.options.disabled=!!this.element.prop("disabled"):this.element.prop("disabled",this.options.disabled),this._determineButtonType(),this.hasTitle=!!this.buttonElement.attr("title");var t=this,i=this.options,s="checkbox"===this.type||"radio"===this.type,n=s?"":"ui-state-active";null===i.label&&(i.label="input"===this.type?this.buttonElement.val():this.buttonElement.html()),this._hoverable(this.buttonElement),this.buttonElement.addClass(p).attr("role","button").bind("mouseenter"+this.eventNamespace,function(){i.disabled||this===c&&e(this).addClass("ui-state-active")}).bind("mouseleave"+this.eventNamespace,function(){i.disabled||e(this).removeClass(n)}).bind("click"+this.eventNamespace,function(e){i.disabled&&(e.preventDefault(),e.stopImmediatePropagation())}),this._on({focus:function(){this.buttonElement.addClass("ui-state-focus")},blur:function(){this.buttonElement.removeClass("ui-state-focus")}}),s&&this.element.bind("change"+this.eventNamespace,function(){t.refresh()}),"checkbox"===this.type?this.buttonElement.bind("click"+this.eventNamespace,function(){return i.disabled?!1:void 0}):"radio"===this.type?this.buttonElement.bind("click"+this.eventNamespace,function(){if(i.disabled)return!1;e(this).addClass("ui-state-active"),t.buttonElement.attr("aria-pressed","true");var s=t.element[0];g(s).not(s).map(function(){return e(this).button("widget")[0]}).removeClass("ui-state-active").attr("aria-pressed","false")}):(this.buttonElement.bind("mousedown"+this.eventNamespace,function(){return i.disabled?!1:(e(this).addClass("ui-state-active"),c=this,t.document.one("mouseup",function(){c=null}),void 0)}).bind("mouseup"+this.eventNamespace,function(){return i.disabled?!1:(e(this).removeClass("ui-state-active"),void 0)}).bind("keydown"+this.eventNamespace,function(t){return i.disabled?!1:((t.keyCode===e.ui.keyCode.SPACE||t.keyCode===e.ui.keyCode.ENTER)&&e(this).addClass("ui-state-active"),void 0)}).bind("keyup"+this.eventNamespace+" blur"+this.eventNamespace,function(){e(this).removeClass("ui-state-active")}),this.buttonElement.is("a")&&this.buttonElement.keyup(function(t){t.keyCode===e.ui.keyCode.SPACE&&e(this).click()})),this._setOption("disabled",i.disabled),this._resetButton()},_determineButtonType:function(){var e,t,i;this.type=this.element.is("[type=checkbox]")?"checkbox":this.element.is("[type=radio]")?"radio":this.element.is("input")?"input":"button","checkbox"===this.type||"radio"===this.type?(e=this.element.parents().last(),t="label[for='"+this.element.attr("id")+"']",this.buttonElement=e.find(t),this.buttonElement.length||(e=e.length?e.siblings():this.element.siblings(),this.buttonElement=e.filter(t),this.buttonElement.length||(this.buttonElement=e.find(t))),this.element.addClass("ui-helper-hidden-accessible"),i=this.element.is(":checked"),i&&this.buttonElement.addClass("ui-state-active"),this.buttonElement.prop("aria-pressed",i)):this.buttonElement=this.element},widget:function(){return this.buttonElement},_destroy:function(){this.element.removeClass("ui-helper-hidden-accessible"),this.buttonElement.removeClass(p+" ui-state-active "+f).removeAttr("role").removeAttr("aria-pressed").html(this.buttonElement.find(".ui-button-text").html()),this.hasTitle||this.buttonElement.removeAttr("title")},_setOption:function(e,t){return this._super(e,t),"disabled"===e?(this.widget().toggleClass("ui-state-disabled",!!t),this.element.prop("disabled",!!t),t&&("checkbox"===this.type||"radio"===this.type?this.buttonElement.removeClass("ui-state-focus"):this.buttonElement.removeClass("ui-state-focus ui-state-active")),void 0):(this._resetButton(),void 0)},refresh:function(){var t=this.element.is("input, button")?this.element.is(":disabled"):this.element.hasClass("ui-button-disabled");t!==this.options.disabled&&this._setOption("disabled",t),"radio"===this.type?g(this.element[0]).each(function(){e(this).is(":checked")?e(this).button("widget").addClass("ui-state-active").attr("aria-pressed","true"):e(this).button("widget").removeClass("ui-state-active").attr("aria-pressed","false")}):"checkbox"===this.type&&(this.element.is(":checked")?this.buttonElement.addClass("ui-state-active").attr("aria-pressed","true"):this.buttonElement.removeClass("ui-state-active").attr("aria-pressed","false"))},_resetButton:function(){if("input"===this.type)return this.options.label&&this.element.val(this.options.label),void 0;var t=this.buttonElement.removeClass(f),i=e("<span></span>",this.document[0]).addClass("ui-button-text").html(this.options.label).appendTo(t.empty()).text(),s=this.options.icons,n=s.primary&&s.secondary,a=[];s.primary||s.secondary?(this.options.text&&a.push("ui-button-text-icon"+(n?"s":s.primary?"-primary":"-secondary")),s.primary&&t.prepend("<span class='ui-button-icon-primary ui-icon "+s.primary+"'></span>"),s.secondary&&t.append("<span class='ui-button-icon-secondary ui-icon "+s.secondary+"'></span>"),this.options.text||(a.push(n?"ui-button-icons-only":"ui-button-icon-only"),this.hasTitle||t.attr("title",e.trim(i)))):a.push("ui-button-text-only"),t.addClass(a.join(" "))}}),e.widget("ui.buttonset",{version:"1.11.4",options:{items:"button, input[type=button], input[type=submit], input[type=reset], input[type=checkbox], input[type=radio], a, :data(ui-button)"},_create:function(){this.element.addClass("ui-buttonset")},_init:function(){this.refresh()},_setOption:function(e,t){"disabled"===e&&this.buttons.button("option",e,t),this._super(e,t)},refresh:function(){var t="rtl"===this.element.css("direction"),i=this.element.find(this.options.items),s=i.filter(":ui-button");i.not(":ui-button").button(),s.button("refresh"),this.buttons=i.map(function(){return e(this).button("widget")[0]}).removeClass("ui-corner-all ui-corner-left ui-corner-right").filter(":first").addClass(t?"ui-corner-right":"ui-corner-left").end().filter(":last").addClass(t?"ui-corner-left":"ui-corner-right").end().end()},_destroy:function(){this.element.removeClass("ui-buttonset"),this.buttons.map(function(){return e(this).button("widget")[0]}).removeClass("ui-corner-left ui-corner-right").end().button("destroy")}}),e.ui.button,e.extend(e.ui,{datepicker:{version:"1.11.4"}});var v;e.extend(n.prototype,{markerClassName:"hasDatepicker",maxRows:4,_widgetDatepicker:function(){return this.dpDiv},setDefaults:function(e){return r(this._defaults,e||{}),this},_attachDatepicker:function(t,i){var s,n,a;s=t.nodeName.toLowerCase(),n="div"===s||"span"===s,t.id||(this.uuid+=1,t.id="dp"+this.uuid),a=this._newInst(e(t),n),a.settings=e.extend({},i||{}),"input"===s?this._connectDatepicker(t,a):n&&this._inlineDatepicker(t,a)},_newInst:function(t,i){var s=t[0].id.replace(/([^A-Za-z0-9_\-])/g,"\\\\$1");return{id:s,input:t,selectedDay:0,selectedMonth:0,selectedYear:0,drawMonth:0,drawYear:0,inline:i,dpDiv:i?a(e("<div class='"+this._inlineClass+" ui-datepicker ui-widget ui-widget-content ui-helper-clearfix ui-corner-all'></div>")):this.dpDiv}},_connectDatepicker:function(t,i){var s=e(t);i.append=e([]),i.trigger=e([]),s.hasClass(this.markerClassName)||(this._attachments(s,i),s.addClass(this.markerClassName).keydown(this._doKeyDown).keypress(this._doKeyPress).keyup(this._doKeyUp),this._autoSize(i),e.data(t,"datepicker",i),i.settings.disabled&&this._disableDatepicker(t))},_attachments:function(t,i){var s,n,a,o=this._get(i,"appendText"),r=this._get(i,"isRTL");i.append&&i.append.remove(),o&&(i.append=e("<span class='"+this._appendClass+"'>"+o+"</span>"),t[r?"before":"after"](i.append)),t.unbind("focus",this._showDatepicker),i.trigger&&i.trigger.remove(),s=this._get(i,"showOn"),("focus"===s||"both"===s)&&t.focus(this._showDatepicker),("button"===s||"both"===s)&&(n=this._get(i,"buttonText"),a=this._get(i,"buttonImage"),i.trigger=e(this._get(i,"buttonImageOnly")?e("<img/>").addClass(this._triggerClass).attr({src:a,alt:n,title:n}):e("<button type='button'></button>").addClass(this._triggerClass).html(a?e("<img/>").attr({src:a,alt:n,title:n}):n)),t[r?"before":"after"](i.trigger),i.trigger.click(function(){return e.datepicker._datepickerShowing&&e.datepicker._lastInput===t[0]?e.datepicker._hideDatepicker():e.datepicker._datepickerShowing&&e.datepicker._lastInput!==t[0]?(e.datepicker._hideDatepicker(),e.datepicker._showDatepicker(t[0])):e.datepicker._showDatepicker(t[0]),!1}))},_autoSize:function(e){if(this._get(e,"autoSize")&&!e.inline){var t,i,s,n,a=new Date(2009,11,20),o=this._get(e,"dateFormat");o.match(/[DM]/)&&(t=function(e){for(i=0,s=0,n=0;e.length>n;n++)e[n].length>i&&(i=e[n].length,s=n);return s},a.setMonth(t(this._get(e,o.match(/MM/)?"monthNames":"monthNamesShort"))),a.setDate(t(this._get(e,o.match(/DD/)?"dayNames":"dayNamesShort"))+20-a.getDay())),e.input.attr("size",this._formatDate(e,a).length)}},_inlineDatepicker:function(t,i){var s=e(t);s.hasClass(this.markerClassName)||(s.addClass(this.markerClassName).append(i.dpDiv),e.data(t,"datepicker",i),this._setDate(i,this._getDefaultDate(i),!0),this._updateDatepicker(i),this._updateAlternate(i),i.settings.disabled&&this._disableDatepicker(t),i.dpDiv.css("display","block"))},_dialogDatepicker:function(t,i,s,n,a){var o,h,l,u,d,c=this._dialogInst;return c||(this.uuid+=1,o="dp"+this.uuid,this._dialogInput=e("<input type='text' id='"+o+"' style='position: absolute; top: -100px; width: 0px;'/>"),this._dialogInput.keydown(this._doKeyDown),e("body").append(this._dialogInput),c=this._dialogInst=this._newInst(this._dialogInput,!1),c.settings={},e.data(this._dialogInput[0],"datepicker",c)),r(c.settings,n||{}),i=i&&i.constructor===Date?this._formatDate(c,i):i,this._dialogInput.val(i),this._pos=a?a.length?a:[a.pageX,a.pageY]:null,this._pos||(h=document.documentElement.clientWidth,l=document.documentElement.clientHeight,u=document.documentElement.scrollLeft||document.body.scrollLeft,d=document.documentElement.scrollTop||document.body.scrollTop,this._pos=[h/2-100+u,l/2-150+d]),this._dialogInput.css("left",this._pos[0]+20+"px").css("top",this._pos[1]+"px"),c.settings.onSelect=s,this._inDialog=!0,this.dpDiv.addClass(this._dialogClass),this._showDatepicker(this._dialogInput[0]),e.blockUI&&e.blockUI(this.dpDiv),e.data(this._dialogInput[0],"datepicker",c),this},_destroyDatepicker:function(t){var i,s=e(t),n=e.data(t,"datepicker");s.hasClass(this.markerClassName)&&(i=t.nodeName.toLowerCase(),e.removeData(t,"datepicker"),"input"===i?(n.append.remove(),n.trigger.remove(),s.removeClass(this.markerClassName).unbind("focus",this._showDatepicker).unbind("keydown",this._doKeyDown).unbind("keypress",this._doKeyPress).unbind("keyup",this._doKeyUp)):("div"===i||"span"===i)&&s.removeClass(this.markerClassName).empty(),v===n&&(v=null))},_enableDatepicker:function(t){var i,s,n=e(t),a=e.data(t,"datepicker");n.hasClass(this.markerClassName)&&(i=t.nodeName.toLowerCase(),"input"===i?(t.disabled=!1,a.trigger.filter("button").each(function(){this.disabled=!1}).end().filter("img").css({opacity:"1.0",cursor:""})):("div"===i||"span"===i)&&(s=n.children("."+this._inlineClass),s.children().removeClass("ui-state-disabled"),s.find("select.ui-datepicker-month, select.ui-datepicker-year").prop("disabled",!1)),this._disabledInputs=e.map(this._disabledInputs,function(e){return e===t?null:e}))},_disableDatepicker:function(t){var i,s,n=e(t),a=e.data(t,"datepicker");n.hasClass(this.markerClassName)&&(i=t.nodeName.toLowerCase(),"input"===i?(t.disabled=!0,a.trigger.filter("button").each(function(){this.disabled=!0}).end().filter("img").css({opacity:"0.5",cursor:"default"})):("div"===i||"span"===i)&&(s=n.children("."+this._inlineClass),s.children().addClass("ui-state-disabled"),s.find("select.ui-datepicker-month, select.ui-datepicker-year").prop("disabled",!0)),this._disabledInputs=e.map(this._disabledInputs,function(e){return e===t?null:e}),this._disabledInputs[this._disabledInputs.length]=t)},_isDisabledDatepicker:function(e){if(!e)return!1;for(var t=0;this._disabledInputs.length>t;t++)if(this._disabledInputs[t]===e)return!0;return!1},_getInst:function(t){try{return e.data(t,"datepicker")}catch(i){throw"Missing instance data for this datepicker"}},_optionDatepicker:function(t,i,s){var n,a,o,h,l=this._getInst(t);return 2===arguments.length&&"string"==typeof i?"defaults"===i?e.extend({},e.datepicker._defaults):l?"all"===i?e.extend({},l.settings):this._get(l,i):null:(n=i||{},"string"==typeof i&&(n={},n[i]=s),l&&(this._curInst===l&&this._hideDatepicker(),a=this._getDateDatepicker(t,!0),o=this._getMinMaxDate(l,"min"),h=this._getMinMaxDate(l,"max"),r(l.settings,n),null!==o&&void 0!==n.dateFormat&&void 0===n.minDate&&(l.settings.minDate=this._formatDate(l,o)),null!==h&&void 0!==n.dateFormat&&void 0===n.maxDate&&(l.settings.maxDate=this._formatDate(l,h)),"disabled"in n&&(n.disabled?this._disableDatepicker(t):this._enableDatepicker(t)),this._attachments(e(t),l),this._autoSize(l),this._setDate(l,a),this._updateAlternate(l),this._updateDatepicker(l)),void 0)},_changeDatepicker:function(e,t,i){this._optionDatepicker(e,t,i)},_refreshDatepicker:function(e){var t=this._getInst(e);t&&this._updateDatepicker(t)},_setDateDatepicker:function(e,t){var i=this._getInst(e);i&&(this._setDate(i,t),this._updateDatepicker(i),this._updateAlternate(i))},_getDateDatepicker:function(e,t){var i=this._getInst(e);return i&&!i.inline&&this._setDateFromField(i,t),i?this._getDate(i):null},_doKeyDown:function(t){var i,s,n,a=e.datepicker._getInst(t.target),o=!0,r=a.dpDiv.is(".ui-datepicker-rtl");if(a._keyEvent=!0,e.datepicker._datepickerShowing)switch(t.keyCode){case 9:e.datepicker._hideDatepicker(),o=!1;break;case 13:return n=e("td."+e.datepicker._dayOverClass+":not(."+e.datepicker._currentClass+")",a.dpDiv),n[0]&&e.datepicker._selectDay(t.target,a.selectedMonth,a.selectedYear,n[0]),i=e.datepicker._get(a,"onSelect"),i?(s=e.datepicker._formatDate(a),i.apply(a.input?a.input[0]:null,[s,a])):e.datepicker._hideDatepicker(),!1;case 27:e.datepicker._hideDatepicker();break;case 33:e.datepicker._adjustDate(t.target,t.ctrlKey?-e.datepicker._get(a,"stepBigMonths"):-e.datepicker._get(a,"stepMonths"),"M");break;case 34:e.datepicker._adjustDate(t.target,t.ctrlKey?+e.datepicker._get(a,"stepBigMonths"):+e.datepicker._get(a,"stepMonths"),"M");break;case 35:(t.ctrlKey||t.metaKey)&&e.datepicker._clearDate(t.target),o=t.ctrlKey||t.metaKey;break;case 36:(t.ctrlKey||t.metaKey)&&e.datepicker._gotoToday(t.target),o=t.ctrlKey||t.metaKey;break;case 37:(t.ctrlKey||t.metaKey)&&e.datepicker._adjustDate(t.target,r?1:-1,"D"),o=t.ctrlKey||t.metaKey,t.originalEvent.altKey&&e.datepicker._adjustDate(t.target,t.ctrlKey?-e.datepicker._get(a,"stepBigMonths"):-e.datepicker._get(a,"stepMonths"),"M");break;case 38:(t.ctrlKey||t.metaKey)&&e.datepicker._adjustDate(t.target,-7,"D"),o=t.ctrlKey||t.metaKey;break;case 39:(t.ctrlKey||t.metaKey)&&e.datepicker._adjustDate(t.target,r?-1:1,"D"),o=t.ctrlKey||t.metaKey,t.originalEvent.altKey&&e.datepicker._adjustDate(t.target,t.ctrlKey?+e.datepicker._get(a,"stepBigMonths"):+e.datepicker._get(a,"stepMonths"),"M");break;case 40:(t.ctrlKey||t.metaKey)&&e.datepicker._adjustDate(t.target,7,"D"),o=t.ctrlKey||t.metaKey;break;default:o=!1}else 36===t.keyCode&&t.ctrlKey?e.datepicker._showDatepicker(this):o=!1;o&&(t.preventDefault(),t.stopPropagation())},_doKeyPress:function(t){var i,s,n=e.datepicker._getInst(t.target);
return e.datepicker._get(n,"constrainInput")?(i=e.datepicker._possibleChars(e.datepicker._get(n,"dateFormat")),s=String.fromCharCode(null==t.charCode?t.keyCode:t.charCode),t.ctrlKey||t.metaKey||" ">s||!i||i.indexOf(s)>-1):void 0},_doKeyUp:function(t){var i,s=e.datepicker._getInst(t.target);if(s.input.val()!==s.lastVal)try{i=e.datepicker.parseDate(e.datepicker._get(s,"dateFormat"),s.input?s.input.val():null,e.datepicker._getFormatConfig(s)),i&&(e.datepicker._setDateFromField(s),e.datepicker._updateAlternate(s),e.datepicker._updateDatepicker(s))}catch(n){}return!0},_showDatepicker:function(t){if(t=t.target||t,"input"!==t.nodeName.toLowerCase()&&(t=e("input",t.parentNode)[0]),!e.datepicker._isDisabledDatepicker(t)&&e.datepicker._lastInput!==t){var i,n,a,o,h,l,u;i=e.datepicker._getInst(t),e.datepicker._curInst&&e.datepicker._curInst!==i&&(e.datepicker._curInst.dpDiv.stop(!0,!0),i&&e.datepicker._datepickerShowing&&e.datepicker._hideDatepicker(e.datepicker._curInst.input[0])),n=e.datepicker._get(i,"beforeShow"),a=n?n.apply(t,[t,i]):{},a!==!1&&(r(i.settings,a),i.lastVal=null,e.datepicker._lastInput=t,e.datepicker._setDateFromField(i),e.datepicker._inDialog&&(t.value=""),e.datepicker._pos||(e.datepicker._pos=e.datepicker._findPos(t),e.datepicker._pos[1]+=t.offsetHeight),o=!1,e(t).parents().each(function(){return o|="fixed"===e(this).css("position"),!o}),h={left:e.datepicker._pos[0],top:e.datepicker._pos[1]},e.datepicker._pos=null,i.dpDiv.empty(),i.dpDiv.css({position:"absolute",display:"block",top:"-1000px"}),e.datepicker._updateDatepicker(i),h=e.datepicker._checkOffset(i,h,o),i.dpDiv.css({position:e.datepicker._inDialog&&e.blockUI?"static":o?"fixed":"absolute",display:"none",left:h.left+"px",top:h.top+"px"}),i.inline||(l=e.datepicker._get(i,"showAnim"),u=e.datepicker._get(i,"duration"),i.dpDiv.css("z-index",s(e(t))+1),e.datepicker._datepickerShowing=!0,e.effects&&e.effects.effect[l]?i.dpDiv.show(l,e.datepicker._get(i,"showOptions"),u):i.dpDiv[l||"show"](l?u:null),e.datepicker._shouldFocusInput(i)&&i.input.focus(),e.datepicker._curInst=i))}},_updateDatepicker:function(t){this.maxRows=4,v=t,t.dpDiv.empty().append(this._generateHTML(t)),this._attachHandlers(t);var i,s=this._getNumberOfMonths(t),n=s[1],a=17,r=t.dpDiv.find("."+this._dayOverClass+" a");r.length>0&&o.apply(r.get(0)),t.dpDiv.removeClass("ui-datepicker-multi-2 ui-datepicker-multi-3 ui-datepicker-multi-4").width(""),n>1&&t.dpDiv.addClass("ui-datepicker-multi-"+n).css("width",a*n+"em"),t.dpDiv[(1!==s[0]||1!==s[1]?"add":"remove")+"Class"]("ui-datepicker-multi"),t.dpDiv[(this._get(t,"isRTL")?"add":"remove")+"Class"]("ui-datepicker-rtl"),t===e.datepicker._curInst&&e.datepicker._datepickerShowing&&e.datepicker._shouldFocusInput(t)&&t.input.focus(),t.yearshtml&&(i=t.yearshtml,setTimeout(function(){i===t.yearshtml&&t.yearshtml&&t.dpDiv.find("select.ui-datepicker-year:first").replaceWith(t.yearshtml),i=t.yearshtml=null},0))},_shouldFocusInput:function(e){return e.input&&e.input.is(":visible")&&!e.input.is(":disabled")&&!e.input.is(":focus")},_checkOffset:function(t,i,s){var n=t.dpDiv.outerWidth(),a=t.dpDiv.outerHeight(),o=t.input?t.input.outerWidth():0,r=t.input?t.input.outerHeight():0,h=document.documentElement.clientWidth+(s?0:e(document).scrollLeft()),l=document.documentElement.clientHeight+(s?0:e(document).scrollTop());return i.left-=this._get(t,"isRTL")?n-o:0,i.left-=s&&i.left===t.input.offset().left?e(document).scrollLeft():0,i.top-=s&&i.top===t.input.offset().top+r?e(document).scrollTop():0,i.left-=Math.min(i.left,i.left+n>h&&h>n?Math.abs(i.left+n-h):0),i.top-=Math.min(i.top,i.top+a>l&&l>a?Math.abs(a+r):0),i},_findPos:function(t){for(var i,s=this._getInst(t),n=this._get(s,"isRTL");t&&("hidden"===t.type||1!==t.nodeType||e.expr.filters.hidden(t));)t=t[n?"previousSibling":"nextSibling"];return i=e(t).offset(),[i.left,i.top]},_hideDatepicker:function(t){var i,s,n,a,o=this._curInst;!o||t&&o!==e.data(t,"datepicker")||this._datepickerShowing&&(i=this._get(o,"showAnim"),s=this._get(o,"duration"),n=function(){e.datepicker._tidyDialog(o)},e.effects&&(e.effects.effect[i]||e.effects[i])?o.dpDiv.hide(i,e.datepicker._get(o,"showOptions"),s,n):o.dpDiv["slideDown"===i?"slideUp":"fadeIn"===i?"fadeOut":"hide"](i?s:null,n),i||n(),this._datepickerShowing=!1,a=this._get(o,"onClose"),a&&a.apply(o.input?o.input[0]:null,[o.input?o.input.val():"",o]),this._lastInput=null,this._inDialog&&(this._dialogInput.css({position:"absolute",left:"0",top:"-100px"}),e.blockUI&&(e.unblockUI(),e("body").append(this.dpDiv))),this._inDialog=!1)},_tidyDialog:function(e){e.dpDiv.removeClass(this._dialogClass).unbind(".ui-datepicker-calendar")},_checkExternalClick:function(t){if(e.datepicker._curInst){var i=e(t.target),s=e.datepicker._getInst(i[0]);(i[0].id!==e.datepicker._mainDivId&&0===i.parents("#"+e.datepicker._mainDivId).length&&!i.hasClass(e.datepicker.markerClassName)&&!i.closest("."+e.datepicker._triggerClass).length&&e.datepicker._datepickerShowing&&(!e.datepicker._inDialog||!e.blockUI)||i.hasClass(e.datepicker.markerClassName)&&e.datepicker._curInst!==s)&&e.datepicker._hideDatepicker()}},_adjustDate:function(t,i,s){var n=e(t),a=this._getInst(n[0]);this._isDisabledDatepicker(n[0])||(this._adjustInstDate(a,i+("M"===s?this._get(a,"showCurrentAtPos"):0),s),this._updateDatepicker(a))},_gotoToday:function(t){var i,s=e(t),n=this._getInst(s[0]);this._get(n,"gotoCurrent")&&n.currentDay?(n.selectedDay=n.currentDay,n.drawMonth=n.selectedMonth=n.currentMonth,n.drawYear=n.selectedYear=n.currentYear):(i=new Date,n.selectedDay=i.getDate(),n.drawMonth=n.selectedMonth=i.getMonth(),n.drawYear=n.selectedYear=i.getFullYear()),this._notifyChange(n),this._adjustDate(s)},_selectMonthYear:function(t,i,s){var n=e(t),a=this._getInst(n[0]);a["selected"+("M"===s?"Month":"Year")]=a["draw"+("M"===s?"Month":"Year")]=parseInt(i.options[i.selectedIndex].value,10),this._notifyChange(a),this._adjustDate(n)},_selectDay:function(t,i,s,n){var a,o=e(t);e(n).hasClass(this._unselectableClass)||this._isDisabledDatepicker(o[0])||(a=this._getInst(o[0]),a.selectedDay=a.currentDay=e("a",n).html(),a.selectedMonth=a.currentMonth=i,a.selectedYear=a.currentYear=s,this._selectDate(t,this._formatDate(a,a.currentDay,a.currentMonth,a.currentYear)))},_clearDate:function(t){var i=e(t);this._selectDate(i,"")},_selectDate:function(t,i){var s,n=e(t),a=this._getInst(n[0]);i=null!=i?i:this._formatDate(a),a.input&&a.input.val(i),this._updateAlternate(a),s=this._get(a,"onSelect"),s?s.apply(a.input?a.input[0]:null,[i,a]):a.input&&a.input.trigger("change"),a.inline?this._updateDatepicker(a):(this._hideDatepicker(),this._lastInput=a.input[0],"object"!=typeof a.input[0]&&a.input.focus(),this._lastInput=null)},_updateAlternate:function(t){var i,s,n,a=this._get(t,"altField");a&&(i=this._get(t,"altFormat")||this._get(t,"dateFormat"),s=this._getDate(t),n=this.formatDate(i,s,this._getFormatConfig(t)),e(a).each(function(){e(this).val(n)}))},noWeekends:function(e){var t=e.getDay();return[t>0&&6>t,""]},iso8601Week:function(e){var t,i=new Date(e.getTime());return i.setDate(i.getDate()+4-(i.getDay()||7)),t=i.getTime(),i.setMonth(0),i.setDate(1),Math.floor(Math.round((t-i)/864e5)/7)+1},parseDate:function(t,i,s){if(null==t||null==i)throw"Invalid arguments";if(i="object"==typeof i?""+i:i+"",""===i)return null;var n,a,o,r,h=0,l=(s?s.shortYearCutoff:null)||this._defaults.shortYearCutoff,u="string"!=typeof l?l:(new Date).getFullYear()%100+parseInt(l,10),d=(s?s.dayNamesShort:null)||this._defaults.dayNamesShort,c=(s?s.dayNames:null)||this._defaults.dayNames,p=(s?s.monthNamesShort:null)||this._defaults.monthNamesShort,f=(s?s.monthNames:null)||this._defaults.monthNames,m=-1,g=-1,v=-1,y=-1,b=!1,_=function(e){var i=t.length>n+1&&t.charAt(n+1)===e;return i&&n++,i},x=function(e){var t=_(e),s="@"===e?14:"!"===e?20:"y"===e&&t?4:"o"===e?3:2,n="y"===e?s:1,a=RegExp("^\\d{"+n+","+s+"}"),o=i.substring(h).match(a);if(!o)throw"Missing number at position "+h;return h+=o[0].length,parseInt(o[0],10)},w=function(t,s,n){var a=-1,o=e.map(_(t)?n:s,function(e,t){return[[t,e]]}).sort(function(e,t){return-(e[1].length-t[1].length)});if(e.each(o,function(e,t){var s=t[1];return i.substr(h,s.length).toLowerCase()===s.toLowerCase()?(a=t[0],h+=s.length,!1):void 0}),-1!==a)return a+1;throw"Unknown name at position "+h},k=function(){if(i.charAt(h)!==t.charAt(n))throw"Unexpected literal at position "+h;h++};for(n=0;t.length>n;n++)if(b)"'"!==t.charAt(n)||_("'")?k():b=!1;else switch(t.charAt(n)){case"d":v=x("d");break;case"D":w("D",d,c);break;case"o":y=x("o");break;case"m":g=x("m");break;case"M":g=w("M",p,f);break;case"y":m=x("y");break;case"@":r=new Date(x("@")),m=r.getFullYear(),g=r.getMonth()+1,v=r.getDate();break;case"!":r=new Date((x("!")-this._ticksTo1970)/1e4),m=r.getFullYear(),g=r.getMonth()+1,v=r.getDate();break;case"'":_("'")?k():b=!0;break;default:k()}if(i.length>h&&(o=i.substr(h),!/^\s+/.test(o)))throw"Extra/unparsed characters found in date: "+o;if(-1===m?m=(new Date).getFullYear():100>m&&(m+=(new Date).getFullYear()-(new Date).getFullYear()%100+(u>=m?0:-100)),y>-1)for(g=1,v=y;;){if(a=this._getDaysInMonth(m,g-1),a>=v)break;g++,v-=a}if(r=this._daylightSavingAdjust(new Date(m,g-1,v)),r.getFullYear()!==m||r.getMonth()+1!==g||r.getDate()!==v)throw"Invalid date";return r},ATOM:"yy-mm-dd",COOKIE:"D, dd M yy",ISO_8601:"yy-mm-dd",RFC_822:"D, d M y",RFC_850:"DD, dd-M-y",RFC_1036:"D, d M y",RFC_1123:"D, d M yy",RFC_2822:"D, d M yy",RSS:"D, d M y",TICKS:"!",TIMESTAMP:"@",W3C:"yy-mm-dd",_ticksTo1970:1e7*60*60*24*(718685+Math.floor(492.5)-Math.floor(19.7)+Math.floor(4.925)),formatDate:function(e,t,i){if(!t)return"";var s,n=(i?i.dayNamesShort:null)||this._defaults.dayNamesShort,a=(i?i.dayNames:null)||this._defaults.dayNames,o=(i?i.monthNamesShort:null)||this._defaults.monthNamesShort,r=(i?i.monthNames:null)||this._defaults.monthNames,h=function(t){var i=e.length>s+1&&e.charAt(s+1)===t;return i&&s++,i},l=function(e,t,i){var s=""+t;if(h(e))for(;i>s.length;)s="0"+s;return s},u=function(e,t,i,s){return h(e)?s[t]:i[t]},d="",c=!1;if(t)for(s=0;e.length>s;s++)if(c)"'"!==e.charAt(s)||h("'")?d+=e.charAt(s):c=!1;else switch(e.charAt(s)){case"d":d+=l("d",t.getDate(),2);break;case"D":d+=u("D",t.getDay(),n,a);break;case"o":d+=l("o",Math.round((new Date(t.getFullYear(),t.getMonth(),t.getDate()).getTime()-new Date(t.getFullYear(),0,0).getTime())/864e5),3);break;case"m":d+=l("m",t.getMonth()+1,2);break;case"M":d+=u("M",t.getMonth(),o,r);break;case"y":d+=h("y")?t.getFullYear():(10>t.getYear()%100?"0":"")+t.getYear()%100;break;case"@":d+=t.getTime();break;case"!":d+=1e4*t.getTime()+this._ticksTo1970;break;case"'":h("'")?d+="'":c=!0;break;default:d+=e.charAt(s)}return d},_possibleChars:function(e){var t,i="",s=!1,n=function(i){var s=e.length>t+1&&e.charAt(t+1)===i;return s&&t++,s};for(t=0;e.length>t;t++)if(s)"'"!==e.charAt(t)||n("'")?i+=e.charAt(t):s=!1;else switch(e.charAt(t)){case"d":case"m":case"y":case"@":i+="0123456789";break;case"D":case"M":return null;case"'":n("'")?i+="'":s=!0;break;default:i+=e.charAt(t)}return i},_get:function(e,t){return void 0!==e.settings[t]?e.settings[t]:this._defaults[t]},_setDateFromField:function(e,t){if(e.input.val()!==e.lastVal){var i=this._get(e,"dateFormat"),s=e.lastVal=e.input?e.input.val():null,n=this._getDefaultDate(e),a=n,o=this._getFormatConfig(e);try{a=this.parseDate(i,s,o)||n}catch(r){s=t?"":s}e.selectedDay=a.getDate(),e.drawMonth=e.selectedMonth=a.getMonth(),e.drawYear=e.selectedYear=a.getFullYear(),e.currentDay=s?a.getDate():0,e.currentMonth=s?a.getMonth():0,e.currentYear=s?a.getFullYear():0,this._adjustInstDate(e)}},_getDefaultDate:function(e){return this._restrictMinMax(e,this._determineDate(e,this._get(e,"defaultDate"),new Date))},_determineDate:function(t,i,s){var n=function(e){var t=new Date;return t.setDate(t.getDate()+e),t},a=function(i){try{return e.datepicker.parseDate(e.datepicker._get(t,"dateFormat"),i,e.datepicker._getFormatConfig(t))}catch(s){}for(var n=(i.toLowerCase().match(/^c/)?e.datepicker._getDate(t):null)||new Date,a=n.getFullYear(),o=n.getMonth(),r=n.getDate(),h=/([+\-]?[0-9]+)\s*(d|D|w|W|m|M|y|Y)?/g,l=h.exec(i);l;){switch(l[2]||"d"){case"d":case"D":r+=parseInt(l[1],10);break;case"w":case"W":r+=7*parseInt(l[1],10);break;case"m":case"M":o+=parseInt(l[1],10),r=Math.min(r,e.datepicker._getDaysInMonth(a,o));break;case"y":case"Y":a+=parseInt(l[1],10),r=Math.min(r,e.datepicker._getDaysInMonth(a,o))}l=h.exec(i)}return new Date(a,o,r)},o=null==i||""===i?s:"string"==typeof i?a(i):"number"==typeof i?isNaN(i)?s:n(i):new Date(i.getTime());return o=o&&"Invalid Date"==""+o?s:o,o&&(o.setHours(0),o.setMinutes(0),o.setSeconds(0),o.setMilliseconds(0)),this._daylightSavingAdjust(o)},_daylightSavingAdjust:function(e){return e?(e.setHours(e.getHours()>12?e.getHours()+2:0),e):null},_setDate:function(e,t,i){var s=!t,n=e.selectedMonth,a=e.selectedYear,o=this._restrictMinMax(e,this._determineDate(e,t,new Date));e.selectedDay=e.currentDay=o.getDate(),e.drawMonth=e.selectedMonth=e.currentMonth=o.getMonth(),e.drawYear=e.selectedYear=e.currentYear=o.getFullYear(),n===e.selectedMonth&&a===e.selectedYear||i||this._notifyChange(e),this._adjustInstDate(e),e.input&&e.input.val(s?"":this._formatDate(e))},_getDate:function(e){var t=!e.currentYear||e.input&&""===e.input.val()?null:this._daylightSavingAdjust(new Date(e.currentYear,e.currentMonth,e.currentDay));return t},_attachHandlers:function(t){var i=this._get(t,"stepMonths"),s="#"+t.id.replace(/\\\\/g,"\\");t.dpDiv.find("[data-handler]").map(function(){var t={prev:function(){e.datepicker._adjustDate(s,-i,"M")},next:function(){e.datepicker._adjustDate(s,+i,"M")},hide:function(){e.datepicker._hideDatepicker()},today:function(){e.datepicker._gotoToday(s)},selectDay:function(){return e.datepicker._selectDay(s,+this.getAttribute("data-month"),+this.getAttribute("data-year"),this),!1},selectMonth:function(){return e.datepicker._selectMonthYear(s,this,"M"),!1},selectYear:function(){return e.datepicker._selectMonthYear(s,this,"Y"),!1}};e(this).bind(this.getAttribute("data-event"),t[this.getAttribute("data-handler")])})},_generateHTML:function(e){var t,i,s,n,a,o,r,h,l,u,d,c,p,f,m,g,v,y,b,_,x,w,k,T,D,S,M,C,N,A,P,I,H,z,F,E,O,j,W,L=new Date,R=this._daylightSavingAdjust(new Date(L.getFullYear(),L.getMonth(),L.getDate())),Y=this._get(e,"isRTL"),B=this._get(e,"showButtonPanel"),J=this._get(e,"hideIfNoPrevNext"),q=this._get(e,"navigationAsDateFormat"),K=this._getNumberOfMonths(e),V=this._get(e,"showCurrentAtPos"),U=this._get(e,"stepMonths"),Q=1!==K[0]||1!==K[1],G=this._daylightSavingAdjust(e.currentDay?new Date(e.currentYear,e.currentMonth,e.currentDay):new Date(9999,9,9)),X=this._getMinMaxDate(e,"min"),$=this._getMinMaxDate(e,"max"),Z=e.drawMonth-V,et=e.drawYear;if(0>Z&&(Z+=12,et--),$)for(t=this._daylightSavingAdjust(new Date($.getFullYear(),$.getMonth()-K[0]*K[1]+1,$.getDate())),t=X&&X>t?X:t;this._daylightSavingAdjust(new Date(et,Z,1))>t;)Z--,0>Z&&(Z=11,et--);for(e.drawMonth=Z,e.drawYear=et,i=this._get(e,"prevText"),i=q?this.formatDate(i,this._daylightSavingAdjust(new Date(et,Z-U,1)),this._getFormatConfig(e)):i,s=this._canAdjustMonth(e,-1,et,Z)?"<a class='ui-datepicker-prev ui-corner-all' data-handler='prev' data-event='click' title='"+i+"'><span class='ui-icon ui-icon-circle-triangle-"+(Y?"e":"w")+"'>"+i+"</span></a>":J?"":"<a class='ui-datepicker-prev ui-corner-all ui-state-disabled' title='"+i+"'><span class='ui-icon ui-icon-circle-triangle-"+(Y?"e":"w")+"'>"+i+"</span></a>",n=this._get(e,"nextText"),n=q?this.formatDate(n,this._daylightSavingAdjust(new Date(et,Z+U,1)),this._getFormatConfig(e)):n,a=this._canAdjustMonth(e,1,et,Z)?"<a class='ui-datepicker-next ui-corner-all' data-handler='next' data-event='click' title='"+n+"'><span class='ui-icon ui-icon-circle-triangle-"+(Y?"w":"e")+"'>"+n+"</span></a>":J?"":"<a class='ui-datepicker-next ui-corner-all ui-state-disabled' title='"+n+"'><span class='ui-icon ui-icon-circle-triangle-"+(Y?"w":"e")+"'>"+n+"</span></a>",o=this._get(e,"currentText"),r=this._get(e,"gotoCurrent")&&e.currentDay?G:R,o=q?this.formatDate(o,r,this._getFormatConfig(e)):o,h=e.inline?"":"<button type='button' class='ui-datepicker-close ui-state-default ui-priority-primary ui-corner-all' data-handler='hide' data-event='click'>"+this._get(e,"closeText")+"</button>",l=B?"<div class='ui-datepicker-buttonpane ui-widget-content'>"+(Y?h:"")+(this._isInRange(e,r)?"<button type='button' class='ui-datepicker-current ui-state-default ui-priority-secondary ui-corner-all' data-handler='today' data-event='click'>"+o+"</button>":"")+(Y?"":h)+"</div>":"",u=parseInt(this._get(e,"firstDay"),10),u=isNaN(u)?0:u,d=this._get(e,"showWeek"),c=this._get(e,"dayNames"),p=this._get(e,"dayNamesMin"),f=this._get(e,"monthNames"),m=this._get(e,"monthNamesShort"),g=this._get(e,"beforeShowDay"),v=this._get(e,"showOtherMonths"),y=this._get(e,"selectOtherMonths"),b=this._getDefaultDate(e),_="",w=0;K[0]>w;w++){for(k="",this.maxRows=4,T=0;K[1]>T;T++){if(D=this._daylightSavingAdjust(new Date(et,Z,e.selectedDay)),S=" ui-corner-all",M="",Q){if(M+="<div class='ui-datepicker-group",K[1]>1)switch(T){case 0:M+=" ui-datepicker-group-first",S=" ui-corner-"+(Y?"right":"left");break;case K[1]-1:M+=" ui-datepicker-group-last",S=" ui-corner-"+(Y?"left":"right");break;default:M+=" ui-datepicker-group-middle",S=""}M+="'>"}for(M+="<div class='ui-datepicker-header ui-widget-header ui-helper-clearfix"+S+"'>"+(/all|left/.test(S)&&0===w?Y?a:s:"")+(/all|right/.test(S)&&0===w?Y?s:a:"")+this._generateMonthYearHeader(e,Z,et,X,$,w>0||T>0,f,m)+"</div><table class='ui-datepicker-calendar'><thead>"+"<tr>",C=d?"<th class='ui-datepicker-week-col'>"+this._get(e,"weekHeader")+"</th>":"",x=0;7>x;x++)N=(x+u)%7,C+="<th scope='col'"+((x+u+6)%7>=5?" class='ui-datepicker-week-end'":"")+">"+"<span title='"+c[N]+"'>"+p[N]+"</span></th>";for(M+=C+"</tr></thead><tbody>",A=this._getDaysInMonth(et,Z),et===e.selectedYear&&Z===e.selectedMonth&&(e.selectedDay=Math.min(e.selectedDay,A)),P=(this._getFirstDayOfMonth(et,Z)-u+7)%7,I=Math.ceil((P+A)/7),H=Q?this.maxRows>I?this.maxRows:I:I,this.maxRows=H,z=this._daylightSavingAdjust(new Date(et,Z,1-P)),F=0;H>F;F++){for(M+="<tr>",E=d?"<td class='ui-datepicker-week-col'>"+this._get(e,"calculateWeek")(z)+"</td>":"",x=0;7>x;x++)O=g?g.apply(e.input?e.input[0]:null,[z]):[!0,""],j=z.getMonth()!==Z,W=j&&!y||!O[0]||X&&X>z||$&&z>$,E+="<td class='"+((x+u+6)%7>=5?" ui-datepicker-week-end":"")+(j?" ui-datepicker-other-month":"")+(z.getTime()===D.getTime()&&Z===e.selectedMonth&&e._keyEvent||b.getTime()===z.getTime()&&b.getTime()===D.getTime()?" "+this._dayOverClass:"")+(W?" "+this._unselectableClass+" ui-state-disabled":"")+(j&&!v?"":" "+O[1]+(z.getTime()===G.getTime()?" "+this._currentClass:"")+(z.getTime()===R.getTime()?" ui-datepicker-today":""))+"'"+(j&&!v||!O[2]?"":" title='"+O[2].replace(/'/g,"&#39;")+"'")+(W?"":" data-handler='selectDay' data-event='click' data-month='"+z.getMonth()+"' data-year='"+z.getFullYear()+"'")+">"+(j&&!v?"&#xa0;":W?"<span class='ui-state-default'>"+z.getDate()+"</span>":"<a class='ui-state-default"+(z.getTime()===R.getTime()?" ui-state-highlight":"")+(z.getTime()===G.getTime()?" ui-state-active":"")+(j?" ui-priority-secondary":"")+"' href='#'>"+z.getDate()+"</a>")+"</td>",z.setDate(z.getDate()+1),z=this._daylightSavingAdjust(z);M+=E+"</tr>"}Z++,Z>11&&(Z=0,et++),M+="</tbody></table>"+(Q?"</div>"+(K[0]>0&&T===K[1]-1?"<div class='ui-datepicker-row-break'></div>":""):""),k+=M}_+=k}return _+=l,e._keyEvent=!1,_},_generateMonthYearHeader:function(e,t,i,s,n,a,o,r){var h,l,u,d,c,p,f,m,g=this._get(e,"changeMonth"),v=this._get(e,"changeYear"),y=this._get(e,"showMonthAfterYear"),b="<div class='ui-datepicker-title'>",_="";if(a||!g)_+="<span class='ui-datepicker-month'>"+o[t]+"</span>";else{for(h=s&&s.getFullYear()===i,l=n&&n.getFullYear()===i,_+="<select class='ui-datepicker-month' data-handler='selectMonth' data-event='change'>",u=0;12>u;u++)(!h||u>=s.getMonth())&&(!l||n.getMonth()>=u)&&(_+="<option value='"+u+"'"+(u===t?" selected='selected'":"")+">"+r[u]+"</option>");_+="</select>"}if(y||(b+=_+(!a&&g&&v?"":"&#xa0;")),!e.yearshtml)if(e.yearshtml="",a||!v)b+="<span class='ui-datepicker-year'>"+i+"</span>";else{for(d=this._get(e,"yearRange").split(":"),c=(new Date).getFullYear(),p=function(e){var t=e.match(/c[+\-].*/)?i+parseInt(e.substring(1),10):e.match(/[+\-].*/)?c+parseInt(e,10):parseInt(e,10);return isNaN(t)?c:t},f=p(d[0]),m=Math.max(f,p(d[1]||"")),f=s?Math.max(f,s.getFullYear()):f,m=n?Math.min(m,n.getFullYear()):m,e.yearshtml+="<select class='ui-datepicker-year' data-handler='selectYear' data-event='change'>";m>=f;f++)e.yearshtml+="<option value='"+f+"'"+(f===i?" selected='selected'":"")+">"+f+"</option>";e.yearshtml+="</select>",b+=e.yearshtml,e.yearshtml=null}return b+=this._get(e,"yearSuffix"),y&&(b+=(!a&&g&&v?"":"&#xa0;")+_),b+="</div>"},_adjustInstDate:function(e,t,i){var s=e.drawYear+("Y"===i?t:0),n=e.drawMonth+("M"===i?t:0),a=Math.min(e.selectedDay,this._getDaysInMonth(s,n))+("D"===i?t:0),o=this._restrictMinMax(e,this._daylightSavingAdjust(new Date(s,n,a)));e.selectedDay=o.getDate(),e.drawMonth=e.selectedMonth=o.getMonth(),e.drawYear=e.selectedYear=o.getFullYear(),("M"===i||"Y"===i)&&this._notifyChange(e)},_restrictMinMax:function(e,t){var i=this._getMinMaxDate(e,"min"),s=this._getMinMaxDate(e,"max"),n=i&&i>t?i:t;return s&&n>s?s:n},_notifyChange:function(e){var t=this._get(e,"onChangeMonthYear");t&&t.apply(e.input?e.input[0]:null,[e.selectedYear,e.selectedMonth+1,e])},_getNumberOfMonths:function(e){var t=this._get(e,"numberOfMonths");return null==t?[1,1]:"number"==typeof t?[1,t]:t},_getMinMaxDate:function(e,t){return this._determineDate(e,this._get(e,t+"Date"),null)},_getDaysInMonth:function(e,t){return 32-this._daylightSavingAdjust(new Date(e,t,32)).getDate()},_getFirstDayOfMonth:function(e,t){return new Date(e,t,1).getDay()},_canAdjustMonth:function(e,t,i,s){var n=this._getNumberOfMonths(e),a=this._daylightSavingAdjust(new Date(i,s+(0>t?t:n[0]*n[1]),1));return 0>t&&a.setDate(this._getDaysInMonth(a.getFullYear(),a.getMonth())),this._isInRange(e,a)},_isInRange:function(e,t){var i,s,n=this._getMinMaxDate(e,"min"),a=this._getMinMaxDate(e,"max"),o=null,r=null,h=this._get(e,"yearRange");return h&&(i=h.split(":"),s=(new Date).getFullYear(),o=parseInt(i[0],10),r=parseInt(i[1],10),i[0].match(/[+\-].*/)&&(o+=s),i[1].match(/[+\-].*/)&&(r+=s)),(!n||t.getTime()>=n.getTime())&&(!a||t.getTime()<=a.getTime())&&(!o||t.getFullYear()>=o)&&(!r||r>=t.getFullYear())},_getFormatConfig:function(e){var t=this._get(e,"shortYearCutoff");return t="string"!=typeof t?t:(new Date).getFullYear()%100+parseInt(t,10),{shortYearCutoff:t,dayNamesShort:this._get(e,"dayNamesShort"),dayNames:this._get(e,"dayNames"),monthNamesShort:this._get(e,"monthNamesShort"),monthNames:this._get(e,"monthNames")}},_formatDate:function(e,t,i,s){t||(e.currentDay=e.selectedDay,e.currentMonth=e.selectedMonth,e.currentYear=e.selectedYear);var n=t?"object"==typeof t?t:this._daylightSavingAdjust(new Date(s,i,t)):this._daylightSavingAdjust(new Date(e.currentYear,e.currentMonth,e.currentDay));return this.formatDate(this._get(e,"dateFormat"),n,this._getFormatConfig(e))}}),e.fn.datepicker=function(t){if(!this.length)return this;e.datepicker.initialized||(e(document).mousedown(e.datepicker._checkExternalClick),e.datepicker.initialized=!0),0===e("#"+e.datepicker._mainDivId).length&&e("body").append(e.datepicker.dpDiv);var i=Array.prototype.slice.call(arguments,1);return"string"!=typeof t||"isDisabled"!==t&&"getDate"!==t&&"widget"!==t?"option"===t&&2===arguments.length&&"string"==typeof arguments[1]?e.datepicker["_"+t+"Datepicker"].apply(e.datepicker,[this[0]].concat(i)):this.each(function(){"string"==typeof t?e.datepicker["_"+t+"Datepicker"].apply(e.datepicker,[this].concat(i)):e.datepicker._attachDatepicker(this,t)}):e.datepicker["_"+t+"Datepicker"].apply(e.datepicker,[this[0]].concat(i))},e.datepicker=new n,e.datepicker.initialized=!1,e.datepicker.uuid=(new Date).getTime(),e.datepicker.version="1.11.4",e.datepicker,e.widget("ui.draggable",e.ui.mouse,{version:"1.11.4",widgetEventPrefix:"drag",options:{addClasses:!0,appendTo:"parent",axis:!1,connectToSortable:!1,containment:!1,cursor:"auto",cursorAt:!1,grid:!1,handle:!1,helper:"original",iframeFix:!1,opacity:!1,refreshPositions:!1,revert:!1,revertDuration:500,scope:"default",scroll:!0,scrollSensitivity:20,scrollSpeed:20,snap:!1,snapMode:"both",snapTolerance:20,stack:!1,zIndex:!1,drag:null,start:null,stop:null},_create:function(){"original"===this.options.helper&&this._setPositionRelative(),this.options.addClasses&&this.element.addClass("ui-draggable"),this.options.disabled&&this.element.addClass("ui-draggable-disabled"),this._setHandleClassName(),this._mouseInit()},_setOption:function(e,t){this._super(e,t),"handle"===e&&(this._removeHandleClassName(),this._setHandleClassName())},_destroy:function(){return(this.helper||this.element).is(".ui-draggable-dragging")?(this.destroyOnClear=!0,void 0):(this.element.removeClass("ui-draggable ui-draggable-dragging ui-draggable-disabled"),this._removeHandleClassName(),this._mouseDestroy(),void 0)},_mouseCapture:function(t){var i=this.options;return this._blurActiveElement(t),this.helper||i.disabled||e(t.target).closest(".ui-resizable-handle").length>0?!1:(this.handle=this._getHandle(t),this.handle?(this._blockFrames(i.iframeFix===!0?"iframe":i.iframeFix),!0):!1)},_blockFrames:function(t){this.iframeBlocks=this.document.find(t).map(function(){var t=e(this);return e("<div>").css("position","absolute").appendTo(t.parent()).outerWidth(t.outerWidth()).outerHeight(t.outerHeight()).offset(t.offset())[0]})},_unblockFrames:function(){this.iframeBlocks&&(this.iframeBlocks.remove(),delete this.iframeBlocks)},_blurActiveElement:function(t){var i=this.document[0];if(this.handleElement.is(t.target))try{i.activeElement&&"body"!==i.activeElement.nodeName.toLowerCase()&&e(i.activeElement).blur()}catch(s){}},_mouseStart:function(t){var i=this.options;return this.helper=this._createHelper(t),this.helper.addClass("ui-draggable-dragging"),this._cacheHelperProportions(),e.ui.ddmanager&&(e.ui.ddmanager.current=this),this._cacheMargins(),this.cssPosition=this.helper.css("position"),this.scrollParent=this.helper.scrollParent(!0),this.offsetParent=this.helper.offsetParent(),this.hasFixedAncestor=this.helper.parents().filter(function(){return"fixed"===e(this).css("position")}).length>0,this.positionAbs=this.element.offset(),this._refreshOffsets(t),this.originalPosition=this.position=this._generatePosition(t,!1),this.originalPageX=t.pageX,this.originalPageY=t.pageY,i.cursorAt&&this._adjustOffsetFromHelper(i.cursorAt),this._setContainment(),this._trigger("start",t)===!1?(this._clear(),!1):(this._cacheHelperProportions(),e.ui.ddmanager&&!i.dropBehaviour&&e.ui.ddmanager.prepareOffsets(this,t),this._normalizeRightBottom(),this._mouseDrag(t,!0),e.ui.ddmanager&&e.ui.ddmanager.dragStart(this,t),!0)},_refreshOffsets:function(e){this.offset={top:this.positionAbs.top-this.margins.top,left:this.positionAbs.left-this.margins.left,scroll:!1,parent:this._getParentOffset(),relative:this._getRelativeOffset()},this.offset.click={left:e.pageX-this.offset.left,top:e.pageY-this.offset.top}},_mouseDrag:function(t,i){if(this.hasFixedAncestor&&(this.offset.parent=this._getParentOffset()),this.position=this._generatePosition(t,!0),this.positionAbs=this._convertPositionTo("absolute"),!i){var s=this._uiHash();if(this._trigger("drag",t,s)===!1)return this._mouseUp({}),!1;this.position=s.position}return this.helper[0].style.left=this.position.left+"px",this.helper[0].style.top=this.position.top+"px",e.ui.ddmanager&&e.ui.ddmanager.drag(this,t),!1},_mouseStop:function(t){var i=this,s=!1;return e.ui.ddmanager&&!this.options.dropBehaviour&&(s=e.ui.ddmanager.drop(this,t)),this.dropped&&(s=this.dropped,this.dropped=!1),"invalid"===this.options.revert&&!s||"valid"===this.options.revert&&s||this.options.revert===!0||e.isFunction(this.options.revert)&&this.options.revert.call(this.element,s)?e(this.helper).animate(this.originalPosition,parseInt(this.options.revertDuration,10),function(){i._trigger("stop",t)!==!1&&i._clear()}):this._trigger("stop",t)!==!1&&this._clear(),!1},_mouseUp:function(t){return this._unblockFrames(),e.ui.ddmanager&&e.ui.ddmanager.dragStop(this,t),this.handleElement.is(t.target)&&this.element.focus(),e.ui.mouse.prototype._mouseUp.call(this,t)},cancel:function(){return this.helper.is(".ui-draggable-dragging")?this._mouseUp({}):this._clear(),this},_getHandle:function(t){return this.options.handle?!!e(t.target).closest(this.element.find(this.options.handle)).length:!0},_setHandleClassName:function(){this.handleElement=this.options.handle?this.element.find(this.options.handle):this.element,this.handleElement.addClass("ui-draggable-handle")},_removeHandleClassName:function(){this.handleElement.removeClass("ui-draggable-handle")},_createHelper:function(t){var i=this.options,s=e.isFunction(i.helper),n=s?e(i.helper.apply(this.element[0],[t])):"clone"===i.helper?this.element.clone().removeAttr("id"):this.element;return n.parents("body").length||n.appendTo("parent"===i.appendTo?this.element[0].parentNode:i.appendTo),s&&n[0]===this.element[0]&&this._setPositionRelative(),n[0]===this.element[0]||/(fixed|absolute)/.test(n.css("position"))||n.css("position","absolute"),n},_setPositionRelative:function(){/^(?:r|a|f)/.test(this.element.css("position"))||(this.element[0].style.position="relative")},_adjustOffsetFromHelper:function(t){"string"==typeof t&&(t=t.split(" ")),e.isArray(t)&&(t={left:+t[0],top:+t[1]||0}),"left"in t&&(this.offset.click.left=t.left+this.margins.left),"right"in t&&(this.offset.click.left=this.helperProportions.width-t.right+this.margins.left),"top"in t&&(this.offset.click.top=t.top+this.margins.top),"bottom"in t&&(this.offset.click.top=this.helperProportions.height-t.bottom+this.margins.top)},_isRootNode:function(e){return/(html|body)/i.test(e.tagName)||e===this.document[0]},_getParentOffset:function(){var t=this.offsetParent.offset(),i=this.document[0];return"absolute"===this.cssPosition&&this.scrollParent[0]!==i&&e.contains(this.scrollParent[0],this.offsetParent[0])&&(t.left+=this.scrollParent.scrollLeft(),t.top+=this.scrollParent.scrollTop()),this._isRootNode(this.offsetParent[0])&&(t={top:0,left:0}),{top:t.top+(parseInt(this.offsetParent.css("borderTopWidth"),10)||0),left:t.left+(parseInt(this.offsetParent.css("borderLeftWidth"),10)||0)}},_getRelativeOffset:function(){if("relative"!==this.cssPosition)return{top:0,left:0};var e=this.element.position(),t=this._isRootNode(this.scrollParent[0]);return{top:e.top-(parseInt(this.helper.css("top"),10)||0)+(t?0:this.scrollParent.scrollTop()),left:e.left-(parseInt(this.helper.css("left"),10)||0)+(t?0:this.scrollParent.scrollLeft())}},_cacheMargins:function(){this.margins={left:parseInt(this.element.css("marginLeft"),10)||0,top:parseInt(this.element.css("marginTop"),10)||0,right:parseInt(this.element.css("marginRight"),10)||0,bottom:parseInt(this.element.css("marginBottom"),10)||0}},_cacheHelperProportions:function(){this.helperProportions={width:this.helper.outerWidth(),height:this.helper.outerHeight()}},_setContainment:function(){var t,i,s,n=this.options,a=this.document[0];return this.relativeContainer=null,n.containment?"window"===n.containment?(this.containment=[e(window).scrollLeft()-this.offset.relative.left-this.offset.parent.left,e(window).scrollTop()-this.offset.relative.top-this.offset.parent.top,e(window).scrollLeft()+e(window).width()-this.helperProportions.width-this.margins.left,e(window).scrollTop()+(e(window).height()||a.body.parentNode.scrollHeight)-this.helperProportions.height-this.margins.top],void 0):"document"===n.containment?(this.containment=[0,0,e(a).width()-this.helperProportions.width-this.margins.left,(e(a).height()||a.body.parentNode.scrollHeight)-this.helperProportions.height-this.margins.top],void 0):n.containment.constructor===Array?(this.containment=n.containment,void 0):("parent"===n.containment&&(n.containment=this.helper[0].parentNode),i=e(n.containment),s=i[0],s&&(t=/(scroll|auto)/.test(i.css("overflow")),this.containment=[(parseInt(i.css("borderLeftWidth"),10)||0)+(parseInt(i.css("paddingLeft"),10)||0),(parseInt(i.css("borderTopWidth"),10)||0)+(parseInt(i.css("paddingTop"),10)||0),(t?Math.max(s.scrollWidth,s.offsetWidth):s.offsetWidth)-(parseInt(i.css("borderRightWidth"),10)||0)-(parseInt(i.css("paddingRight"),10)||0)-this.helperProportions.width-this.margins.left-this.margins.right,(t?Math.max(s.scrollHeight,s.offsetHeight):s.offsetHeight)-(parseInt(i.css("borderBottomWidth"),10)||0)-(parseInt(i.css("paddingBottom"),10)||0)-this.helperProportions.height-this.margins.top-this.margins.bottom],this.relativeContainer=i),void 0):(this.containment=null,void 0)
},_convertPositionTo:function(e,t){t||(t=this.position);var i="absolute"===e?1:-1,s=this._isRootNode(this.scrollParent[0]);return{top:t.top+this.offset.relative.top*i+this.offset.parent.top*i-("fixed"===this.cssPosition?-this.offset.scroll.top:s?0:this.offset.scroll.top)*i,left:t.left+this.offset.relative.left*i+this.offset.parent.left*i-("fixed"===this.cssPosition?-this.offset.scroll.left:s?0:this.offset.scroll.left)*i}},_generatePosition:function(e,t){var i,s,n,a,o=this.options,r=this._isRootNode(this.scrollParent[0]),h=e.pageX,l=e.pageY;return r&&this.offset.scroll||(this.offset.scroll={top:this.scrollParent.scrollTop(),left:this.scrollParent.scrollLeft()}),t&&(this.containment&&(this.relativeContainer?(s=this.relativeContainer.offset(),i=[this.containment[0]+s.left,this.containment[1]+s.top,this.containment[2]+s.left,this.containment[3]+s.top]):i=this.containment,e.pageX-this.offset.click.left<i[0]&&(h=i[0]+this.offset.click.left),e.pageY-this.offset.click.top<i[1]&&(l=i[1]+this.offset.click.top),e.pageX-this.offset.click.left>i[2]&&(h=i[2]+this.offset.click.left),e.pageY-this.offset.click.top>i[3]&&(l=i[3]+this.offset.click.top)),o.grid&&(n=o.grid[1]?this.originalPageY+Math.round((l-this.originalPageY)/o.grid[1])*o.grid[1]:this.originalPageY,l=i?n-this.offset.click.top>=i[1]||n-this.offset.click.top>i[3]?n:n-this.offset.click.top>=i[1]?n-o.grid[1]:n+o.grid[1]:n,a=o.grid[0]?this.originalPageX+Math.round((h-this.originalPageX)/o.grid[0])*o.grid[0]:this.originalPageX,h=i?a-this.offset.click.left>=i[0]||a-this.offset.click.left>i[2]?a:a-this.offset.click.left>=i[0]?a-o.grid[0]:a+o.grid[0]:a),"y"===o.axis&&(h=this.originalPageX),"x"===o.axis&&(l=this.originalPageY)),{top:l-this.offset.click.top-this.offset.relative.top-this.offset.parent.top+("fixed"===this.cssPosition?-this.offset.scroll.top:r?0:this.offset.scroll.top),left:h-this.offset.click.left-this.offset.relative.left-this.offset.parent.left+("fixed"===this.cssPosition?-this.offset.scroll.left:r?0:this.offset.scroll.left)}},_clear:function(){this.helper.removeClass("ui-draggable-dragging"),this.helper[0]===this.element[0]||this.cancelHelperRemoval||this.helper.remove(),this.helper=null,this.cancelHelperRemoval=!1,this.destroyOnClear&&this.destroy()},_normalizeRightBottom:function(){"y"!==this.options.axis&&"auto"!==this.helper.css("right")&&(this.helper.width(this.helper.width()),this.helper.css("right","auto")),"x"!==this.options.axis&&"auto"!==this.helper.css("bottom")&&(this.helper.height(this.helper.height()),this.helper.css("bottom","auto"))},_trigger:function(t,i,s){return s=s||this._uiHash(),e.ui.plugin.call(this,t,[i,s,this],!0),/^(drag|start|stop)/.test(t)&&(this.positionAbs=this._convertPositionTo("absolute"),s.offset=this.positionAbs),e.Widget.prototype._trigger.call(this,t,i,s)},plugins:{},_uiHash:function(){return{helper:this.helper,position:this.position,originalPosition:this.originalPosition,offset:this.positionAbs}}}),e.ui.plugin.add("draggable","connectToSortable",{start:function(t,i,s){var n=e.extend({},i,{item:s.element});s.sortables=[],e(s.options.connectToSortable).each(function(){var i=e(this).sortable("instance");i&&!i.options.disabled&&(s.sortables.push(i),i.refreshPositions(),i._trigger("activate",t,n))})},stop:function(t,i,s){var n=e.extend({},i,{item:s.element});s.cancelHelperRemoval=!1,e.each(s.sortables,function(){var e=this;e.isOver?(e.isOver=0,s.cancelHelperRemoval=!0,e.cancelHelperRemoval=!1,e._storedCSS={position:e.placeholder.css("position"),top:e.placeholder.css("top"),left:e.placeholder.css("left")},e._mouseStop(t),e.options.helper=e.options._helper):(e.cancelHelperRemoval=!0,e._trigger("deactivate",t,n))})},drag:function(t,i,s){e.each(s.sortables,function(){var n=!1,a=this;a.positionAbs=s.positionAbs,a.helperProportions=s.helperProportions,a.offset.click=s.offset.click,a._intersectsWith(a.containerCache)&&(n=!0,e.each(s.sortables,function(){return this.positionAbs=s.positionAbs,this.helperProportions=s.helperProportions,this.offset.click=s.offset.click,this!==a&&this._intersectsWith(this.containerCache)&&e.contains(a.element[0],this.element[0])&&(n=!1),n})),n?(a.isOver||(a.isOver=1,s._parent=i.helper.parent(),a.currentItem=i.helper.appendTo(a.element).data("ui-sortable-item",!0),a.options._helper=a.options.helper,a.options.helper=function(){return i.helper[0]},t.target=a.currentItem[0],a._mouseCapture(t,!0),a._mouseStart(t,!0,!0),a.offset.click.top=s.offset.click.top,a.offset.click.left=s.offset.click.left,a.offset.parent.left-=s.offset.parent.left-a.offset.parent.left,a.offset.parent.top-=s.offset.parent.top-a.offset.parent.top,s._trigger("toSortable",t),s.dropped=a.element,e.each(s.sortables,function(){this.refreshPositions()}),s.currentItem=s.element,a.fromOutside=s),a.currentItem&&(a._mouseDrag(t),i.position=a.position)):a.isOver&&(a.isOver=0,a.cancelHelperRemoval=!0,a.options._revert=a.options.revert,a.options.revert=!1,a._trigger("out",t,a._uiHash(a)),a._mouseStop(t,!0),a.options.revert=a.options._revert,a.options.helper=a.options._helper,a.placeholder&&a.placeholder.remove(),i.helper.appendTo(s._parent),s._refreshOffsets(t),i.position=s._generatePosition(t,!0),s._trigger("fromSortable",t),s.dropped=!1,e.each(s.sortables,function(){this.refreshPositions()}))})}}),e.ui.plugin.add("draggable","cursor",{start:function(t,i,s){var n=e("body"),a=s.options;n.css("cursor")&&(a._cursor=n.css("cursor")),n.css("cursor",a.cursor)},stop:function(t,i,s){var n=s.options;n._cursor&&e("body").css("cursor",n._cursor)}}),e.ui.plugin.add("draggable","opacity",{start:function(t,i,s){var n=e(i.helper),a=s.options;n.css("opacity")&&(a._opacity=n.css("opacity")),n.css("opacity",a.opacity)},stop:function(t,i,s){var n=s.options;n._opacity&&e(i.helper).css("opacity",n._opacity)}}),e.ui.plugin.add("draggable","scroll",{start:function(e,t,i){i.scrollParentNotHidden||(i.scrollParentNotHidden=i.helper.scrollParent(!1)),i.scrollParentNotHidden[0]!==i.document[0]&&"HTML"!==i.scrollParentNotHidden[0].tagName&&(i.overflowOffset=i.scrollParentNotHidden.offset())},drag:function(t,i,s){var n=s.options,a=!1,o=s.scrollParentNotHidden[0],r=s.document[0];o!==r&&"HTML"!==o.tagName?(n.axis&&"x"===n.axis||(s.overflowOffset.top+o.offsetHeight-t.pageY<n.scrollSensitivity?o.scrollTop=a=o.scrollTop+n.scrollSpeed:t.pageY-s.overflowOffset.top<n.scrollSensitivity&&(o.scrollTop=a=o.scrollTop-n.scrollSpeed)),n.axis&&"y"===n.axis||(s.overflowOffset.left+o.offsetWidth-t.pageX<n.scrollSensitivity?o.scrollLeft=a=o.scrollLeft+n.scrollSpeed:t.pageX-s.overflowOffset.left<n.scrollSensitivity&&(o.scrollLeft=a=o.scrollLeft-n.scrollSpeed))):(n.axis&&"x"===n.axis||(t.pageY-e(r).scrollTop()<n.scrollSensitivity?a=e(r).scrollTop(e(r).scrollTop()-n.scrollSpeed):e(window).height()-(t.pageY-e(r).scrollTop())<n.scrollSensitivity&&(a=e(r).scrollTop(e(r).scrollTop()+n.scrollSpeed))),n.axis&&"y"===n.axis||(t.pageX-e(r).scrollLeft()<n.scrollSensitivity?a=e(r).scrollLeft(e(r).scrollLeft()-n.scrollSpeed):e(window).width()-(t.pageX-e(r).scrollLeft())<n.scrollSensitivity&&(a=e(r).scrollLeft(e(r).scrollLeft()+n.scrollSpeed)))),a!==!1&&e.ui.ddmanager&&!n.dropBehaviour&&e.ui.ddmanager.prepareOffsets(s,t)}}),e.ui.plugin.add("draggable","snap",{start:function(t,i,s){var n=s.options;s.snapElements=[],e(n.snap.constructor!==String?n.snap.items||":data(ui-draggable)":n.snap).each(function(){var t=e(this),i=t.offset();this!==s.element[0]&&s.snapElements.push({item:this,width:t.outerWidth(),height:t.outerHeight(),top:i.top,left:i.left})})},drag:function(t,i,s){var n,a,o,r,h,l,u,d,c,p,f=s.options,m=f.snapTolerance,g=i.offset.left,v=g+s.helperProportions.width,y=i.offset.top,b=y+s.helperProportions.height;for(c=s.snapElements.length-1;c>=0;c--)h=s.snapElements[c].left-s.margins.left,l=h+s.snapElements[c].width,u=s.snapElements[c].top-s.margins.top,d=u+s.snapElements[c].height,h-m>v||g>l+m||u-m>b||y>d+m||!e.contains(s.snapElements[c].item.ownerDocument,s.snapElements[c].item)?(s.snapElements[c].snapping&&s.options.snap.release&&s.options.snap.release.call(s.element,t,e.extend(s._uiHash(),{snapItem:s.snapElements[c].item})),s.snapElements[c].snapping=!1):("inner"!==f.snapMode&&(n=m>=Math.abs(u-b),a=m>=Math.abs(d-y),o=m>=Math.abs(h-v),r=m>=Math.abs(l-g),n&&(i.position.top=s._convertPositionTo("relative",{top:u-s.helperProportions.height,left:0}).top),a&&(i.position.top=s._convertPositionTo("relative",{top:d,left:0}).top),o&&(i.position.left=s._convertPositionTo("relative",{top:0,left:h-s.helperProportions.width}).left),r&&(i.position.left=s._convertPositionTo("relative",{top:0,left:l}).left)),p=n||a||o||r,"outer"!==f.snapMode&&(n=m>=Math.abs(u-y),a=m>=Math.abs(d-b),o=m>=Math.abs(h-g),r=m>=Math.abs(l-v),n&&(i.position.top=s._convertPositionTo("relative",{top:u,left:0}).top),a&&(i.position.top=s._convertPositionTo("relative",{top:d-s.helperProportions.height,left:0}).top),o&&(i.position.left=s._convertPositionTo("relative",{top:0,left:h}).left),r&&(i.position.left=s._convertPositionTo("relative",{top:0,left:l-s.helperProportions.width}).left)),!s.snapElements[c].snapping&&(n||a||o||r||p)&&s.options.snap.snap&&s.options.snap.snap.call(s.element,t,e.extend(s._uiHash(),{snapItem:s.snapElements[c].item})),s.snapElements[c].snapping=n||a||o||r||p)}}),e.ui.plugin.add("draggable","stack",{start:function(t,i,s){var n,a=s.options,o=e.makeArray(e(a.stack)).sort(function(t,i){return(parseInt(e(t).css("zIndex"),10)||0)-(parseInt(e(i).css("zIndex"),10)||0)});o.length&&(n=parseInt(e(o[0]).css("zIndex"),10)||0,e(o).each(function(t){e(this).css("zIndex",n+t)}),this.css("zIndex",n+o.length))}}),e.ui.plugin.add("draggable","zIndex",{start:function(t,i,s){var n=e(i.helper),a=s.options;n.css("zIndex")&&(a._zIndex=n.css("zIndex")),n.css("zIndex",a.zIndex)},stop:function(t,i,s){var n=s.options;n._zIndex&&e(i.helper).css("zIndex",n._zIndex)}}),e.ui.draggable,e.widget("ui.resizable",e.ui.mouse,{version:"1.11.4",widgetEventPrefix:"resize",options:{alsoResize:!1,animate:!1,animateDuration:"slow",animateEasing:"swing",aspectRatio:!1,autoHide:!1,containment:!1,ghost:!1,grid:!1,handles:"e,s,se",helper:!1,maxHeight:null,maxWidth:null,minHeight:10,minWidth:10,zIndex:90,resize:null,start:null,stop:null},_num:function(e){return parseInt(e,10)||0},_isNumber:function(e){return!isNaN(parseInt(e,10))},_hasScroll:function(t,i){if("hidden"===e(t).css("overflow"))return!1;var s=i&&"left"===i?"scrollLeft":"scrollTop",n=!1;return t[s]>0?!0:(t[s]=1,n=t[s]>0,t[s]=0,n)},_create:function(){var t,i,s,n,a,o=this,r=this.options;if(this.element.addClass("ui-resizable"),e.extend(this,{_aspectRatio:!!r.aspectRatio,aspectRatio:r.aspectRatio,originalElement:this.element,_proportionallyResizeElements:[],_helper:r.helper||r.ghost||r.animate?r.helper||"ui-resizable-helper":null}),this.element[0].nodeName.match(/^(canvas|textarea|input|select|button|img)$/i)&&(this.element.wrap(e("<div class='ui-wrapper' style='overflow: hidden;'></div>").css({position:this.element.css("position"),width:this.element.outerWidth(),height:this.element.outerHeight(),top:this.element.css("top"),left:this.element.css("left")})),this.element=this.element.parent().data("ui-resizable",this.element.resizable("instance")),this.elementIsWrapper=!0,this.element.css({marginLeft:this.originalElement.css("marginLeft"),marginTop:this.originalElement.css("marginTop"),marginRight:this.originalElement.css("marginRight"),marginBottom:this.originalElement.css("marginBottom")}),this.originalElement.css({marginLeft:0,marginTop:0,marginRight:0,marginBottom:0}),this.originalResizeStyle=this.originalElement.css("resize"),this.originalElement.css("resize","none"),this._proportionallyResizeElements.push(this.originalElement.css({position:"static",zoom:1,display:"block"})),this.originalElement.css({margin:this.originalElement.css("margin")}),this._proportionallyResize()),this.handles=r.handles||(e(".ui-resizable-handle",this.element).length?{n:".ui-resizable-n",e:".ui-resizable-e",s:".ui-resizable-s",w:".ui-resizable-w",se:".ui-resizable-se",sw:".ui-resizable-sw",ne:".ui-resizable-ne",nw:".ui-resizable-nw"}:"e,s,se"),this._handles=e(),this.handles.constructor===String)for("all"===this.handles&&(this.handles="n,e,s,w,se,sw,ne,nw"),t=this.handles.split(","),this.handles={},i=0;t.length>i;i++)s=e.trim(t[i]),a="ui-resizable-"+s,n=e("<div class='ui-resizable-handle "+a+"'></div>"),n.css({zIndex:r.zIndex}),"se"===s&&n.addClass("ui-icon ui-icon-gripsmall-diagonal-se"),this.handles[s]=".ui-resizable-"+s,this.element.append(n);this._renderAxis=function(t){var i,s,n,a;t=t||this.element;for(i in this.handles)this.handles[i].constructor===String?this.handles[i]=this.element.children(this.handles[i]).first().show():(this.handles[i].jquery||this.handles[i].nodeType)&&(this.handles[i]=e(this.handles[i]),this._on(this.handles[i],{mousedown:o._mouseDown})),this.elementIsWrapper&&this.originalElement[0].nodeName.match(/^(textarea|input|select|button)$/i)&&(s=e(this.handles[i],this.element),a=/sw|ne|nw|se|n|s/.test(i)?s.outerHeight():s.outerWidth(),n=["padding",/ne|nw|n/.test(i)?"Top":/se|sw|s/.test(i)?"Bottom":/^e$/.test(i)?"Right":"Left"].join(""),t.css(n,a),this._proportionallyResize()),this._handles=this._handles.add(this.handles[i])},this._renderAxis(this.element),this._handles=this._handles.add(this.element.find(".ui-resizable-handle")),this._handles.disableSelection(),this._handles.mouseover(function(){o.resizing||(this.className&&(n=this.className.match(/ui-resizable-(se|sw|ne|nw|n|e|s|w)/i)),o.axis=n&&n[1]?n[1]:"se")}),r.autoHide&&(this._handles.hide(),e(this.element).addClass("ui-resizable-autohide").mouseenter(function(){r.disabled||(e(this).removeClass("ui-resizable-autohide"),o._handles.show())}).mouseleave(function(){r.disabled||o.resizing||(e(this).addClass("ui-resizable-autohide"),o._handles.hide())})),this._mouseInit()},_destroy:function(){this._mouseDestroy();var t,i=function(t){e(t).removeClass("ui-resizable ui-resizable-disabled ui-resizable-resizing").removeData("resizable").removeData("ui-resizable").unbind(".resizable").find(".ui-resizable-handle").remove()};return this.elementIsWrapper&&(i(this.element),t=this.element,this.originalElement.css({position:t.css("position"),width:t.outerWidth(),height:t.outerHeight(),top:t.css("top"),left:t.css("left")}).insertAfter(t),t.remove()),this.originalElement.css("resize",this.originalResizeStyle),i(this.originalElement),this},_mouseCapture:function(t){var i,s,n=!1;for(i in this.handles)s=e(this.handles[i])[0],(s===t.target||e.contains(s,t.target))&&(n=!0);return!this.options.disabled&&n},_mouseStart:function(t){var i,s,n,a=this.options,o=this.element;return this.resizing=!0,this._renderProxy(),i=this._num(this.helper.css("left")),s=this._num(this.helper.css("top")),a.containment&&(i+=e(a.containment).scrollLeft()||0,s+=e(a.containment).scrollTop()||0),this.offset=this.helper.offset(),this.position={left:i,top:s},this.size=this._helper?{width:this.helper.width(),height:this.helper.height()}:{width:o.width(),height:o.height()},this.originalSize=this._helper?{width:o.outerWidth(),height:o.outerHeight()}:{width:o.width(),height:o.height()},this.sizeDiff={width:o.outerWidth()-o.width(),height:o.outerHeight()-o.height()},this.originalPosition={left:i,top:s},this.originalMousePosition={left:t.pageX,top:t.pageY},this.aspectRatio="number"==typeof a.aspectRatio?a.aspectRatio:this.originalSize.width/this.originalSize.height||1,n=e(".ui-resizable-"+this.axis).css("cursor"),e("body").css("cursor","auto"===n?this.axis+"-resize":n),o.addClass("ui-resizable-resizing"),this._propagate("start",t),!0},_mouseDrag:function(t){var i,s,n=this.originalMousePosition,a=this.axis,o=t.pageX-n.left||0,r=t.pageY-n.top||0,h=this._change[a];return this._updatePrevProperties(),h?(i=h.apply(this,[t,o,r]),this._updateVirtualBoundaries(t.shiftKey),(this._aspectRatio||t.shiftKey)&&(i=this._updateRatio(i,t)),i=this._respectSize(i,t),this._updateCache(i),this._propagate("resize",t),s=this._applyChanges(),!this._helper&&this._proportionallyResizeElements.length&&this._proportionallyResize(),e.isEmptyObject(s)||(this._updatePrevProperties(),this._trigger("resize",t,this.ui()),this._applyChanges()),!1):!1},_mouseStop:function(t){this.resizing=!1;var i,s,n,a,o,r,h,l=this.options,u=this;return this._helper&&(i=this._proportionallyResizeElements,s=i.length&&/textarea/i.test(i[0].nodeName),n=s&&this._hasScroll(i[0],"left")?0:u.sizeDiff.height,a=s?0:u.sizeDiff.width,o={width:u.helper.width()-a,height:u.helper.height()-n},r=parseInt(u.element.css("left"),10)+(u.position.left-u.originalPosition.left)||null,h=parseInt(u.element.css("top"),10)+(u.position.top-u.originalPosition.top)||null,l.animate||this.element.css(e.extend(o,{top:h,left:r})),u.helper.height(u.size.height),u.helper.width(u.size.width),this._helper&&!l.animate&&this._proportionallyResize()),e("body").css("cursor","auto"),this.element.removeClass("ui-resizable-resizing"),this._propagate("stop",t),this._helper&&this.helper.remove(),!1},_updatePrevProperties:function(){this.prevPosition={top:this.position.top,left:this.position.left},this.prevSize={width:this.size.width,height:this.size.height}},_applyChanges:function(){var e={};return this.position.top!==this.prevPosition.top&&(e.top=this.position.top+"px"),this.position.left!==this.prevPosition.left&&(e.left=this.position.left+"px"),this.size.width!==this.prevSize.width&&(e.width=this.size.width+"px"),this.size.height!==this.prevSize.height&&(e.height=this.size.height+"px"),this.helper.css(e),e},_updateVirtualBoundaries:function(e){var t,i,s,n,a,o=this.options;a={minWidth:this._isNumber(o.minWidth)?o.minWidth:0,maxWidth:this._isNumber(o.maxWidth)?o.maxWidth:1/0,minHeight:this._isNumber(o.minHeight)?o.minHeight:0,maxHeight:this._isNumber(o.maxHeight)?o.maxHeight:1/0},(this._aspectRatio||e)&&(t=a.minHeight*this.aspectRatio,s=a.minWidth/this.aspectRatio,i=a.maxHeight*this.aspectRatio,n=a.maxWidth/this.aspectRatio,t>a.minWidth&&(a.minWidth=t),s>a.minHeight&&(a.minHeight=s),a.maxWidth>i&&(a.maxWidth=i),a.maxHeight>n&&(a.maxHeight=n)),this._vBoundaries=a},_updateCache:function(e){this.offset=this.helper.offset(),this._isNumber(e.left)&&(this.position.left=e.left),this._isNumber(e.top)&&(this.position.top=e.top),this._isNumber(e.height)&&(this.size.height=e.height),this._isNumber(e.width)&&(this.size.width=e.width)},_updateRatio:function(e){var t=this.position,i=this.size,s=this.axis;return this._isNumber(e.height)?e.width=e.height*this.aspectRatio:this._isNumber(e.width)&&(e.height=e.width/this.aspectRatio),"sw"===s&&(e.left=t.left+(i.width-e.width),e.top=null),"nw"===s&&(e.top=t.top+(i.height-e.height),e.left=t.left+(i.width-e.width)),e},_respectSize:function(e){var t=this._vBoundaries,i=this.axis,s=this._isNumber(e.width)&&t.maxWidth&&t.maxWidth<e.width,n=this._isNumber(e.height)&&t.maxHeight&&t.maxHeight<e.height,a=this._isNumber(e.width)&&t.minWidth&&t.minWidth>e.width,o=this._isNumber(e.height)&&t.minHeight&&t.minHeight>e.height,r=this.originalPosition.left+this.originalSize.width,h=this.position.top+this.size.height,l=/sw|nw|w/.test(i),u=/nw|ne|n/.test(i);return a&&(e.width=t.minWidth),o&&(e.height=t.minHeight),s&&(e.width=t.maxWidth),n&&(e.height=t.maxHeight),a&&l&&(e.left=r-t.minWidth),s&&l&&(e.left=r-t.maxWidth),o&&u&&(e.top=h-t.minHeight),n&&u&&(e.top=h-t.maxHeight),e.width||e.height||e.left||!e.top?e.width||e.height||e.top||!e.left||(e.left=null):e.top=null,e},_getPaddingPlusBorderDimensions:function(e){for(var t=0,i=[],s=[e.css("borderTopWidth"),e.css("borderRightWidth"),e.css("borderBottomWidth"),e.css("borderLeftWidth")],n=[e.css("paddingTop"),e.css("paddingRight"),e.css("paddingBottom"),e.css("paddingLeft")];4>t;t++)i[t]=parseInt(s[t],10)||0,i[t]+=parseInt(n[t],10)||0;return{height:i[0]+i[2],width:i[1]+i[3]}},_proportionallyResize:function(){if(this._proportionallyResizeElements.length)for(var e,t=0,i=this.helper||this.element;this._proportionallyResizeElements.length>t;t++)e=this._proportionallyResizeElements[t],this.outerDimensions||(this.outerDimensions=this._getPaddingPlusBorderDimensions(e)),e.css({height:i.height()-this.outerDimensions.height||0,width:i.width()-this.outerDimensions.width||0})},_renderProxy:function(){var t=this.element,i=this.options;this.elementOffset=t.offset(),this._helper?(this.helper=this.helper||e("<div style='overflow:hidden;'></div>"),this.helper.addClass(this._helper).css({width:this.element.outerWidth()-1,height:this.element.outerHeight()-1,position:"absolute",left:this.elementOffset.left+"px",top:this.elementOffset.top+"px",zIndex:++i.zIndex}),this.helper.appendTo("body").disableSelection()):this.helper=this.element},_change:{e:function(e,t){return{width:this.originalSize.width+t}},w:function(e,t){var i=this.originalSize,s=this.originalPosition;return{left:s.left+t,width:i.width-t}},n:function(e,t,i){var s=this.originalSize,n=this.originalPosition;return{top:n.top+i,height:s.height-i}},s:function(e,t,i){return{height:this.originalSize.height+i}},se:function(t,i,s){return e.extend(this._change.s.apply(this,arguments),this._change.e.apply(this,[t,i,s]))},sw:function(t,i,s){return e.extend(this._change.s.apply(this,arguments),this._change.w.apply(this,[t,i,s]))},ne:function(t,i,s){return e.extend(this._change.n.apply(this,arguments),this._change.e.apply(this,[t,i,s]))},nw:function(t,i,s){return e.extend(this._change.n.apply(this,arguments),this._change.w.apply(this,[t,i,s]))}},_propagate:function(t,i){e.ui.plugin.call(this,t,[i,this.ui()]),"resize"!==t&&this._trigger(t,i,this.ui())},plugins:{},ui:function(){return{originalElement:this.originalElement,element:this.element,helper:this.helper,position:this.position,size:this.size,originalSize:this.originalSize,originalPosition:this.originalPosition}}}),e.ui.plugin.add("resizable","animate",{stop:function(t){var i=e(this).resizable("instance"),s=i.options,n=i._proportionallyResizeElements,a=n.length&&/textarea/i.test(n[0].nodeName),o=a&&i._hasScroll(n[0],"left")?0:i.sizeDiff.height,r=a?0:i.sizeDiff.width,h={width:i.size.width-r,height:i.size.height-o},l=parseInt(i.element.css("left"),10)+(i.position.left-i.originalPosition.left)||null,u=parseInt(i.element.css("top"),10)+(i.position.top-i.originalPosition.top)||null;i.element.animate(e.extend(h,u&&l?{top:u,left:l}:{}),{duration:s.animateDuration,easing:s.animateEasing,step:function(){var s={width:parseInt(i.element.css("width"),10),height:parseInt(i.element.css("height"),10),top:parseInt(i.element.css("top"),10),left:parseInt(i.element.css("left"),10)};n&&n.length&&e(n[0]).css({width:s.width,height:s.height}),i._updateCache(s),i._propagate("resize",t)}})}}),e.ui.plugin.add("resizable","containment",{start:function(){var t,i,s,n,a,o,r,h=e(this).resizable("instance"),l=h.options,u=h.element,d=l.containment,c=d instanceof e?d.get(0):/parent/.test(d)?u.parent().get(0):d;c&&(h.containerElement=e(c),/document/.test(d)||d===document?(h.containerOffset={left:0,top:0},h.containerPosition={left:0,top:0},h.parentData={element:e(document),left:0,top:0,width:e(document).width(),height:e(document).height()||document.body.parentNode.scrollHeight}):(t=e(c),i=[],e(["Top","Right","Left","Bottom"]).each(function(e,s){i[e]=h._num(t.css("padding"+s))}),h.containerOffset=t.offset(),h.containerPosition=t.position(),h.containerSize={height:t.innerHeight()-i[3],width:t.innerWidth()-i[1]},s=h.containerOffset,n=h.containerSize.height,a=h.containerSize.width,o=h._hasScroll(c,"left")?c.scrollWidth:a,r=h._hasScroll(c)?c.scrollHeight:n,h.parentData={element:c,left:s.left,top:s.top,width:o,height:r}))},resize:function(t){var i,s,n,a,o=e(this).resizable("instance"),r=o.options,h=o.containerOffset,l=o.position,u=o._aspectRatio||t.shiftKey,d={top:0,left:0},c=o.containerElement,p=!0;c[0]!==document&&/static/.test(c.css("position"))&&(d=h),l.left<(o._helper?h.left:0)&&(o.size.width=o.size.width+(o._helper?o.position.left-h.left:o.position.left-d.left),u&&(o.size.height=o.size.width/o.aspectRatio,p=!1),o.position.left=r.helper?h.left:0),l.top<(o._helper?h.top:0)&&(o.size.height=o.size.height+(o._helper?o.position.top-h.top:o.position.top),u&&(o.size.width=o.size.height*o.aspectRatio,p=!1),o.position.top=o._helper?h.top:0),n=o.containerElement.get(0)===o.element.parent().get(0),a=/relative|absolute/.test(o.containerElement.css("position")),n&&a?(o.offset.left=o.parentData.left+o.position.left,o.offset.top=o.parentData.top+o.position.top):(o.offset.left=o.element.offset().left,o.offset.top=o.element.offset().top),i=Math.abs(o.sizeDiff.width+(o._helper?o.offset.left-d.left:o.offset.left-h.left)),s=Math.abs(o.sizeDiff.height+(o._helper?o.offset.top-d.top:o.offset.top-h.top)),i+o.size.width>=o.parentData.width&&(o.size.width=o.parentData.width-i,u&&(o.size.height=o.size.width/o.aspectRatio,p=!1)),s+o.size.height>=o.parentData.height&&(o.size.height=o.parentData.height-s,u&&(o.size.width=o.size.height*o.aspectRatio,p=!1)),p||(o.position.left=o.prevPosition.left,o.position.top=o.prevPosition.top,o.size.width=o.prevSize.width,o.size.height=o.prevSize.height)},stop:function(){var t=e(this).resizable("instance"),i=t.options,s=t.containerOffset,n=t.containerPosition,a=t.containerElement,o=e(t.helper),r=o.offset(),h=o.outerWidth()-t.sizeDiff.width,l=o.outerHeight()-t.sizeDiff.height;t._helper&&!i.animate&&/relative/.test(a.css("position"))&&e(this).css({left:r.left-n.left-s.left,width:h,height:l}),t._helper&&!i.animate&&/static/.test(a.css("position"))&&e(this).css({left:r.left-n.left-s.left,width:h,height:l})}}),e.ui.plugin.add("resizable","alsoResize",{start:function(){var t=e(this).resizable("instance"),i=t.options;e(i.alsoResize).each(function(){var t=e(this);t.data("ui-resizable-alsoresize",{width:parseInt(t.width(),10),height:parseInt(t.height(),10),left:parseInt(t.css("left"),10),top:parseInt(t.css("top"),10)})})},resize:function(t,i){var s=e(this).resizable("instance"),n=s.options,a=s.originalSize,o=s.originalPosition,r={height:s.size.height-a.height||0,width:s.size.width-a.width||0,top:s.position.top-o.top||0,left:s.position.left-o.left||0};e(n.alsoResize).each(function(){var t=e(this),s=e(this).data("ui-resizable-alsoresize"),n={},a=t.parents(i.originalElement[0]).length?["width","height"]:["width","height","top","left"];e.each(a,function(e,t){var i=(s[t]||0)+(r[t]||0);i&&i>=0&&(n[t]=i||null)}),t.css(n)})},stop:function(){e(this).removeData("resizable-alsoresize")}}),e.ui.plugin.add("resizable","ghost",{start:function(){var t=e(this).resizable("instance"),i=t.options,s=t.size;t.ghost=t.originalElement.clone(),t.ghost.css({opacity:.25,display:"block",position:"relative",height:s.height,width:s.width,margin:0,left:0,top:0}).addClass("ui-resizable-ghost").addClass("string"==typeof i.ghost?i.ghost:""),t.ghost.appendTo(t.helper)},resize:function(){var t=e(this).resizable("instance");t.ghost&&t.ghost.css({position:"relative",height:t.size.height,width:t.size.width})},stop:function(){var t=e(this).resizable("instance");t.ghost&&t.helper&&t.helper.get(0).removeChild(t.ghost.get(0))}}),e.ui.plugin.add("resizable","grid",{resize:function(){var t,i=e(this).resizable("instance"),s=i.options,n=i.size,a=i.originalSize,o=i.originalPosition,r=i.axis,h="number"==typeof s.grid?[s.grid,s.grid]:s.grid,l=h[0]||1,u=h[1]||1,d=Math.round((n.width-a.width)/l)*l,c=Math.round((n.height-a.height)/u)*u,p=a.width+d,f=a.height+c,m=s.maxWidth&&p>s.maxWidth,g=s.maxHeight&&f>s.maxHeight,v=s.minWidth&&s.minWidth>p,y=s.minHeight&&s.minHeight>f;s.grid=h,v&&(p+=l),y&&(f+=u),m&&(p-=l),g&&(f-=u),/^(se|s|e)$/.test(r)?(i.size.width=p,i.size.height=f):/^(ne)$/.test(r)?(i.size.width=p,i.size.height=f,i.position.top=o.top-c):/^(sw)$/.test(r)?(i.size.width=p,i.size.height=f,i.position.left=o.left-d):((0>=f-u||0>=p-l)&&(t=i._getPaddingPlusBorderDimensions(this)),f-u>0?(i.size.height=f,i.position.top=o.top-c):(f=u-t.height,i.size.height=f,i.position.top=o.top+a.height-f),p-l>0?(i.size.width=p,i.position.left=o.left-d):(p=l-t.width,i.size.width=p,i.position.left=o.left+a.width-p))}}),e.ui.resizable,e.widget("ui.dialog",{version:"1.11.4",options:{appendTo:"body",autoOpen:!0,buttons:[],closeOnEscape:!0,closeText:"Close",dialogClass:"",draggable:!0,hide:null,height:"auto",maxHeight:null,maxWidth:null,minHeight:150,minWidth:150,modal:!1,position:{my:"center",at:"center",of:window,collision:"fit",using:function(t){var i=e(this).css(t).offset().top;0>i&&e(this).css("top",t.top-i)}},resizable:!0,show:null,title:null,width:300,beforeClose:null,close:null,drag:null,dragStart:null,dragStop:null,focus:null,open:null,resize:null,resizeStart:null,resizeStop:null},sizeRelatedOptions:{buttons:!0,height:!0,maxHeight:!0,maxWidth:!0,minHeight:!0,minWidth:!0,width:!0},resizableRelatedOptions:{maxHeight:!0,maxWidth:!0,minHeight:!0,minWidth:!0},_create:function(){this.originalCss={display:this.element[0].style.display,width:this.element[0].style.width,minHeight:this.element[0].style.minHeight,maxHeight:this.element[0].style.maxHeight,height:this.element[0].style.height},this.originalPosition={parent:this.element.parent(),index:this.element.parent().children().index(this.element)},this.originalTitle=this.element.attr("title"),this.options.title=this.options.title||this.originalTitle,this._createWrapper(),this.element.show().removeAttr("title").addClass("ui-dialog-content ui-widget-content").appendTo(this.uiDialog),this._createTitlebar(),this._createButtonPane(),this.options.draggable&&e.fn.draggable&&this._makeDraggable(),this.options.resizable&&e.fn.resizable&&this._makeResizable(),this._isOpen=!1,this._trackFocus()},_init:function(){this.options.autoOpen&&this.open()},_appendTo:function(){var t=this.options.appendTo;return t&&(t.jquery||t.nodeType)?e(t):this.document.find(t||"body").eq(0)},_destroy:function(){var e,t=this.originalPosition;this._untrackInstance(),this._destroyOverlay(),this.element.removeUniqueId().removeClass("ui-dialog-content ui-widget-content").css(this.originalCss).detach(),this.uiDialog.stop(!0,!0).remove(),this.originalTitle&&this.element.attr("title",this.originalTitle),e=t.parent.children().eq(t.index),e.length&&e[0]!==this.element[0]?e.before(this.element):t.parent.append(this.element)},widget:function(){return this.uiDialog},disable:e.noop,enable:e.noop,close:function(t){var i,s=this;if(this._isOpen&&this._trigger("beforeClose",t)!==!1){if(this._isOpen=!1,this._focusedElement=null,this._destroyOverlay(),this._untrackInstance(),!this.opener.filter(":focusable").focus().length)try{i=this.document[0].activeElement,i&&"body"!==i.nodeName.toLowerCase()&&e(i).blur()}catch(n){}this._hide(this.uiDialog,this.options.hide,function(){s._trigger("close",t)})}},isOpen:function(){return this._isOpen},moveToTop:function(){this._moveToTop()},_moveToTop:function(t,i){var s=!1,n=this.uiDialog.siblings(".ui-front:visible").map(function(){return+e(this).css("z-index")}).get(),a=Math.max.apply(null,n);return a>=+this.uiDialog.css("z-index")&&(this.uiDialog.css("z-index",a+1),s=!0),s&&!i&&this._trigger("focus",t),s},open:function(){var t=this;return this._isOpen?(this._moveToTop()&&this._focusTabbable(),void 0):(this._isOpen=!0,this.opener=e(this.document[0].activeElement),this._size(),this._position(),this._createOverlay(),this._moveToTop(null,!0),this.overlay&&this.overlay.css("z-index",this.uiDialog.css("z-index")-1),this._show(this.uiDialog,this.options.show,function(){t._focusTabbable(),t._trigger("focus")}),this._makeFocusTarget(),this._trigger("open"),void 0)},_focusTabbable:function(){var e=this._focusedElement;e||(e=this.element.find("[autofocus]")),e.length||(e=this.element.find(":tabbable")),e.length||(e=this.uiDialogButtonPane.find(":tabbable")),e.length||(e=this.uiDialogTitlebarClose.filter(":tabbable")),e.length||(e=this.uiDialog),e.eq(0).focus()},_keepFocus:function(t){function i(){var t=this.document[0].activeElement,i=this.uiDialog[0]===t||e.contains(this.uiDialog[0],t);i||this._focusTabbable()}t.preventDefault(),i.call(this),this._delay(i)},_createWrapper:function(){this.uiDialog=e("<div>").addClass("ui-dialog ui-widget ui-widget-content ui-corner-all ui-front "+this.options.dialogClass).hide().attr({tabIndex:-1,role:"dialog"}).appendTo(this._appendTo()),this._on(this.uiDialog,{keydown:function(t){if(this.options.closeOnEscape&&!t.isDefaultPrevented()&&t.keyCode&&t.keyCode===e.ui.keyCode.ESCAPE)return t.preventDefault(),this.close(t),void 0;
if(t.keyCode===e.ui.keyCode.TAB&&!t.isDefaultPrevented()){var i=this.uiDialog.find(":tabbable"),s=i.filter(":first"),n=i.filter(":last");t.target!==n[0]&&t.target!==this.uiDialog[0]||t.shiftKey?t.target!==s[0]&&t.target!==this.uiDialog[0]||!t.shiftKey||(this._delay(function(){n.focus()}),t.preventDefault()):(this._delay(function(){s.focus()}),t.preventDefault())}},mousedown:function(e){this._moveToTop(e)&&this._focusTabbable()}}),this.element.find("[aria-describedby]").length||this.uiDialog.attr({"aria-describedby":this.element.uniqueId().attr("id")})},_createTitlebar:function(){var t;this.uiDialogTitlebar=e("<div>").addClass("ui-dialog-titlebar ui-widget-header ui-corner-all ui-helper-clearfix").prependTo(this.uiDialog),this._on(this.uiDialogTitlebar,{mousedown:function(t){e(t.target).closest(".ui-dialog-titlebar-close")||this.uiDialog.focus()}}),this.uiDialogTitlebarClose=e("<button type='button'></button>").button({label:this.options.closeText,icons:{primary:"ui-icon-closethick"},text:!1}).addClass("ui-dialog-titlebar-close").appendTo(this.uiDialogTitlebar),this._on(this.uiDialogTitlebarClose,{click:function(e){e.preventDefault(),this.close(e)}}),t=e("<span>").uniqueId().addClass("ui-dialog-title").prependTo(this.uiDialogTitlebar),this._title(t),this.uiDialog.attr({"aria-labelledby":t.attr("id")})},_title:function(e){this.options.title||e.html("&#160;"),e.text(this.options.title)},_createButtonPane:function(){this.uiDialogButtonPane=e("<div>").addClass("ui-dialog-buttonpane ui-widget-content ui-helper-clearfix"),this.uiButtonSet=e("<div>").addClass("ui-dialog-buttonset").appendTo(this.uiDialogButtonPane),this._createButtons()},_createButtons:function(){var t=this,i=this.options.buttons;return this.uiDialogButtonPane.remove(),this.uiButtonSet.empty(),e.isEmptyObject(i)||e.isArray(i)&&!i.length?(this.uiDialog.removeClass("ui-dialog-buttons"),void 0):(e.each(i,function(i,s){var n,a;s=e.isFunction(s)?{click:s,text:i}:s,s=e.extend({type:"button"},s),n=s.click,s.click=function(){n.apply(t.element[0],arguments)},a={icons:s.icons,text:s.showText},delete s.icons,delete s.showText,e("<button></button>",s).button(a).appendTo(t.uiButtonSet)}),this.uiDialog.addClass("ui-dialog-buttons"),this.uiDialogButtonPane.appendTo(this.uiDialog),void 0)},_makeDraggable:function(){function t(e){return{position:e.position,offset:e.offset}}var i=this,s=this.options;this.uiDialog.draggable({cancel:".ui-dialog-content, .ui-dialog-titlebar-close",handle:".ui-dialog-titlebar",containment:"document",start:function(s,n){e(this).addClass("ui-dialog-dragging"),i._blockFrames(),i._trigger("dragStart",s,t(n))},drag:function(e,s){i._trigger("drag",e,t(s))},stop:function(n,a){var o=a.offset.left-i.document.scrollLeft(),r=a.offset.top-i.document.scrollTop();s.position={my:"left top",at:"left"+(o>=0?"+":"")+o+" "+"top"+(r>=0?"+":"")+r,of:i.window},e(this).removeClass("ui-dialog-dragging"),i._unblockFrames(),i._trigger("dragStop",n,t(a))}})},_makeResizable:function(){function t(e){return{originalPosition:e.originalPosition,originalSize:e.originalSize,position:e.position,size:e.size}}var i=this,s=this.options,n=s.resizable,a=this.uiDialog.css("position"),o="string"==typeof n?n:"n,e,s,w,se,sw,ne,nw";this.uiDialog.resizable({cancel:".ui-dialog-content",containment:"document",alsoResize:this.element,maxWidth:s.maxWidth,maxHeight:s.maxHeight,minWidth:s.minWidth,minHeight:this._minHeight(),handles:o,start:function(s,n){e(this).addClass("ui-dialog-resizing"),i._blockFrames(),i._trigger("resizeStart",s,t(n))},resize:function(e,s){i._trigger("resize",e,t(s))},stop:function(n,a){var o=i.uiDialog.offset(),r=o.left-i.document.scrollLeft(),h=o.top-i.document.scrollTop();s.height=i.uiDialog.height(),s.width=i.uiDialog.width(),s.position={my:"left top",at:"left"+(r>=0?"+":"")+r+" "+"top"+(h>=0?"+":"")+h,of:i.window},e(this).removeClass("ui-dialog-resizing"),i._unblockFrames(),i._trigger("resizeStop",n,t(a))}}).css("position",a)},_trackFocus:function(){this._on(this.widget(),{focusin:function(t){this._makeFocusTarget(),this._focusedElement=e(t.target)}})},_makeFocusTarget:function(){this._untrackInstance(),this._trackingInstances().unshift(this)},_untrackInstance:function(){var t=this._trackingInstances(),i=e.inArray(this,t);-1!==i&&t.splice(i,1)},_trackingInstances:function(){var e=this.document.data("ui-dialog-instances");return e||(e=[],this.document.data("ui-dialog-instances",e)),e},_minHeight:function(){var e=this.options;return"auto"===e.height?e.minHeight:Math.min(e.minHeight,e.height)},_position:function(){var e=this.uiDialog.is(":visible");e||this.uiDialog.show(),this.uiDialog.position(this.options.position),e||this.uiDialog.hide()},_setOptions:function(t){var i=this,s=!1,n={};e.each(t,function(e,t){i._setOption(e,t),e in i.sizeRelatedOptions&&(s=!0),e in i.resizableRelatedOptions&&(n[e]=t)}),s&&(this._size(),this._position()),this.uiDialog.is(":data(ui-resizable)")&&this.uiDialog.resizable("option",n)},_setOption:function(e,t){var i,s,n=this.uiDialog;"dialogClass"===e&&n.removeClass(this.options.dialogClass).addClass(t),"disabled"!==e&&(this._super(e,t),"appendTo"===e&&this.uiDialog.appendTo(this._appendTo()),"buttons"===e&&this._createButtons(),"closeText"===e&&this.uiDialogTitlebarClose.button({label:""+t}),"draggable"===e&&(i=n.is(":data(ui-draggable)"),i&&!t&&n.draggable("destroy"),!i&&t&&this._makeDraggable()),"position"===e&&this._position(),"resizable"===e&&(s=n.is(":data(ui-resizable)"),s&&!t&&n.resizable("destroy"),s&&"string"==typeof t&&n.resizable("option","handles",t),s||t===!1||this._makeResizable()),"title"===e&&this._title(this.uiDialogTitlebar.find(".ui-dialog-title")))},_size:function(){var e,t,i,s=this.options;this.element.show().css({width:"auto",minHeight:0,maxHeight:"none",height:0}),s.minWidth>s.width&&(s.width=s.minWidth),e=this.uiDialog.css({height:"auto",width:s.width}).outerHeight(),t=Math.max(0,s.minHeight-e),i="number"==typeof s.maxHeight?Math.max(0,s.maxHeight-e):"none","auto"===s.height?this.element.css({minHeight:t,maxHeight:i,height:"auto"}):this.element.height(Math.max(0,s.height-e)),this.uiDialog.is(":data(ui-resizable)")&&this.uiDialog.resizable("option","minHeight",this._minHeight())},_blockFrames:function(){this.iframeBlocks=this.document.find("iframe").map(function(){var t=e(this);return e("<div>").css({position:"absolute",width:t.outerWidth(),height:t.outerHeight()}).appendTo(t.parent()).offset(t.offset())[0]})},_unblockFrames:function(){this.iframeBlocks&&(this.iframeBlocks.remove(),delete this.iframeBlocks)},_allowInteraction:function(t){return e(t.target).closest(".ui-dialog").length?!0:!!e(t.target).closest(".ui-datepicker").length},_createOverlay:function(){if(this.options.modal){var t=!0;this._delay(function(){t=!1}),this.document.data("ui-dialog-overlays")||this._on(this.document,{focusin:function(e){t||this._allowInteraction(e)||(e.preventDefault(),this._trackingInstances()[0]._focusTabbable())}}),this.overlay=e("<div>").addClass("ui-widget-overlay ui-front").appendTo(this._appendTo()),this._on(this.overlay,{mousedown:"_keepFocus"}),this.document.data("ui-dialog-overlays",(this.document.data("ui-dialog-overlays")||0)+1)}},_destroyOverlay:function(){if(this.options.modal&&this.overlay){var e=this.document.data("ui-dialog-overlays")-1;e?this.document.data("ui-dialog-overlays",e):this.document.unbind("focusin").removeData("ui-dialog-overlays"),this.overlay.remove(),this.overlay=null}}}),e.widget("ui.droppable",{version:"1.11.4",widgetEventPrefix:"drop",options:{accept:"*",activeClass:!1,addClasses:!0,greedy:!1,hoverClass:!1,scope:"default",tolerance:"intersect",activate:null,deactivate:null,drop:null,out:null,over:null},_create:function(){var t,i=this.options,s=i.accept;this.isover=!1,this.isout=!0,this.accept=e.isFunction(s)?s:function(e){return e.is(s)},this.proportions=function(){return arguments.length?(t=arguments[0],void 0):t?t:t={width:this.element[0].offsetWidth,height:this.element[0].offsetHeight}},this._addToManager(i.scope),i.addClasses&&this.element.addClass("ui-droppable")},_addToManager:function(t){e.ui.ddmanager.droppables[t]=e.ui.ddmanager.droppables[t]||[],e.ui.ddmanager.droppables[t].push(this)},_splice:function(e){for(var t=0;e.length>t;t++)e[t]===this&&e.splice(t,1)},_destroy:function(){var t=e.ui.ddmanager.droppables[this.options.scope];this._splice(t),this.element.removeClass("ui-droppable ui-droppable-disabled")},_setOption:function(t,i){if("accept"===t)this.accept=e.isFunction(i)?i:function(e){return e.is(i)};else if("scope"===t){var s=e.ui.ddmanager.droppables[this.options.scope];this._splice(s),this._addToManager(i)}this._super(t,i)},_activate:function(t){var i=e.ui.ddmanager.current;this.options.activeClass&&this.element.addClass(this.options.activeClass),i&&this._trigger("activate",t,this.ui(i))},_deactivate:function(t){var i=e.ui.ddmanager.current;this.options.activeClass&&this.element.removeClass(this.options.activeClass),i&&this._trigger("deactivate",t,this.ui(i))},_over:function(t){var i=e.ui.ddmanager.current;i&&(i.currentItem||i.element)[0]!==this.element[0]&&this.accept.call(this.element[0],i.currentItem||i.element)&&(this.options.hoverClass&&this.element.addClass(this.options.hoverClass),this._trigger("over",t,this.ui(i)))},_out:function(t){var i=e.ui.ddmanager.current;i&&(i.currentItem||i.element)[0]!==this.element[0]&&this.accept.call(this.element[0],i.currentItem||i.element)&&(this.options.hoverClass&&this.element.removeClass(this.options.hoverClass),this._trigger("out",t,this.ui(i)))},_drop:function(t,i){var s=i||e.ui.ddmanager.current,n=!1;return s&&(s.currentItem||s.element)[0]!==this.element[0]?(this.element.find(":data(ui-droppable)").not(".ui-draggable-dragging").each(function(){var i=e(this).droppable("instance");return i.options.greedy&&!i.options.disabled&&i.options.scope===s.options.scope&&i.accept.call(i.element[0],s.currentItem||s.element)&&e.ui.intersect(s,e.extend(i,{offset:i.element.offset()}),i.options.tolerance,t)?(n=!0,!1):void 0}),n?!1:this.accept.call(this.element[0],s.currentItem||s.element)?(this.options.activeClass&&this.element.removeClass(this.options.activeClass),this.options.hoverClass&&this.element.removeClass(this.options.hoverClass),this._trigger("drop",t,this.ui(s)),this.element):!1):!1},ui:function(e){return{draggable:e.currentItem||e.element,helper:e.helper,position:e.position,offset:e.positionAbs}}}),e.ui.intersect=function(){function e(e,t,i){return e>=t&&t+i>e}return function(t,i,s,n){if(!i.offset)return!1;var a=(t.positionAbs||t.position.absolute).left+t.margins.left,o=(t.positionAbs||t.position.absolute).top+t.margins.top,r=a+t.helperProportions.width,h=o+t.helperProportions.height,l=i.offset.left,u=i.offset.top,d=l+i.proportions().width,c=u+i.proportions().height;switch(s){case"fit":return a>=l&&d>=r&&o>=u&&c>=h;case"intersect":return a+t.helperProportions.width/2>l&&d>r-t.helperProportions.width/2&&o+t.helperProportions.height/2>u&&c>h-t.helperProportions.height/2;case"pointer":return e(n.pageY,u,i.proportions().height)&&e(n.pageX,l,i.proportions().width);case"touch":return(o>=u&&c>=o||h>=u&&c>=h||u>o&&h>c)&&(a>=l&&d>=a||r>=l&&d>=r||l>a&&r>d);default:return!1}}}(),e.ui.ddmanager={current:null,droppables:{"default":[]},prepareOffsets:function(t,i){var s,n,a=e.ui.ddmanager.droppables[t.options.scope]||[],o=i?i.type:null,r=(t.currentItem||t.element).find(":data(ui-droppable)").addBack();e:for(s=0;a.length>s;s++)if(!(a[s].options.disabled||t&&!a[s].accept.call(a[s].element[0],t.currentItem||t.element))){for(n=0;r.length>n;n++)if(r[n]===a[s].element[0]){a[s].proportions().height=0;continue e}a[s].visible="none"!==a[s].element.css("display"),a[s].visible&&("mousedown"===o&&a[s]._activate.call(a[s],i),a[s].offset=a[s].element.offset(),a[s].proportions({width:a[s].element[0].offsetWidth,height:a[s].element[0].offsetHeight}))}},drop:function(t,i){var s=!1;return e.each((e.ui.ddmanager.droppables[t.options.scope]||[]).slice(),function(){this.options&&(!this.options.disabled&&this.visible&&e.ui.intersect(t,this,this.options.tolerance,i)&&(s=this._drop.call(this,i)||s),!this.options.disabled&&this.visible&&this.accept.call(this.element[0],t.currentItem||t.element)&&(this.isout=!0,this.isover=!1,this._deactivate.call(this,i)))}),s},dragStart:function(t,i){t.element.parentsUntil("body").bind("scroll.droppable",function(){t.options.refreshPositions||e.ui.ddmanager.prepareOffsets(t,i)})},drag:function(t,i){t.options.refreshPositions&&e.ui.ddmanager.prepareOffsets(t,i),e.each(e.ui.ddmanager.droppables[t.options.scope]||[],function(){if(!this.options.disabled&&!this.greedyChild&&this.visible){var s,n,a,o=e.ui.intersect(t,this,this.options.tolerance,i),r=!o&&this.isover?"isout":o&&!this.isover?"isover":null;r&&(this.options.greedy&&(n=this.options.scope,a=this.element.parents(":data(ui-droppable)").filter(function(){return e(this).droppable("instance").options.scope===n}),a.length&&(s=e(a[0]).droppable("instance"),s.greedyChild="isover"===r)),s&&"isover"===r&&(s.isover=!1,s.isout=!0,s._out.call(s,i)),this[r]=!0,this["isout"===r?"isover":"isout"]=!1,this["isover"===r?"_over":"_out"].call(this,i),s&&"isout"===r&&(s.isout=!1,s.isover=!0,s._over.call(s,i)))}})},dragStop:function(t,i){t.element.parentsUntil("body").unbind("scroll.droppable"),t.options.refreshPositions||e.ui.ddmanager.prepareOffsets(t,i)}},e.ui.droppable;var y="ui-effects-",b=e;e.effects={effect:{}},function(e,t){function i(e,t,i){var s=d[t.type]||{};return null==e?i||!t.def?null:t.def:(e=s.floor?~~e:parseFloat(e),isNaN(e)?t.def:s.mod?(e+s.mod)%s.mod:0>e?0:e>s.max?s.max:e)}function s(i){var s=l(),n=s._rgba=[];return i=i.toLowerCase(),f(h,function(e,a){var o,r=a.re.exec(i),h=r&&a.parse(r),l=a.space||"rgba";return h?(o=s[l](h),s[u[l].cache]=o[u[l].cache],n=s._rgba=o._rgba,!1):t}),n.length?("0,0,0,0"===n.join()&&e.extend(n,a.transparent),s):a[i]}function n(e,t,i){return i=(i+1)%1,1>6*i?e+6*(t-e)*i:1>2*i?t:2>3*i?e+6*(t-e)*(2/3-i):e}var a,o="backgroundColor borderBottomColor borderLeftColor borderRightColor borderTopColor color columnRuleColor outlineColor textDecorationColor textEmphasisColor",r=/^([\-+])=\s*(\d+\.?\d*)/,h=[{re:/rgba?\(\s*(\d{1,3})\s*,\s*(\d{1,3})\s*,\s*(\d{1,3})\s*(?:,\s*(\d?(?:\.\d+)?)\s*)?\)/,parse:function(e){return[e[1],e[2],e[3],e[4]]}},{re:/rgba?\(\s*(\d+(?:\.\d+)?)\%\s*,\s*(\d+(?:\.\d+)?)\%\s*,\s*(\d+(?:\.\d+)?)\%\s*(?:,\s*(\d?(?:\.\d+)?)\s*)?\)/,parse:function(e){return[2.55*e[1],2.55*e[2],2.55*e[3],e[4]]}},{re:/#([a-f0-9]{2})([a-f0-9]{2})([a-f0-9]{2})/,parse:function(e){return[parseInt(e[1],16),parseInt(e[2],16),parseInt(e[3],16)]}},{re:/#([a-f0-9])([a-f0-9])([a-f0-9])/,parse:function(e){return[parseInt(e[1]+e[1],16),parseInt(e[2]+e[2],16),parseInt(e[3]+e[3],16)]}},{re:/hsla?\(\s*(\d+(?:\.\d+)?)\s*,\s*(\d+(?:\.\d+)?)\%\s*,\s*(\d+(?:\.\d+)?)\%\s*(?:,\s*(\d?(?:\.\d+)?)\s*)?\)/,space:"hsla",parse:function(e){return[e[1],e[2]/100,e[3]/100,e[4]]}}],l=e.Color=function(t,i,s,n){return new e.Color.fn.parse(t,i,s,n)},u={rgba:{props:{red:{idx:0,type:"byte"},green:{idx:1,type:"byte"},blue:{idx:2,type:"byte"}}},hsla:{props:{hue:{idx:0,type:"degrees"},saturation:{idx:1,type:"percent"},lightness:{idx:2,type:"percent"}}}},d={"byte":{floor:!0,max:255},percent:{max:1},degrees:{mod:360,floor:!0}},c=l.support={},p=e("<p>")[0],f=e.each;p.style.cssText="background-color:rgba(1,1,1,.5)",c.rgba=p.style.backgroundColor.indexOf("rgba")>-1,f(u,function(e,t){t.cache="_"+e,t.props.alpha={idx:3,type:"percent",def:1}}),l.fn=e.extend(l.prototype,{parse:function(n,o,r,h){if(n===t)return this._rgba=[null,null,null,null],this;(n.jquery||n.nodeType)&&(n=e(n).css(o),o=t);var d=this,c=e.type(n),p=this._rgba=[];return o!==t&&(n=[n,o,r,h],c="array"),"string"===c?this.parse(s(n)||a._default):"array"===c?(f(u.rgba.props,function(e,t){p[t.idx]=i(n[t.idx],t)}),this):"object"===c?(n instanceof l?f(u,function(e,t){n[t.cache]&&(d[t.cache]=n[t.cache].slice())}):f(u,function(t,s){var a=s.cache;f(s.props,function(e,t){if(!d[a]&&s.to){if("alpha"===e||null==n[e])return;d[a]=s.to(d._rgba)}d[a][t.idx]=i(n[e],t,!0)}),d[a]&&0>e.inArray(null,d[a].slice(0,3))&&(d[a][3]=1,s.from&&(d._rgba=s.from(d[a])))}),this):t},is:function(e){var i=l(e),s=!0,n=this;return f(u,function(e,a){var o,r=i[a.cache];return r&&(o=n[a.cache]||a.to&&a.to(n._rgba)||[],f(a.props,function(e,i){return null!=r[i.idx]?s=r[i.idx]===o[i.idx]:t})),s}),s},_space:function(){var e=[],t=this;return f(u,function(i,s){t[s.cache]&&e.push(i)}),e.pop()},transition:function(e,t){var s=l(e),n=s._space(),a=u[n],o=0===this.alpha()?l("transparent"):this,r=o[a.cache]||a.to(o._rgba),h=r.slice();return s=s[a.cache],f(a.props,function(e,n){var a=n.idx,o=r[a],l=s[a],u=d[n.type]||{};null!==l&&(null===o?h[a]=l:(u.mod&&(l-o>u.mod/2?o+=u.mod:o-l>u.mod/2&&(o-=u.mod)),h[a]=i((l-o)*t+o,n)))}),this[n](h)},blend:function(t){if(1===this._rgba[3])return this;var i=this._rgba.slice(),s=i.pop(),n=l(t)._rgba;return l(e.map(i,function(e,t){return(1-s)*n[t]+s*e}))},toRgbaString:function(){var t="rgba(",i=e.map(this._rgba,function(e,t){return null==e?t>2?1:0:e});return 1===i[3]&&(i.pop(),t="rgb("),t+i.join()+")"},toHslaString:function(){var t="hsla(",i=e.map(this.hsla(),function(e,t){return null==e&&(e=t>2?1:0),t&&3>t&&(e=Math.round(100*e)+"%"),e});return 1===i[3]&&(i.pop(),t="hsl("),t+i.join()+")"},toHexString:function(t){var i=this._rgba.slice(),s=i.pop();return t&&i.push(~~(255*s)),"#"+e.map(i,function(e){return e=(e||0).toString(16),1===e.length?"0"+e:e}).join("")},toString:function(){return 0===this._rgba[3]?"transparent":this.toRgbaString()}}),l.fn.parse.prototype=l.fn,u.hsla.to=function(e){if(null==e[0]||null==e[1]||null==e[2])return[null,null,null,e[3]];var t,i,s=e[0]/255,n=e[1]/255,a=e[2]/255,o=e[3],r=Math.max(s,n,a),h=Math.min(s,n,a),l=r-h,u=r+h,d=.5*u;return t=h===r?0:s===r?60*(n-a)/l+360:n===r?60*(a-s)/l+120:60*(s-n)/l+240,i=0===l?0:.5>=d?l/u:l/(2-u),[Math.round(t)%360,i,d,null==o?1:o]},u.hsla.from=function(e){if(null==e[0]||null==e[1]||null==e[2])return[null,null,null,e[3]];var t=e[0]/360,i=e[1],s=e[2],a=e[3],o=.5>=s?s*(1+i):s+i-s*i,r=2*s-o;return[Math.round(255*n(r,o,t+1/3)),Math.round(255*n(r,o,t)),Math.round(255*n(r,o,t-1/3)),a]},f(u,function(s,n){var a=n.props,o=n.cache,h=n.to,u=n.from;l.fn[s]=function(s){if(h&&!this[o]&&(this[o]=h(this._rgba)),s===t)return this[o].slice();var n,r=e.type(s),d="array"===r||"object"===r?s:arguments,c=this[o].slice();return f(a,function(e,t){var s=d["object"===r?e:t.idx];null==s&&(s=c[t.idx]),c[t.idx]=i(s,t)}),u?(n=l(u(c)),n[o]=c,n):l(c)},f(a,function(t,i){l.fn[t]||(l.fn[t]=function(n){var a,o=e.type(n),h="alpha"===t?this._hsla?"hsla":"rgba":s,l=this[h](),u=l[i.idx];return"undefined"===o?u:("function"===o&&(n=n.call(this,u),o=e.type(n)),null==n&&i.empty?this:("string"===o&&(a=r.exec(n),a&&(n=u+parseFloat(a[2])*("+"===a[1]?1:-1))),l[i.idx]=n,this[h](l)))})})}),l.hook=function(t){var i=t.split(" ");f(i,function(t,i){e.cssHooks[i]={set:function(t,n){var a,o,r="";if("transparent"!==n&&("string"!==e.type(n)||(a=s(n)))){if(n=l(a||n),!c.rgba&&1!==n._rgba[3]){for(o="backgroundColor"===i?t.parentNode:t;(""===r||"transparent"===r)&&o&&o.style;)try{r=e.css(o,"backgroundColor"),o=o.parentNode}catch(h){}n=n.blend(r&&"transparent"!==r?r:"_default")}n=n.toRgbaString()}try{t.style[i]=n}catch(h){}}},e.fx.step[i]=function(t){t.colorInit||(t.start=l(t.elem,i),t.end=l(t.end),t.colorInit=!0),e.cssHooks[i].set(t.elem,t.start.transition(t.end,t.pos))}})},l.hook(o),e.cssHooks.borderColor={expand:function(e){var t={};return f(["Top","Right","Bottom","Left"],function(i,s){t["border"+s+"Color"]=e}),t}},a=e.Color.names={aqua:"#00ffff",black:"#000000",blue:"#0000ff",fuchsia:"#ff00ff",gray:"#808080",green:"#008000",lime:"#00ff00",maroon:"#800000",navy:"#000080",olive:"#808000",purple:"#800080",red:"#ff0000",silver:"#c0c0c0",teal:"#008080",white:"#ffffff",yellow:"#ffff00",transparent:[null,null,null,0],_default:"#ffffff"}}(b),function(){function t(t){var i,s,n=t.ownerDocument.defaultView?t.ownerDocument.defaultView.getComputedStyle(t,null):t.currentStyle,a={};if(n&&n.length&&n[0]&&n[n[0]])for(s=n.length;s--;)i=n[s],"string"==typeof n[i]&&(a[e.camelCase(i)]=n[i]);else for(i in n)"string"==typeof n[i]&&(a[i]=n[i]);return a}function i(t,i){var s,a,o={};for(s in i)a=i[s],t[s]!==a&&(n[s]||(e.fx.step[s]||!isNaN(parseFloat(a)))&&(o[s]=a));return o}var s=["add","remove","toggle"],n={border:1,borderBottom:1,borderColor:1,borderLeft:1,borderRight:1,borderTop:1,borderWidth:1,margin:1,padding:1};e.each(["borderLeftStyle","borderRightStyle","borderBottomStyle","borderTopStyle"],function(t,i){e.fx.step[i]=function(e){("none"!==e.end&&!e.setAttr||1===e.pos&&!e.setAttr)&&(b.style(e.elem,i,e.end),e.setAttr=!0)}}),e.fn.addBack||(e.fn.addBack=function(e){return this.add(null==e?this.prevObject:this.prevObject.filter(e))}),e.effects.animateClass=function(n,a,o,r){var h=e.speed(a,o,r);return this.queue(function(){var a,o=e(this),r=o.attr("class")||"",l=h.children?o.find("*").addBack():o;l=l.map(function(){var i=e(this);return{el:i,start:t(this)}}),a=function(){e.each(s,function(e,t){n[t]&&o[t+"Class"](n[t])})},a(),l=l.map(function(){return this.end=t(this.el[0]),this.diff=i(this.start,this.end),this}),o.attr("class",r),l=l.map(function(){var t=this,i=e.Deferred(),s=e.extend({},h,{queue:!1,complete:function(){i.resolve(t)}});return this.el.animate(this.diff,s),i.promise()}),e.when.apply(e,l.get()).done(function(){a(),e.each(arguments,function(){var t=this.el;e.each(this.diff,function(e){t.css(e,"")})}),h.complete.call(o[0])})})},e.fn.extend({addClass:function(t){return function(i,s,n,a){return s?e.effects.animateClass.call(this,{add:i},s,n,a):t.apply(this,arguments)}}(e.fn.addClass),removeClass:function(t){return function(i,s,n,a){return arguments.length>1?e.effects.animateClass.call(this,{remove:i},s,n,a):t.apply(this,arguments)}}(e.fn.removeClass),toggleClass:function(t){return function(i,s,n,a,o){return"boolean"==typeof s||void 0===s?n?e.effects.animateClass.call(this,s?{add:i}:{remove:i},n,a,o):t.apply(this,arguments):e.effects.animateClass.call(this,{toggle:i},s,n,a)}}(e.fn.toggleClass),switchClass:function(t,i,s,n,a){return e.effects.animateClass.call(this,{add:i,remove:t},s,n,a)}})}(),function(){function t(t,i,s,n){return e.isPlainObject(t)&&(i=t,t=t.effect),t={effect:t},null==i&&(i={}),e.isFunction(i)&&(n=i,s=null,i={}),("number"==typeof i||e.fx.speeds[i])&&(n=s,s=i,i={}),e.isFunction(s)&&(n=s,s=null),i&&e.extend(t,i),s=s||i.duration,t.duration=e.fx.off?0:"number"==typeof s?s:s in e.fx.speeds?e.fx.speeds[s]:e.fx.speeds._default,t.complete=n||i.complete,t}function i(t){return!t||"number"==typeof t||e.fx.speeds[t]?!0:"string"!=typeof t||e.effects.effect[t]?e.isFunction(t)?!0:"object"!=typeof t||t.effect?!1:!0:!0}e.extend(e.effects,{version:"1.11.4",save:function(e,t){for(var i=0;t.length>i;i++)null!==t[i]&&e.data(y+t[i],e[0].style[t[i]])},restore:function(e,t){var i,s;for(s=0;t.length>s;s++)null!==t[s]&&(i=e.data(y+t[s]),void 0===i&&(i=""),e.css(t[s],i))},setMode:function(e,t){return"toggle"===t&&(t=e.is(":hidden")?"show":"hide"),t},getBaseline:function(e,t){var i,s;switch(e[0]){case"top":i=0;break;case"middle":i=.5;break;case"bottom":i=1;break;default:i=e[0]/t.height}switch(e[1]){case"left":s=0;break;case"center":s=.5;break;case"right":s=1;break;default:s=e[1]/t.width}return{x:s,y:i}},createWrapper:function(t){if(t.parent().is(".ui-effects-wrapper"))return t.parent();var i={width:t.outerWidth(!0),height:t.outerHeight(!0),"float":t.css("float")},s=e("<div></div>").addClass("ui-effects-wrapper").css({fontSize:"100%",background:"transparent",border:"none",margin:0,padding:0}),n={width:t.width(),height:t.height()},a=document.activeElement;try{a.id}catch(o){a=document.body}return t.wrap(s),(t[0]===a||e.contains(t[0],a))&&e(a).focus(),s=t.parent(),"static"===t.css("position")?(s.css({position:"relative"}),t.css({position:"relative"})):(e.extend(i,{position:t.css("position"),zIndex:t.css("z-index")}),e.each(["top","left","bottom","right"],function(e,s){i[s]=t.css(s),isNaN(parseInt(i[s],10))&&(i[s]="auto")}),t.css({position:"relative",top:0,left:0,right:"auto",bottom:"auto"})),t.css(n),s.css(i).show()},removeWrapper:function(t){var i=document.activeElement;return t.parent().is(".ui-effects-wrapper")&&(t.parent().replaceWith(t),(t[0]===i||e.contains(t[0],i))&&e(i).focus()),t},setTransition:function(t,i,s,n){return n=n||{},e.each(i,function(e,i){var a=t.cssUnit(i);a[0]>0&&(n[i]=a[0]*s+a[1])}),n}}),e.fn.extend({effect:function(){function i(t){function i(){e.isFunction(a)&&a.call(n[0]),e.isFunction(t)&&t()}var n=e(this),a=s.complete,r=s.mode;(n.is(":hidden")?"hide"===r:"show"===r)?(n[r](),i()):o.call(n[0],s,i)}var s=t.apply(this,arguments),n=s.mode,a=s.queue,o=e.effects.effect[s.effect];return e.fx.off||!o?n?this[n](s.duration,s.complete):this.each(function(){s.complete&&s.complete.call(this)}):a===!1?this.each(i):this.queue(a||"fx",i)},show:function(e){return function(s){if(i(s))return e.apply(this,arguments);var n=t.apply(this,arguments);return n.mode="show",this.effect.call(this,n)}}(e.fn.show),hide:function(e){return function(s){if(i(s))return e.apply(this,arguments);var n=t.apply(this,arguments);return n.mode="hide",this.effect.call(this,n)}}(e.fn.hide),toggle:function(e){return function(s){if(i(s)||"boolean"==typeof s)return e.apply(this,arguments);var n=t.apply(this,arguments);return n.mode="toggle",this.effect.call(this,n)}}(e.fn.toggle),cssUnit:function(t){var i=this.css(t),s=[];return e.each(["em","px","%","pt"],function(e,t){i.indexOf(t)>0&&(s=[parseFloat(i),t])}),s}})}(),function(){var t={};e.each(["Quad","Cubic","Quart","Quint","Expo"],function(e,i){t[i]=function(t){return Math.pow(t,e+2)}}),e.extend(t,{Sine:function(e){return 1-Math.cos(e*Math.PI/2)},Circ:function(e){return 1-Math.sqrt(1-e*e)},Elastic:function(e){return 0===e||1===e?e:-Math.pow(2,8*(e-1))*Math.sin((80*(e-1)-7.5)*Math.PI/15)},Back:function(e){return e*e*(3*e-2)},Bounce:function(e){for(var t,i=4;((t=Math.pow(2,--i))-1)/11>e;);return 1/Math.pow(4,3-i)-7.5625*Math.pow((3*t-2)/22-e,2)}}),e.each(t,function(t,i){e.easing["easeIn"+t]=i,e.easing["easeOut"+t]=function(e){return 1-i(1-e)},e.easing["easeInOut"+t]=function(e){return.5>e?i(2*e)/2:1-i(-2*e+2)/2}})}(),e.effects,e.effects.effect.blind=function(t,i){var s,n,a,o=e(this),r=/up|down|vertical/,h=/up|left|vertical|horizontal/,l=["position","top","bottom","left","right","height","width"],u=e.effects.setMode(o,t.mode||"hide"),d=t.direction||"up",c=r.test(d),p=c?"height":"width",f=c?"top":"left",m=h.test(d),g={},v="show"===u;o.parent().is(".ui-effects-wrapper")?e.effects.save(o.parent(),l):e.effects.save(o,l),o.show(),s=e.effects.createWrapper(o).css({overflow:"hidden"}),n=s[p](),a=parseFloat(s.css(f))||0,g[p]=v?n:0,m||(o.css(c?"bottom":"right",0).css(c?"top":"left","auto").css({position:"absolute"}),g[f]=v?a:n+a),v&&(s.css(p,0),m||s.css(f,a+n)),s.animate(g,{duration:t.duration,easing:t.easing,queue:!1,complete:function(){"hide"===u&&o.hide(),e.effects.restore(o,l),e.effects.removeWrapper(o),i()}})},e.effects.effect.bounce=function(t,i){var s,n,a,o=e(this),r=["position","top","bottom","left","right","height","width"],h=e.effects.setMode(o,t.mode||"effect"),l="hide"===h,u="show"===h,d=t.direction||"up",c=t.distance,p=t.times||5,f=2*p+(u||l?1:0),m=t.duration/f,g=t.easing,v="up"===d||"down"===d?"top":"left",y="up"===d||"left"===d,b=o.queue(),_=b.length;for((u||l)&&r.push("opacity"),e.effects.save(o,r),o.show(),e.effects.createWrapper(o),c||(c=o["top"===v?"outerHeight":"outerWidth"]()/3),u&&(a={opacity:1},a[v]=0,o.css("opacity",0).css(v,y?2*-c:2*c).animate(a,m,g)),l&&(c/=Math.pow(2,p-1)),a={},a[v]=0,s=0;p>s;s++)n={},n[v]=(y?"-=":"+=")+c,o.animate(n,m,g).animate(a,m,g),c=l?2*c:c/2;l&&(n={opacity:0},n[v]=(y?"-=":"+=")+c,o.animate(n,m,g)),o.queue(function(){l&&o.hide(),e.effects.restore(o,r),e.effects.removeWrapper(o),i()}),_>1&&b.splice.apply(b,[1,0].concat(b.splice(_,f+1))),o.dequeue()},e.effects.effect.clip=function(t,i){var s,n,a,o=e(this),r=["position","top","bottom","left","right","height","width"],h=e.effects.setMode(o,t.mode||"hide"),l="show"===h,u=t.direction||"vertical",d="vertical"===u,c=d?"height":"width",p=d?"top":"left",f={};e.effects.save(o,r),o.show(),s=e.effects.createWrapper(o).css({overflow:"hidden"}),n="IMG"===o[0].tagName?s:o,a=n[c](),l&&(n.css(c,0),n.css(p,a/2)),f[c]=l?a:0,f[p]=l?0:a/2,n.animate(f,{queue:!1,duration:t.duration,easing:t.easing,complete:function(){l||o.hide(),e.effects.restore(o,r),e.effects.removeWrapper(o),i()}})},e.effects.effect.drop=function(t,i){var s,n=e(this),a=["position","top","bottom","left","right","opacity","height","width"],o=e.effects.setMode(n,t.mode||"hide"),r="show"===o,h=t.direction||"left",l="up"===h||"down"===h?"top":"left",u="up"===h||"left"===h?"pos":"neg",d={opacity:r?1:0};e.effects.save(n,a),n.show(),e.effects.createWrapper(n),s=t.distance||n["top"===l?"outerHeight":"outerWidth"](!0)/2,r&&n.css("opacity",0).css(l,"pos"===u?-s:s),d[l]=(r?"pos"===u?"+=":"-=":"pos"===u?"-=":"+=")+s,n.animate(d,{queue:!1,duration:t.duration,easing:t.easing,complete:function(){"hide"===o&&n.hide(),e.effects.restore(n,a),e.effects.removeWrapper(n),i()}})},e.effects.effect.explode=function(t,i){function s(){b.push(this),b.length===d*c&&n()}function n(){p.css({visibility:"visible"}),e(b).remove(),m||p.hide(),i()}var a,o,r,h,l,u,d=t.pieces?Math.round(Math.sqrt(t.pieces)):3,c=d,p=e(this),f=e.effects.setMode(p,t.mode||"hide"),m="show"===f,g=p.show().css("visibility","hidden").offset(),v=Math.ceil(p.outerWidth()/c),y=Math.ceil(p.outerHeight()/d),b=[];for(a=0;d>a;a++)for(h=g.top+a*y,u=a-(d-1)/2,o=0;c>o;o++)r=g.left+o*v,l=o-(c-1)/2,p.clone().appendTo("body").wrap("<div></div>").css({position:"absolute",visibility:"visible",left:-o*v,top:-a*y}).parent().addClass("ui-effects-explode").css({position:"absolute",overflow:"hidden",width:v,height:y,left:r+(m?l*v:0),top:h+(m?u*y:0),opacity:m?0:1}).animate({left:r+(m?0:l*v),top:h+(m?0:u*y),opacity:m?1:0},t.duration||500,t.easing,s)},e.effects.effect.fade=function(t,i){var s=e(this),n=e.effects.setMode(s,t.mode||"toggle");s.animate({opacity:n},{queue:!1,duration:t.duration,easing:t.easing,complete:i})},e.effects.effect.fold=function(t,i){var s,n,a=e(this),o=["position","top","bottom","left","right","height","width"],r=e.effects.setMode(a,t.mode||"hide"),h="show"===r,l="hide"===r,u=t.size||15,d=/([0-9]+)%/.exec(u),c=!!t.horizFirst,p=h!==c,f=p?["width","height"]:["height","width"],m=t.duration/2,g={},v={};e.effects.save(a,o),a.show(),s=e.effects.createWrapper(a).css({overflow:"hidden"}),n=p?[s.width(),s.height()]:[s.height(),s.width()],d&&(u=parseInt(d[1],10)/100*n[l?0:1]),h&&s.css(c?{height:0,width:u}:{height:u,width:0}),g[f[0]]=h?n[0]:u,v[f[1]]=h?n[1]:0,s.animate(g,m,t.easing).animate(v,m,t.easing,function(){l&&a.hide(),e.effects.restore(a,o),e.effects.removeWrapper(a),i()})},e.effects.effect.highlight=function(t,i){var s=e(this),n=["backgroundImage","backgroundColor","opacity"],a=e.effects.setMode(s,t.mode||"show"),o={backgroundColor:s.css("backgroundColor")};"hide"===a&&(o.opacity=0),e.effects.save(s,n),s.show().css({backgroundImage:"none",backgroundColor:t.color||"#ffff99"}).animate(o,{queue:!1,duration:t.duration,easing:t.easing,complete:function(){"hide"===a&&s.hide(),e.effects.restore(s,n),i()}})},e.effects.effect.size=function(t,i){var s,n,a,o=e(this),r=["position","top","bottom","left","right","width","height","overflow","opacity"],h=["position","top","bottom","left","right","overflow","opacity"],l=["width","height","overflow"],u=["fontSize"],d=["borderTopWidth","borderBottomWidth","paddingTop","paddingBottom"],c=["borderLeftWidth","borderRightWidth","paddingLeft","paddingRight"],p=e.effects.setMode(o,t.mode||"effect"),f=t.restore||"effect"!==p,m=t.scale||"both",g=t.origin||["middle","center"],v=o.css("position"),y=f?r:h,b={height:0,width:0,outerHeight:0,outerWidth:0};"show"===p&&o.show(),s={height:o.height(),width:o.width(),outerHeight:o.outerHeight(),outerWidth:o.outerWidth()},"toggle"===t.mode&&"show"===p?(o.from=t.to||b,o.to=t.from||s):(o.from=t.from||("show"===p?b:s),o.to=t.to||("hide"===p?b:s)),a={from:{y:o.from.height/s.height,x:o.from.width/s.width},to:{y:o.to.height/s.height,x:o.to.width/s.width}},("box"===m||"both"===m)&&(a.from.y!==a.to.y&&(y=y.concat(d),o.from=e.effects.setTransition(o,d,a.from.y,o.from),o.to=e.effects.setTransition(o,d,a.to.y,o.to)),a.from.x!==a.to.x&&(y=y.concat(c),o.from=e.effects.setTransition(o,c,a.from.x,o.from),o.to=e.effects.setTransition(o,c,a.to.x,o.to))),("content"===m||"both"===m)&&a.from.y!==a.to.y&&(y=y.concat(u).concat(l),o.from=e.effects.setTransition(o,u,a.from.y,o.from),o.to=e.effects.setTransition(o,u,a.to.y,o.to)),e.effects.save(o,y),o.show(),e.effects.createWrapper(o),o.css("overflow","hidden").css(o.from),g&&(n=e.effects.getBaseline(g,s),o.from.top=(s.outerHeight-o.outerHeight())*n.y,o.from.left=(s.outerWidth-o.outerWidth())*n.x,o.to.top=(s.outerHeight-o.to.outerHeight)*n.y,o.to.left=(s.outerWidth-o.to.outerWidth)*n.x),o.css(o.from),("content"===m||"both"===m)&&(d=d.concat(["marginTop","marginBottom"]).concat(u),c=c.concat(["marginLeft","marginRight"]),l=r.concat(d).concat(c),o.find("*[width]").each(function(){var i=e(this),s={height:i.height(),width:i.width(),outerHeight:i.outerHeight(),outerWidth:i.outerWidth()};
f&&e.effects.save(i,l),i.from={height:s.height*a.from.y,width:s.width*a.from.x,outerHeight:s.outerHeight*a.from.y,outerWidth:s.outerWidth*a.from.x},i.to={height:s.height*a.to.y,width:s.width*a.to.x,outerHeight:s.height*a.to.y,outerWidth:s.width*a.to.x},a.from.y!==a.to.y&&(i.from=e.effects.setTransition(i,d,a.from.y,i.from),i.to=e.effects.setTransition(i,d,a.to.y,i.to)),a.from.x!==a.to.x&&(i.from=e.effects.setTransition(i,c,a.from.x,i.from),i.to=e.effects.setTransition(i,c,a.to.x,i.to)),i.css(i.from),i.animate(i.to,t.duration,t.easing,function(){f&&e.effects.restore(i,l)})})),o.animate(o.to,{queue:!1,duration:t.duration,easing:t.easing,complete:function(){0===o.to.opacity&&o.css("opacity",o.from.opacity),"hide"===p&&o.hide(),e.effects.restore(o,y),f||("static"===v?o.css({position:"relative",top:o.to.top,left:o.to.left}):e.each(["top","left"],function(e,t){o.css(t,function(t,i){var s=parseInt(i,10),n=e?o.to.left:o.to.top;return"auto"===i?n+"px":s+n+"px"})})),e.effects.removeWrapper(o),i()}})},e.effects.effect.scale=function(t,i){var s=e(this),n=e.extend(!0,{},t),a=e.effects.setMode(s,t.mode||"effect"),o=parseInt(t.percent,10)||(0===parseInt(t.percent,10)?0:"hide"===a?0:100),r=t.direction||"both",h=t.origin,l={height:s.height(),width:s.width(),outerHeight:s.outerHeight(),outerWidth:s.outerWidth()},u={y:"horizontal"!==r?o/100:1,x:"vertical"!==r?o/100:1};n.effect="size",n.queue=!1,n.complete=i,"effect"!==a&&(n.origin=h||["middle","center"],n.restore=!0),n.from=t.from||("show"===a?{height:0,width:0,outerHeight:0,outerWidth:0}:l),n.to={height:l.height*u.y,width:l.width*u.x,outerHeight:l.outerHeight*u.y,outerWidth:l.outerWidth*u.x},n.fade&&("show"===a&&(n.from.opacity=0,n.to.opacity=1),"hide"===a&&(n.from.opacity=1,n.to.opacity=0)),s.effect(n)},e.effects.effect.puff=function(t,i){var s=e(this),n=e.effects.setMode(s,t.mode||"hide"),a="hide"===n,o=parseInt(t.percent,10)||150,r=o/100,h={height:s.height(),width:s.width(),outerHeight:s.outerHeight(),outerWidth:s.outerWidth()};e.extend(t,{effect:"scale",queue:!1,fade:!0,mode:n,complete:i,percent:a?o:100,from:a?h:{height:h.height*r,width:h.width*r,outerHeight:h.outerHeight*r,outerWidth:h.outerWidth*r}}),s.effect(t)},e.effects.effect.pulsate=function(t,i){var s,n=e(this),a=e.effects.setMode(n,t.mode||"show"),o="show"===a,r="hide"===a,h=o||"hide"===a,l=2*(t.times||5)+(h?1:0),u=t.duration/l,d=0,c=n.queue(),p=c.length;for((o||!n.is(":visible"))&&(n.css("opacity",0).show(),d=1),s=1;l>s;s++)n.animate({opacity:d},u,t.easing),d=1-d;n.animate({opacity:d},u,t.easing),n.queue(function(){r&&n.hide(),i()}),p>1&&c.splice.apply(c,[1,0].concat(c.splice(p,l+1))),n.dequeue()},e.effects.effect.shake=function(t,i){var s,n=e(this),a=["position","top","bottom","left","right","height","width"],o=e.effects.setMode(n,t.mode||"effect"),r=t.direction||"left",h=t.distance||20,l=t.times||3,u=2*l+1,d=Math.round(t.duration/u),c="up"===r||"down"===r?"top":"left",p="up"===r||"left"===r,f={},m={},g={},v=n.queue(),y=v.length;for(e.effects.save(n,a),n.show(),e.effects.createWrapper(n),f[c]=(p?"-=":"+=")+h,m[c]=(p?"+=":"-=")+2*h,g[c]=(p?"-=":"+=")+2*h,n.animate(f,d,t.easing),s=1;l>s;s++)n.animate(m,d,t.easing).animate(g,d,t.easing);n.animate(m,d,t.easing).animate(f,d/2,t.easing).queue(function(){"hide"===o&&n.hide(),e.effects.restore(n,a),e.effects.removeWrapper(n),i()}),y>1&&v.splice.apply(v,[1,0].concat(v.splice(y,u+1))),n.dequeue()},e.effects.effect.slide=function(t,i){var s,n=e(this),a=["position","top","bottom","left","right","width","height"],o=e.effects.setMode(n,t.mode||"show"),r="show"===o,h=t.direction||"left",l="up"===h||"down"===h?"top":"left",u="up"===h||"left"===h,d={};e.effects.save(n,a),n.show(),s=t.distance||n["top"===l?"outerHeight":"outerWidth"](!0),e.effects.createWrapper(n).css({overflow:"hidden"}),r&&n.css(l,u?isNaN(s)?"-"+s:-s:s),d[l]=(r?u?"+=":"-=":u?"-=":"+=")+s,n.animate(d,{queue:!1,duration:t.duration,easing:t.easing,complete:function(){"hide"===o&&n.hide(),e.effects.restore(n,a),e.effects.removeWrapper(n),i()}})},e.effects.effect.transfer=function(t,i){var s=e(this),n=e(t.to),a="fixed"===n.css("position"),o=e("body"),r=a?o.scrollTop():0,h=a?o.scrollLeft():0,l=n.offset(),u={top:l.top-r,left:l.left-h,height:n.innerHeight(),width:n.innerWidth()},d=s.offset(),c=e("<div class='ui-effects-transfer'></div>").appendTo(document.body).addClass(t.className).css({top:d.top-r,left:d.left-h,height:s.innerHeight(),width:s.innerWidth(),position:a?"fixed":"absolute"}).animate(u,t.duration,t.easing,function(){c.remove(),i()})},e.widget("ui.progressbar",{version:"1.11.4",options:{max:100,value:0,change:null,complete:null},min:0,_create:function(){this.oldValue=this.options.value=this._constrainedValue(),this.element.addClass("ui-progressbar ui-widget ui-widget-content ui-corner-all").attr({role:"progressbar","aria-valuemin":this.min}),this.valueDiv=e("<div class='ui-progressbar-value ui-widget-header ui-corner-left'></div>").appendTo(this.element),this._refreshValue()},_destroy:function(){this.element.removeClass("ui-progressbar ui-widget ui-widget-content ui-corner-all").removeAttr("role").removeAttr("aria-valuemin").removeAttr("aria-valuemax").removeAttr("aria-valuenow"),this.valueDiv.remove()},value:function(e){return void 0===e?this.options.value:(this.options.value=this._constrainedValue(e),this._refreshValue(),void 0)},_constrainedValue:function(e){return void 0===e&&(e=this.options.value),this.indeterminate=e===!1,"number"!=typeof e&&(e=0),this.indeterminate?!1:Math.min(this.options.max,Math.max(this.min,e))},_setOptions:function(e){var t=e.value;delete e.value,this._super(e),this.options.value=this._constrainedValue(t),this._refreshValue()},_setOption:function(e,t){"max"===e&&(t=Math.max(this.min,t)),"disabled"===e&&this.element.toggleClass("ui-state-disabled",!!t).attr("aria-disabled",t),this._super(e,t)},_percentage:function(){return this.indeterminate?100:100*(this.options.value-this.min)/(this.options.max-this.min)},_refreshValue:function(){var t=this.options.value,i=this._percentage();this.valueDiv.toggle(this.indeterminate||t>this.min).toggleClass("ui-corner-right",t===this.options.max).width(i.toFixed(0)+"%"),this.element.toggleClass("ui-progressbar-indeterminate",this.indeterminate),this.indeterminate?(this.element.removeAttr("aria-valuenow"),this.overlayDiv||(this.overlayDiv=e("<div class='ui-progressbar-overlay'></div>").appendTo(this.valueDiv))):(this.element.attr({"aria-valuemax":this.options.max,"aria-valuenow":t}),this.overlayDiv&&(this.overlayDiv.remove(),this.overlayDiv=null)),this.oldValue!==t&&(this.oldValue=t,this._trigger("change")),t===this.options.max&&this._trigger("complete")}}),e.widget("ui.selectable",e.ui.mouse,{version:"1.11.4",options:{appendTo:"body",autoRefresh:!0,distance:0,filter:"*",tolerance:"touch",selected:null,selecting:null,start:null,stop:null,unselected:null,unselecting:null},_create:function(){var t,i=this;this.element.addClass("ui-selectable"),this.dragged=!1,this.refresh=function(){t=e(i.options.filter,i.element[0]),t.addClass("ui-selectee"),t.each(function(){var t=e(this),i=t.offset();e.data(this,"selectable-item",{element:this,$element:t,left:i.left,top:i.top,right:i.left+t.outerWidth(),bottom:i.top+t.outerHeight(),startselected:!1,selected:t.hasClass("ui-selected"),selecting:t.hasClass("ui-selecting"),unselecting:t.hasClass("ui-unselecting")})})},this.refresh(),this.selectees=t.addClass("ui-selectee"),this._mouseInit(),this.helper=e("<div class='ui-selectable-helper'></div>")},_destroy:function(){this.selectees.removeClass("ui-selectee").removeData("selectable-item"),this.element.removeClass("ui-selectable ui-selectable-disabled"),this._mouseDestroy()},_mouseStart:function(t){var i=this,s=this.options;this.opos=[t.pageX,t.pageY],this.options.disabled||(this.selectees=e(s.filter,this.element[0]),this._trigger("start",t),e(s.appendTo).append(this.helper),this.helper.css({left:t.pageX,top:t.pageY,width:0,height:0}),s.autoRefresh&&this.refresh(),this.selectees.filter(".ui-selected").each(function(){var s=e.data(this,"selectable-item");s.startselected=!0,t.metaKey||t.ctrlKey||(s.$element.removeClass("ui-selected"),s.selected=!1,s.$element.addClass("ui-unselecting"),s.unselecting=!0,i._trigger("unselecting",t,{unselecting:s.element}))}),e(t.target).parents().addBack().each(function(){var s,n=e.data(this,"selectable-item");return n?(s=!t.metaKey&&!t.ctrlKey||!n.$element.hasClass("ui-selected"),n.$element.removeClass(s?"ui-unselecting":"ui-selected").addClass(s?"ui-selecting":"ui-unselecting"),n.unselecting=!s,n.selecting=s,n.selected=s,s?i._trigger("selecting",t,{selecting:n.element}):i._trigger("unselecting",t,{unselecting:n.element}),!1):void 0}))},_mouseDrag:function(t){if(this.dragged=!0,!this.options.disabled){var i,s=this,n=this.options,a=this.opos[0],o=this.opos[1],r=t.pageX,h=t.pageY;return a>r&&(i=r,r=a,a=i),o>h&&(i=h,h=o,o=i),this.helper.css({left:a,top:o,width:r-a,height:h-o}),this.selectees.each(function(){var i=e.data(this,"selectable-item"),l=!1;i&&i.element!==s.element[0]&&("touch"===n.tolerance?l=!(i.left>r||a>i.right||i.top>h||o>i.bottom):"fit"===n.tolerance&&(l=i.left>a&&r>i.right&&i.top>o&&h>i.bottom),l?(i.selected&&(i.$element.removeClass("ui-selected"),i.selected=!1),i.unselecting&&(i.$element.removeClass("ui-unselecting"),i.unselecting=!1),i.selecting||(i.$element.addClass("ui-selecting"),i.selecting=!0,s._trigger("selecting",t,{selecting:i.element}))):(i.selecting&&((t.metaKey||t.ctrlKey)&&i.startselected?(i.$element.removeClass("ui-selecting"),i.selecting=!1,i.$element.addClass("ui-selected"),i.selected=!0):(i.$element.removeClass("ui-selecting"),i.selecting=!1,i.startselected&&(i.$element.addClass("ui-unselecting"),i.unselecting=!0),s._trigger("unselecting",t,{unselecting:i.element}))),i.selected&&(t.metaKey||t.ctrlKey||i.startselected||(i.$element.removeClass("ui-selected"),i.selected=!1,i.$element.addClass("ui-unselecting"),i.unselecting=!0,s._trigger("unselecting",t,{unselecting:i.element})))))}),!1}},_mouseStop:function(t){var i=this;return this.dragged=!1,e(".ui-unselecting",this.element[0]).each(function(){var s=e.data(this,"selectable-item");s.$element.removeClass("ui-unselecting"),s.unselecting=!1,s.startselected=!1,i._trigger("unselected",t,{unselected:s.element})}),e(".ui-selecting",this.element[0]).each(function(){var s=e.data(this,"selectable-item");s.$element.removeClass("ui-selecting").addClass("ui-selected"),s.selecting=!1,s.selected=!0,s.startselected=!0,i._trigger("selected",t,{selected:s.element})}),this._trigger("stop",t),this.helper.remove(),!1}}),e.widget("ui.selectmenu",{version:"1.11.4",defaultElement:"<select>",options:{appendTo:null,disabled:null,icons:{button:"ui-icon-triangle-1-s"},position:{my:"left top",at:"left bottom",collision:"none"},width:null,change:null,close:null,focus:null,open:null,select:null},_create:function(){var e=this.element.uniqueId().attr("id");this.ids={element:e,button:e+"-button",menu:e+"-menu"},this._drawButton(),this._drawMenu(),this.options.disabled&&this.disable()},_drawButton:function(){var t=this;this.label=e("label[for='"+this.ids.element+"']").attr("for",this.ids.button),this._on(this.label,{click:function(e){this.button.focus(),e.preventDefault()}}),this.element.hide(),this.button=e("<span>",{"class":"ui-selectmenu-button ui-widget ui-state-default ui-corner-all",tabindex:this.options.disabled?-1:0,id:this.ids.button,role:"combobox","aria-expanded":"false","aria-autocomplete":"list","aria-owns":this.ids.menu,"aria-haspopup":"true"}).insertAfter(this.element),e("<span>",{"class":"ui-icon "+this.options.icons.button}).prependTo(this.button),this.buttonText=e("<span>",{"class":"ui-selectmenu-text"}).appendTo(this.button),this._setText(this.buttonText,this.element.find("option:selected").text()),this._resizeButton(),this._on(this.button,this._buttonEvents),this.button.one("focusin",function(){t.menuItems||t._refreshMenu()}),this._hoverable(this.button),this._focusable(this.button)},_drawMenu:function(){var t=this;this.menu=e("<ul>",{"aria-hidden":"true","aria-labelledby":this.ids.button,id:this.ids.menu}),this.menuWrap=e("<div>",{"class":"ui-selectmenu-menu ui-front"}).append(this.menu).appendTo(this._appendTo()),this.menuInstance=this.menu.menu({role:"listbox",select:function(e,i){e.preventDefault(),t._setSelection(),t._select(i.item.data("ui-selectmenu-item"),e)},focus:function(e,i){var s=i.item.data("ui-selectmenu-item");null!=t.focusIndex&&s.index!==t.focusIndex&&(t._trigger("focus",e,{item:s}),t.isOpen||t._select(s,e)),t.focusIndex=s.index,t.button.attr("aria-activedescendant",t.menuItems.eq(s.index).attr("id"))}}).menu("instance"),this.menu.addClass("ui-corner-bottom").removeClass("ui-corner-all"),this.menuInstance._off(this.menu,"mouseleave"),this.menuInstance._closeOnDocumentClick=function(){return!1},this.menuInstance._isDivider=function(){return!1}},refresh:function(){this._refreshMenu(),this._setText(this.buttonText,this._getSelectedItem().text()),this.options.width||this._resizeButton()},_refreshMenu:function(){this.menu.empty();var e,t=this.element.find("option");t.length&&(this._parseOptions(t),this._renderMenu(this.menu,this.items),this.menuInstance.refresh(),this.menuItems=this.menu.find("li").not(".ui-selectmenu-optgroup"),e=this._getSelectedItem(),this.menuInstance.focus(null,e),this._setAria(e.data("ui-selectmenu-item")),this._setOption("disabled",this.element.prop("disabled")))},open:function(e){this.options.disabled||(this.menuItems?(this.menu.find(".ui-state-focus").removeClass("ui-state-focus"),this.menuInstance.focus(null,this._getSelectedItem())):this._refreshMenu(),this.isOpen=!0,this._toggleAttr(),this._resizeMenu(),this._position(),this._on(this.document,this._documentClick),this._trigger("open",e))},_position:function(){this.menuWrap.position(e.extend({of:this.button},this.options.position))},close:function(e){this.isOpen&&(this.isOpen=!1,this._toggleAttr(),this.range=null,this._off(this.document),this._trigger("close",e))},widget:function(){return this.button},menuWidget:function(){return this.menu},_renderMenu:function(t,i){var s=this,n="";e.each(i,function(i,a){a.optgroup!==n&&(e("<li>",{"class":"ui-selectmenu-optgroup ui-menu-divider"+(a.element.parent("optgroup").prop("disabled")?" ui-state-disabled":""),text:a.optgroup}).appendTo(t),n=a.optgroup),s._renderItemData(t,a)})},_renderItemData:function(e,t){return this._renderItem(e,t).data("ui-selectmenu-item",t)},_renderItem:function(t,i){var s=e("<li>");return i.disabled&&s.addClass("ui-state-disabled"),this._setText(s,i.label),s.appendTo(t)},_setText:function(e,t){t?e.text(t):e.html("&#160;")},_move:function(e,t){var i,s,n=".ui-menu-item";this.isOpen?i=this.menuItems.eq(this.focusIndex):(i=this.menuItems.eq(this.element[0].selectedIndex),n+=":not(.ui-state-disabled)"),s="first"===e||"last"===e?i["first"===e?"prevAll":"nextAll"](n).eq(-1):i[e+"All"](n).eq(0),s.length&&this.menuInstance.focus(t,s)},_getSelectedItem:function(){return this.menuItems.eq(this.element[0].selectedIndex)},_toggle:function(e){this[this.isOpen?"close":"open"](e)},_setSelection:function(){var e;this.range&&(window.getSelection?(e=window.getSelection(),e.removeAllRanges(),e.addRange(this.range)):this.range.select(),this.button.focus())},_documentClick:{mousedown:function(t){this.isOpen&&(e(t.target).closest(".ui-selectmenu-menu, #"+this.ids.button).length||this.close(t))}},_buttonEvents:{mousedown:function(){var e;window.getSelection?(e=window.getSelection(),e.rangeCount&&(this.range=e.getRangeAt(0))):this.range=document.selection.createRange()},click:function(e){this._setSelection(),this._toggle(e)},keydown:function(t){var i=!0;switch(t.keyCode){case e.ui.keyCode.TAB:case e.ui.keyCode.ESCAPE:this.close(t),i=!1;break;case e.ui.keyCode.ENTER:this.isOpen&&this._selectFocusedItem(t);break;case e.ui.keyCode.UP:t.altKey?this._toggle(t):this._move("prev",t);break;case e.ui.keyCode.DOWN:t.altKey?this._toggle(t):this._move("next",t);break;case e.ui.keyCode.SPACE:this.isOpen?this._selectFocusedItem(t):this._toggle(t);break;case e.ui.keyCode.LEFT:this._move("prev",t);break;case e.ui.keyCode.RIGHT:this._move("next",t);break;case e.ui.keyCode.HOME:case e.ui.keyCode.PAGE_UP:this._move("first",t);break;case e.ui.keyCode.END:case e.ui.keyCode.PAGE_DOWN:this._move("last",t);break;default:this.menu.trigger(t),i=!1}i&&t.preventDefault()}},_selectFocusedItem:function(e){var t=this.menuItems.eq(this.focusIndex);t.hasClass("ui-state-disabled")||this._select(t.data("ui-selectmenu-item"),e)},_select:function(e,t){var i=this.element[0].selectedIndex;this.element[0].selectedIndex=e.index,this._setText(this.buttonText,e.label),this._setAria(e),this._trigger("select",t,{item:e}),e.index!==i&&this._trigger("change",t,{item:e}),this.close(t)},_setAria:function(e){var t=this.menuItems.eq(e.index).attr("id");this.button.attr({"aria-labelledby":t,"aria-activedescendant":t}),this.menu.attr("aria-activedescendant",t)},_setOption:function(e,t){"icons"===e&&this.button.find("span.ui-icon").removeClass(this.options.icons.button).addClass(t.button),this._super(e,t),"appendTo"===e&&this.menuWrap.appendTo(this._appendTo()),"disabled"===e&&(this.menuInstance.option("disabled",t),this.button.toggleClass("ui-state-disabled",t).attr("aria-disabled",t),this.element.prop("disabled",t),t?(this.button.attr("tabindex",-1),this.close()):this.button.attr("tabindex",0)),"width"===e&&this._resizeButton()},_appendTo:function(){var t=this.options.appendTo;return t&&(t=t.jquery||t.nodeType?e(t):this.document.find(t).eq(0)),t&&t[0]||(t=this.element.closest(".ui-front")),t.length||(t=this.document[0].body),t},_toggleAttr:function(){this.button.toggleClass("ui-corner-top",this.isOpen).toggleClass("ui-corner-all",!this.isOpen).attr("aria-expanded",this.isOpen),this.menuWrap.toggleClass("ui-selectmenu-open",this.isOpen),this.menu.attr("aria-hidden",!this.isOpen)},_resizeButton:function(){var e=this.options.width;e||(e=this.element.show().outerWidth(),this.element.hide()),this.button.outerWidth(e)},_resizeMenu:function(){this.menu.outerWidth(Math.max(this.button.outerWidth(),this.menu.width("").outerWidth()+1))},_getCreateOptions:function(){return{disabled:this.element.prop("disabled")}},_parseOptions:function(t){var i=[];t.each(function(t,s){var n=e(s),a=n.parent("optgroup");i.push({element:n,index:t,value:n.val(),label:n.text(),optgroup:a.attr("label")||"",disabled:a.prop("disabled")||n.prop("disabled")})}),this.items=i},_destroy:function(){this.menuWrap.remove(),this.button.remove(),this.element.show(),this.element.removeUniqueId(),this.label.attr("for",this.ids.element)}}),e.widget("ui.slider",e.ui.mouse,{version:"1.11.4",widgetEventPrefix:"slide",options:{animate:!1,distance:0,max:100,min:0,orientation:"horizontal",range:!1,step:1,value:0,values:null,change:null,slide:null,start:null,stop:null},numPages:5,_create:function(){this._keySliding=!1,this._mouseSliding=!1,this._animateOff=!0,this._handleIndex=null,this._detectOrientation(),this._mouseInit(),this._calculateNewMax(),this.element.addClass("ui-slider ui-slider-"+this.orientation+" ui-widget"+" ui-widget-content"+" ui-corner-all"),this._refresh(),this._setOption("disabled",this.options.disabled),this._animateOff=!1},_refresh:function(){this._createRange(),this._createHandles(),this._setupEvents(),this._refreshValue()},_createHandles:function(){var t,i,s=this.options,n=this.element.find(".ui-slider-handle").addClass("ui-state-default ui-corner-all"),a="<span class='ui-slider-handle ui-state-default ui-corner-all' tabindex='0'></span>",o=[];for(i=s.values&&s.values.length||1,n.length>i&&(n.slice(i).remove(),n=n.slice(0,i)),t=n.length;i>t;t++)o.push(a);this.handles=n.add(e(o.join("")).appendTo(this.element)),this.handle=this.handles.eq(0),this.handles.each(function(t){e(this).data("ui-slider-handle-index",t)})},_createRange:function(){var t=this.options,i="";t.range?(t.range===!0&&(t.values?t.values.length&&2!==t.values.length?t.values=[t.values[0],t.values[0]]:e.isArray(t.values)&&(t.values=t.values.slice(0)):t.values=[this._valueMin(),this._valueMin()]),this.range&&this.range.length?this.range.removeClass("ui-slider-range-min ui-slider-range-max").css({left:"",bottom:""}):(this.range=e("<div></div>").appendTo(this.element),i="ui-slider-range ui-widget-header ui-corner-all"),this.range.addClass(i+("min"===t.range||"max"===t.range?" ui-slider-range-"+t.range:""))):(this.range&&this.range.remove(),this.range=null)},_setupEvents:function(){this._off(this.handles),this._on(this.handles,this._handleEvents),this._hoverable(this.handles),this._focusable(this.handles)},_destroy:function(){this.handles.remove(),this.range&&this.range.remove(),this.element.removeClass("ui-slider ui-slider-horizontal ui-slider-vertical ui-widget ui-widget-content ui-corner-all"),this._mouseDestroy()},_mouseCapture:function(t){var i,s,n,a,o,r,h,l,u=this,d=this.options;return d.disabled?!1:(this.elementSize={width:this.element.outerWidth(),height:this.element.outerHeight()},this.elementOffset=this.element.offset(),i={x:t.pageX,y:t.pageY},s=this._normValueFromMouse(i),n=this._valueMax()-this._valueMin()+1,this.handles.each(function(t){var i=Math.abs(s-u.values(t));(n>i||n===i&&(t===u._lastChangedValue||u.values(t)===d.min))&&(n=i,a=e(this),o=t)}),r=this._start(t,o),r===!1?!1:(this._mouseSliding=!0,this._handleIndex=o,a.addClass("ui-state-active").focus(),h=a.offset(),l=!e(t.target).parents().addBack().is(".ui-slider-handle"),this._clickOffset=l?{left:0,top:0}:{left:t.pageX-h.left-a.width()/2,top:t.pageY-h.top-a.height()/2-(parseInt(a.css("borderTopWidth"),10)||0)-(parseInt(a.css("borderBottomWidth"),10)||0)+(parseInt(a.css("marginTop"),10)||0)},this.handles.hasClass("ui-state-hover")||this._slide(t,o,s),this._animateOff=!0,!0))},_mouseStart:function(){return!0},_mouseDrag:function(e){var t={x:e.pageX,y:e.pageY},i=this._normValueFromMouse(t);return this._slide(e,this._handleIndex,i),!1},_mouseStop:function(e){return this.handles.removeClass("ui-state-active"),this._mouseSliding=!1,this._stop(e,this._handleIndex),this._change(e,this._handleIndex),this._handleIndex=null,this._clickOffset=null,this._animateOff=!1,!1},_detectOrientation:function(){this.orientation="vertical"===this.options.orientation?"vertical":"horizontal"},_normValueFromMouse:function(e){var t,i,s,n,a;return"horizontal"===this.orientation?(t=this.elementSize.width,i=e.x-this.elementOffset.left-(this._clickOffset?this._clickOffset.left:0)):(t=this.elementSize.height,i=e.y-this.elementOffset.top-(this._clickOffset?this._clickOffset.top:0)),s=i/t,s>1&&(s=1),0>s&&(s=0),"vertical"===this.orientation&&(s=1-s),n=this._valueMax()-this._valueMin(),a=this._valueMin()+s*n,this._trimAlignValue(a)},_start:function(e,t){var i={handle:this.handles[t],value:this.value()};return this.options.values&&this.options.values.length&&(i.value=this.values(t),i.values=this.values()),this._trigger("start",e,i)},_slide:function(e,t,i){var s,n,a;this.options.values&&this.options.values.length?(s=this.values(t?0:1),2===this.options.values.length&&this.options.range===!0&&(0===t&&i>s||1===t&&s>i)&&(i=s),i!==this.values(t)&&(n=this.values(),n[t]=i,a=this._trigger("slide",e,{handle:this.handles[t],value:i,values:n}),s=this.values(t?0:1),a!==!1&&this.values(t,i))):i!==this.value()&&(a=this._trigger("slide",e,{handle:this.handles[t],value:i}),a!==!1&&this.value(i))},_stop:function(e,t){var i={handle:this.handles[t],value:this.value()};this.options.values&&this.options.values.length&&(i.value=this.values(t),i.values=this.values()),this._trigger("stop",e,i)},_change:function(e,t){if(!this._keySliding&&!this._mouseSliding){var i={handle:this.handles[t],value:this.value()};this.options.values&&this.options.values.length&&(i.value=this.values(t),i.values=this.values()),this._lastChangedValue=t,this._trigger("change",e,i)}},value:function(e){return arguments.length?(this.options.value=this._trimAlignValue(e),this._refreshValue(),this._change(null,0),void 0):this._value()},values:function(t,i){var s,n,a;if(arguments.length>1)return this.options.values[t]=this._trimAlignValue(i),this._refreshValue(),this._change(null,t),void 0;if(!arguments.length)return this._values();if(!e.isArray(arguments[0]))return this.options.values&&this.options.values.length?this._values(t):this.value();for(s=this.options.values,n=arguments[0],a=0;s.length>a;a+=1)s[a]=this._trimAlignValue(n[a]),this._change(null,a);this._refreshValue()},_setOption:function(t,i){var s,n=0;switch("range"===t&&this.options.range===!0&&("min"===i?(this.options.value=this._values(0),this.options.values=null):"max"===i&&(this.options.value=this._values(this.options.values.length-1),this.options.values=null)),e.isArray(this.options.values)&&(n=this.options.values.length),"disabled"===t&&this.element.toggleClass("ui-state-disabled",!!i),this._super(t,i),t){case"orientation":this._detectOrientation(),this.element.removeClass("ui-slider-horizontal ui-slider-vertical").addClass("ui-slider-"+this.orientation),this._refreshValue(),this.handles.css("horizontal"===i?"bottom":"left","");break;case"value":this._animateOff=!0,this._refreshValue(),this._change(null,0),this._animateOff=!1;break;case"values":for(this._animateOff=!0,this._refreshValue(),s=0;n>s;s+=1)this._change(null,s);this._animateOff=!1;break;case"step":case"min":case"max":this._animateOff=!0,this._calculateNewMax(),this._refreshValue(),this._animateOff=!1;break;case"range":this._animateOff=!0,this._refresh(),this._animateOff=!1}},_value:function(){var e=this.options.value;return e=this._trimAlignValue(e)},_values:function(e){var t,i,s;if(arguments.length)return t=this.options.values[e],t=this._trimAlignValue(t);if(this.options.values&&this.options.values.length){for(i=this.options.values.slice(),s=0;i.length>s;s+=1)i[s]=this._trimAlignValue(i[s]);return i}return[]},_trimAlignValue:function(e){if(this._valueMin()>=e)return this._valueMin();if(e>=this._valueMax())return this._valueMax();var t=this.options.step>0?this.options.step:1,i=(e-this._valueMin())%t,s=e-i;return 2*Math.abs(i)>=t&&(s+=i>0?t:-t),parseFloat(s.toFixed(5))},_calculateNewMax:function(){var e=this.options.max,t=this._valueMin(),i=this.options.step,s=Math.floor(+(e-t).toFixed(this._precision())/i)*i;e=s+t,this.max=parseFloat(e.toFixed(this._precision()))},_precision:function(){var e=this._precisionOf(this.options.step);return null!==this.options.min&&(e=Math.max(e,this._precisionOf(this.options.min))),e},_precisionOf:function(e){var t=""+e,i=t.indexOf(".");return-1===i?0:t.length-i-1},_valueMin:function(){return this.options.min},_valueMax:function(){return this.max},_refreshValue:function(){var t,i,s,n,a,o=this.options.range,r=this.options,h=this,l=this._animateOff?!1:r.animate,u={};this.options.values&&this.options.values.length?this.handles.each(function(s){i=100*((h.values(s)-h._valueMin())/(h._valueMax()-h._valueMin())),u["horizontal"===h.orientation?"left":"bottom"]=i+"%",e(this).stop(1,1)[l?"animate":"css"](u,r.animate),h.options.range===!0&&("horizontal"===h.orientation?(0===s&&h.range.stop(1,1)[l?"animate":"css"]({left:i+"%"},r.animate),1===s&&h.range[l?"animate":"css"]({width:i-t+"%"},{queue:!1,duration:r.animate})):(0===s&&h.range.stop(1,1)[l?"animate":"css"]({bottom:i+"%"},r.animate),1===s&&h.range[l?"animate":"css"]({height:i-t+"%"},{queue:!1,duration:r.animate}))),t=i}):(s=this.value(),n=this._valueMin(),a=this._valueMax(),i=a!==n?100*((s-n)/(a-n)):0,u["horizontal"===this.orientation?"left":"bottom"]=i+"%",this.handle.stop(1,1)[l?"animate":"css"](u,r.animate),"min"===o&&"horizontal"===this.orientation&&this.range.stop(1,1)[l?"animate":"css"]({width:i+"%"},r.animate),"max"===o&&"horizontal"===this.orientation&&this.range[l?"animate":"css"]({width:100-i+"%"},{queue:!1,duration:r.animate}),"min"===o&&"vertical"===this.orientation&&this.range.stop(1,1)[l?"animate":"css"]({height:i+"%"},r.animate),"max"===o&&"vertical"===this.orientation&&this.range[l?"animate":"css"]({height:100-i+"%"},{queue:!1,duration:r.animate}))},_handleEvents:{keydown:function(t){var i,s,n,a,o=e(t.target).data("ui-slider-handle-index");switch(t.keyCode){case e.ui.keyCode.HOME:case e.ui.keyCode.END:case e.ui.keyCode.PAGE_UP:case e.ui.keyCode.PAGE_DOWN:case e.ui.keyCode.UP:case e.ui.keyCode.RIGHT:case e.ui.keyCode.DOWN:case e.ui.keyCode.LEFT:if(t.preventDefault(),!this._keySliding&&(this._keySliding=!0,e(t.target).addClass("ui-state-active"),i=this._start(t,o),i===!1))return}switch(a=this.options.step,s=n=this.options.values&&this.options.values.length?this.values(o):this.value(),t.keyCode){case e.ui.keyCode.HOME:n=this._valueMin();break;case e.ui.keyCode.END:n=this._valueMax();break;case e.ui.keyCode.PAGE_UP:n=this._trimAlignValue(s+(this._valueMax()-this._valueMin())/this.numPages);break;case e.ui.keyCode.PAGE_DOWN:n=this._trimAlignValue(s-(this._valueMax()-this._valueMin())/this.numPages);break;case e.ui.keyCode.UP:case e.ui.keyCode.RIGHT:if(s===this._valueMax())return;n=this._trimAlignValue(s+a);break;case e.ui.keyCode.DOWN:case e.ui.keyCode.LEFT:if(s===this._valueMin())return;n=this._trimAlignValue(s-a)}this._slide(t,o,n)},keyup:function(t){var i=e(t.target).data("ui-slider-handle-index");this._keySliding&&(this._keySliding=!1,this._stop(t,i),this._change(t,i),e(t.target).removeClass("ui-state-active"))}}}),e.widget("ui.sortable",e.ui.mouse,{version:"1.11.4",widgetEventPrefix:"sort",ready:!1,options:{appendTo:"parent",axis:!1,connectWith:!1,containment:!1,cursor:"auto",cursorAt:!1,dropOnEmpty:!0,forcePlaceholderSize:!1,forceHelperSize:!1,grid:!1,handle:!1,helper:"original",items:"> *",opacity:!1,placeholder:!1,revert:!1,scroll:!0,scrollSensitivity:20,scrollSpeed:20,scope:"default",tolerance:"intersect",zIndex:1e3,activate:null,beforeStop:null,change:null,deactivate:null,out:null,over:null,receive:null,remove:null,sort:null,start:null,stop:null,update:null},_isOverAxis:function(e,t,i){return e>=t&&t+i>e},_isFloating:function(e){return/left|right/.test(e.css("float"))||/inline|table-cell/.test(e.css("display"))},_create:function(){this.containerCache={},this.element.addClass("ui-sortable"),this.refresh(),this.offset=this.element.offset(),this._mouseInit(),this._setHandleClassName(),this.ready=!0},_setOption:function(e,t){this._super(e,t),"handle"===e&&this._setHandleClassName()},_setHandleClassName:function(){this.element.find(".ui-sortable-handle").removeClass("ui-sortable-handle"),e.each(this.items,function(){(this.instance.options.handle?this.item.find(this.instance.options.handle):this.item).addClass("ui-sortable-handle")})},_destroy:function(){this.element.removeClass("ui-sortable ui-sortable-disabled").find(".ui-sortable-handle").removeClass("ui-sortable-handle"),this._mouseDestroy();for(var e=this.items.length-1;e>=0;e--)this.items[e].item.removeData(this.widgetName+"-item");return this},_mouseCapture:function(t,i){var s=null,n=!1,a=this;return this.reverting?!1:this.options.disabled||"static"===this.options.type?!1:(this._refreshItems(t),e(t.target).parents().each(function(){return e.data(this,a.widgetName+"-item")===a?(s=e(this),!1):void 0}),e.data(t.target,a.widgetName+"-item")===a&&(s=e(t.target)),s?!this.options.handle||i||(e(this.options.handle,s).find("*").addBack().each(function(){this===t.target&&(n=!0)}),n)?(this.currentItem=s,this._removeCurrentsFromItems(),!0):!1:!1)},_mouseStart:function(t,i,s){var n,a,o=this.options;if(this.currentContainer=this,this.refreshPositions(),this.helper=this._createHelper(t),this._cacheHelperProportions(),this._cacheMargins(),this.scrollParent=this.helper.scrollParent(),this.offset=this.currentItem.offset(),this.offset={top:this.offset.top-this.margins.top,left:this.offset.left-this.margins.left},e.extend(this.offset,{click:{left:t.pageX-this.offset.left,top:t.pageY-this.offset.top},parent:this._getParentOffset(),relative:this._getRelativeOffset()}),this.helper.css("position","absolute"),this.cssPosition=this.helper.css("position"),this.originalPosition=this._generatePosition(t),this.originalPageX=t.pageX,this.originalPageY=t.pageY,o.cursorAt&&this._adjustOffsetFromHelper(o.cursorAt),this.domPosition={prev:this.currentItem.prev()[0],parent:this.currentItem.parent()[0]},this.helper[0]!==this.currentItem[0]&&this.currentItem.hide(),this._createPlaceholder(),o.containment&&this._setContainment(),o.cursor&&"auto"!==o.cursor&&(a=this.document.find("body"),this.storedCursor=a.css("cursor"),a.css("cursor",o.cursor),this.storedStylesheet=e("<style>*{ cursor: "+o.cursor+" !important; }</style>").appendTo(a)),o.opacity&&(this.helper.css("opacity")&&(this._storedOpacity=this.helper.css("opacity")),this.helper.css("opacity",o.opacity)),o.zIndex&&(this.helper.css("zIndex")&&(this._storedZIndex=this.helper.css("zIndex")),this.helper.css("zIndex",o.zIndex)),this.scrollParent[0]!==this.document[0]&&"HTML"!==this.scrollParent[0].tagName&&(this.overflowOffset=this.scrollParent.offset()),this._trigger("start",t,this._uiHash()),this._preserveHelperProportions||this._cacheHelperProportions(),!s)for(n=this.containers.length-1;n>=0;n--)this.containers[n]._trigger("activate",t,this._uiHash(this));
return e.ui.ddmanager&&(e.ui.ddmanager.current=this),e.ui.ddmanager&&!o.dropBehaviour&&e.ui.ddmanager.prepareOffsets(this,t),this.dragging=!0,this.helper.addClass("ui-sortable-helper"),this._mouseDrag(t),!0},_mouseDrag:function(t){var i,s,n,a,o=this.options,r=!1;for(this.position=this._generatePosition(t),this.positionAbs=this._convertPositionTo("absolute"),this.lastPositionAbs||(this.lastPositionAbs=this.positionAbs),this.options.scroll&&(this.scrollParent[0]!==this.document[0]&&"HTML"!==this.scrollParent[0].tagName?(this.overflowOffset.top+this.scrollParent[0].offsetHeight-t.pageY<o.scrollSensitivity?this.scrollParent[0].scrollTop=r=this.scrollParent[0].scrollTop+o.scrollSpeed:t.pageY-this.overflowOffset.top<o.scrollSensitivity&&(this.scrollParent[0].scrollTop=r=this.scrollParent[0].scrollTop-o.scrollSpeed),this.overflowOffset.left+this.scrollParent[0].offsetWidth-t.pageX<o.scrollSensitivity?this.scrollParent[0].scrollLeft=r=this.scrollParent[0].scrollLeft+o.scrollSpeed:t.pageX-this.overflowOffset.left<o.scrollSensitivity&&(this.scrollParent[0].scrollLeft=r=this.scrollParent[0].scrollLeft-o.scrollSpeed)):(t.pageY-this.document.scrollTop()<o.scrollSensitivity?r=this.document.scrollTop(this.document.scrollTop()-o.scrollSpeed):this.window.height()-(t.pageY-this.document.scrollTop())<o.scrollSensitivity&&(r=this.document.scrollTop(this.document.scrollTop()+o.scrollSpeed)),t.pageX-this.document.scrollLeft()<o.scrollSensitivity?r=this.document.scrollLeft(this.document.scrollLeft()-o.scrollSpeed):this.window.width()-(t.pageX-this.document.scrollLeft())<o.scrollSensitivity&&(r=this.document.scrollLeft(this.document.scrollLeft()+o.scrollSpeed))),r!==!1&&e.ui.ddmanager&&!o.dropBehaviour&&e.ui.ddmanager.prepareOffsets(this,t)),this.positionAbs=this._convertPositionTo("absolute"),this.options.axis&&"y"===this.options.axis||(this.helper[0].style.left=this.position.left+"px"),this.options.axis&&"x"===this.options.axis||(this.helper[0].style.top=this.position.top+"px"),i=this.items.length-1;i>=0;i--)if(s=this.items[i],n=s.item[0],a=this._intersectsWithPointer(s),a&&s.instance===this.currentContainer&&n!==this.currentItem[0]&&this.placeholder[1===a?"next":"prev"]()[0]!==n&&!e.contains(this.placeholder[0],n)&&("semi-dynamic"===this.options.type?!e.contains(this.element[0],n):!0)){if(this.direction=1===a?"down":"up","pointer"!==this.options.tolerance&&!this._intersectsWithSides(s))break;this._rearrange(t,s),this._trigger("change",t,this._uiHash());break}return this._contactContainers(t),e.ui.ddmanager&&e.ui.ddmanager.drag(this,t),this._trigger("sort",t,this._uiHash()),this.lastPositionAbs=this.positionAbs,!1},_mouseStop:function(t,i){if(t){if(e.ui.ddmanager&&!this.options.dropBehaviour&&e.ui.ddmanager.drop(this,t),this.options.revert){var s=this,n=this.placeholder.offset(),a=this.options.axis,o={};a&&"x"!==a||(o.left=n.left-this.offset.parent.left-this.margins.left+(this.offsetParent[0]===this.document[0].body?0:this.offsetParent[0].scrollLeft)),a&&"y"!==a||(o.top=n.top-this.offset.parent.top-this.margins.top+(this.offsetParent[0]===this.document[0].body?0:this.offsetParent[0].scrollTop)),this.reverting=!0,e(this.helper).animate(o,parseInt(this.options.revert,10)||500,function(){s._clear(t)})}else this._clear(t,i);return!1}},cancel:function(){if(this.dragging){this._mouseUp({target:null}),"original"===this.options.helper?this.currentItem.css(this._storedCSS).removeClass("ui-sortable-helper"):this.currentItem.show();for(var t=this.containers.length-1;t>=0;t--)this.containers[t]._trigger("deactivate",null,this._uiHash(this)),this.containers[t].containerCache.over&&(this.containers[t]._trigger("out",null,this._uiHash(this)),this.containers[t].containerCache.over=0)}return this.placeholder&&(this.placeholder[0].parentNode&&this.placeholder[0].parentNode.removeChild(this.placeholder[0]),"original"!==this.options.helper&&this.helper&&this.helper[0].parentNode&&this.helper.remove(),e.extend(this,{helper:null,dragging:!1,reverting:!1,_noFinalSort:null}),this.domPosition.prev?e(this.domPosition.prev).after(this.currentItem):e(this.domPosition.parent).prepend(this.currentItem)),this},serialize:function(t){var i=this._getItemsAsjQuery(t&&t.connected),s=[];return t=t||{},e(i).each(function(){var i=(e(t.item||this).attr(t.attribute||"id")||"").match(t.expression||/(.+)[\-=_](.+)/);i&&s.push((t.key||i[1]+"[]")+"="+(t.key&&t.expression?i[1]:i[2]))}),!s.length&&t.key&&s.push(t.key+"="),s.join("&")},toArray:function(t){var i=this._getItemsAsjQuery(t&&t.connected),s=[];return t=t||{},i.each(function(){s.push(e(t.item||this).attr(t.attribute||"id")||"")}),s},_intersectsWith:function(e){var t=this.positionAbs.left,i=t+this.helperProportions.width,s=this.positionAbs.top,n=s+this.helperProportions.height,a=e.left,o=a+e.width,r=e.top,h=r+e.height,l=this.offset.click.top,u=this.offset.click.left,d="x"===this.options.axis||s+l>r&&h>s+l,c="y"===this.options.axis||t+u>a&&o>t+u,p=d&&c;return"pointer"===this.options.tolerance||this.options.forcePointerForContainers||"pointer"!==this.options.tolerance&&this.helperProportions[this.floating?"width":"height"]>e[this.floating?"width":"height"]?p:t+this.helperProportions.width/2>a&&o>i-this.helperProportions.width/2&&s+this.helperProportions.height/2>r&&h>n-this.helperProportions.height/2},_intersectsWithPointer:function(e){var t="x"===this.options.axis||this._isOverAxis(this.positionAbs.top+this.offset.click.top,e.top,e.height),i="y"===this.options.axis||this._isOverAxis(this.positionAbs.left+this.offset.click.left,e.left,e.width),s=t&&i,n=this._getDragVerticalDirection(),a=this._getDragHorizontalDirection();return s?this.floating?a&&"right"===a||"down"===n?2:1:n&&("down"===n?2:1):!1},_intersectsWithSides:function(e){var t=this._isOverAxis(this.positionAbs.top+this.offset.click.top,e.top+e.height/2,e.height),i=this._isOverAxis(this.positionAbs.left+this.offset.click.left,e.left+e.width/2,e.width),s=this._getDragVerticalDirection(),n=this._getDragHorizontalDirection();return this.floating&&n?"right"===n&&i||"left"===n&&!i:s&&("down"===s&&t||"up"===s&&!t)},_getDragVerticalDirection:function(){var e=this.positionAbs.top-this.lastPositionAbs.top;return 0!==e&&(e>0?"down":"up")},_getDragHorizontalDirection:function(){var e=this.positionAbs.left-this.lastPositionAbs.left;return 0!==e&&(e>0?"right":"left")},refresh:function(e){return this._refreshItems(e),this._setHandleClassName(),this.refreshPositions(),this},_connectWith:function(){var e=this.options;return e.connectWith.constructor===String?[e.connectWith]:e.connectWith},_getItemsAsjQuery:function(t){function i(){r.push(this)}var s,n,a,o,r=[],h=[],l=this._connectWith();if(l&&t)for(s=l.length-1;s>=0;s--)for(a=e(l[s],this.document[0]),n=a.length-1;n>=0;n--)o=e.data(a[n],this.widgetFullName),o&&o!==this&&!o.options.disabled&&h.push([e.isFunction(o.options.items)?o.options.items.call(o.element):e(o.options.items,o.element).not(".ui-sortable-helper").not(".ui-sortable-placeholder"),o]);for(h.push([e.isFunction(this.options.items)?this.options.items.call(this.element,null,{options:this.options,item:this.currentItem}):e(this.options.items,this.element).not(".ui-sortable-helper").not(".ui-sortable-placeholder"),this]),s=h.length-1;s>=0;s--)h[s][0].each(i);return e(r)},_removeCurrentsFromItems:function(){var t=this.currentItem.find(":data("+this.widgetName+"-item)");this.items=e.grep(this.items,function(e){for(var i=0;t.length>i;i++)if(t[i]===e.item[0])return!1;return!0})},_refreshItems:function(t){this.items=[],this.containers=[this];var i,s,n,a,o,r,h,l,u=this.items,d=[[e.isFunction(this.options.items)?this.options.items.call(this.element[0],t,{item:this.currentItem}):e(this.options.items,this.element),this]],c=this._connectWith();if(c&&this.ready)for(i=c.length-1;i>=0;i--)for(n=e(c[i],this.document[0]),s=n.length-1;s>=0;s--)a=e.data(n[s],this.widgetFullName),a&&a!==this&&!a.options.disabled&&(d.push([e.isFunction(a.options.items)?a.options.items.call(a.element[0],t,{item:this.currentItem}):e(a.options.items,a.element),a]),this.containers.push(a));for(i=d.length-1;i>=0;i--)for(o=d[i][1],r=d[i][0],s=0,l=r.length;l>s;s++)h=e(r[s]),h.data(this.widgetName+"-item",o),u.push({item:h,instance:o,width:0,height:0,left:0,top:0})},refreshPositions:function(t){this.floating=this.items.length?"x"===this.options.axis||this._isFloating(this.items[0].item):!1,this.offsetParent&&this.helper&&(this.offset.parent=this._getParentOffset());var i,s,n,a;for(i=this.items.length-1;i>=0;i--)s=this.items[i],s.instance!==this.currentContainer&&this.currentContainer&&s.item[0]!==this.currentItem[0]||(n=this.options.toleranceElement?e(this.options.toleranceElement,s.item):s.item,t||(s.width=n.outerWidth(),s.height=n.outerHeight()),a=n.offset(),s.left=a.left,s.top=a.top);if(this.options.custom&&this.options.custom.refreshContainers)this.options.custom.refreshContainers.call(this);else for(i=this.containers.length-1;i>=0;i--)a=this.containers[i].element.offset(),this.containers[i].containerCache.left=a.left,this.containers[i].containerCache.top=a.top,this.containers[i].containerCache.width=this.containers[i].element.outerWidth(),this.containers[i].containerCache.height=this.containers[i].element.outerHeight();return this},_createPlaceholder:function(t){t=t||this;var i,s=t.options;s.placeholder&&s.placeholder.constructor!==String||(i=s.placeholder,s.placeholder={element:function(){var s=t.currentItem[0].nodeName.toLowerCase(),n=e("<"+s+">",t.document[0]).addClass(i||t.currentItem[0].className+" ui-sortable-placeholder").removeClass("ui-sortable-helper");return"tbody"===s?t._createTrPlaceholder(t.currentItem.find("tr").eq(0),e("<tr>",t.document[0]).appendTo(n)):"tr"===s?t._createTrPlaceholder(t.currentItem,n):"img"===s&&n.attr("src",t.currentItem.attr("src")),i||n.css("visibility","hidden"),n},update:function(e,n){(!i||s.forcePlaceholderSize)&&(n.height()||n.height(t.currentItem.innerHeight()-parseInt(t.currentItem.css("paddingTop")||0,10)-parseInt(t.currentItem.css("paddingBottom")||0,10)),n.width()||n.width(t.currentItem.innerWidth()-parseInt(t.currentItem.css("paddingLeft")||0,10)-parseInt(t.currentItem.css("paddingRight")||0,10)))}}),t.placeholder=e(s.placeholder.element.call(t.element,t.currentItem)),t.currentItem.after(t.placeholder),s.placeholder.update(t,t.placeholder)},_createTrPlaceholder:function(t,i){var s=this;t.children().each(function(){e("<td>&#160;</td>",s.document[0]).attr("colspan",e(this).attr("colspan")||1).appendTo(i)})},_contactContainers:function(t){var i,s,n,a,o,r,h,l,u,d,c=null,p=null;for(i=this.containers.length-1;i>=0;i--)if(!e.contains(this.currentItem[0],this.containers[i].element[0]))if(this._intersectsWith(this.containers[i].containerCache)){if(c&&e.contains(this.containers[i].element[0],c.element[0]))continue;c=this.containers[i],p=i}else this.containers[i].containerCache.over&&(this.containers[i]._trigger("out",t,this._uiHash(this)),this.containers[i].containerCache.over=0);if(c)if(1===this.containers.length)this.containers[p].containerCache.over||(this.containers[p]._trigger("over",t,this._uiHash(this)),this.containers[p].containerCache.over=1);else{for(n=1e4,a=null,u=c.floating||this._isFloating(this.currentItem),o=u?"left":"top",r=u?"width":"height",d=u?"clientX":"clientY",s=this.items.length-1;s>=0;s--)e.contains(this.containers[p].element[0],this.items[s].item[0])&&this.items[s].item[0]!==this.currentItem[0]&&(h=this.items[s].item.offset()[o],l=!1,t[d]-h>this.items[s][r]/2&&(l=!0),n>Math.abs(t[d]-h)&&(n=Math.abs(t[d]-h),a=this.items[s],this.direction=l?"up":"down"));if(!a&&!this.options.dropOnEmpty)return;if(this.currentContainer===this.containers[p])return this.currentContainer.containerCache.over||(this.containers[p]._trigger("over",t,this._uiHash()),this.currentContainer.containerCache.over=1),void 0;a?this._rearrange(t,a,null,!0):this._rearrange(t,null,this.containers[p].element,!0),this._trigger("change",t,this._uiHash()),this.containers[p]._trigger("change",t,this._uiHash(this)),this.currentContainer=this.containers[p],this.options.placeholder.update(this.currentContainer,this.placeholder),this.containers[p]._trigger("over",t,this._uiHash(this)),this.containers[p].containerCache.over=1}},_createHelper:function(t){var i=this.options,s=e.isFunction(i.helper)?e(i.helper.apply(this.element[0],[t,this.currentItem])):"clone"===i.helper?this.currentItem.clone():this.currentItem;return s.parents("body").length||e("parent"!==i.appendTo?i.appendTo:this.currentItem[0].parentNode)[0].appendChild(s[0]),s[0]===this.currentItem[0]&&(this._storedCSS={width:this.currentItem[0].style.width,height:this.currentItem[0].style.height,position:this.currentItem.css("position"),top:this.currentItem.css("top"),left:this.currentItem.css("left")}),(!s[0].style.width||i.forceHelperSize)&&s.width(this.currentItem.width()),(!s[0].style.height||i.forceHelperSize)&&s.height(this.currentItem.height()),s},_adjustOffsetFromHelper:function(t){"string"==typeof t&&(t=t.split(" ")),e.isArray(t)&&(t={left:+t[0],top:+t[1]||0}),"left"in t&&(this.offset.click.left=t.left+this.margins.left),"right"in t&&(this.offset.click.left=this.helperProportions.width-t.right+this.margins.left),"top"in t&&(this.offset.click.top=t.top+this.margins.top),"bottom"in t&&(this.offset.click.top=this.helperProportions.height-t.bottom+this.margins.top)},_getParentOffset:function(){this.offsetParent=this.helper.offsetParent();var t=this.offsetParent.offset();return"absolute"===this.cssPosition&&this.scrollParent[0]!==this.document[0]&&e.contains(this.scrollParent[0],this.offsetParent[0])&&(t.left+=this.scrollParent.scrollLeft(),t.top+=this.scrollParent.scrollTop()),(this.offsetParent[0]===this.document[0].body||this.offsetParent[0].tagName&&"html"===this.offsetParent[0].tagName.toLowerCase()&&e.ui.ie)&&(t={top:0,left:0}),{top:t.top+(parseInt(this.offsetParent.css("borderTopWidth"),10)||0),left:t.left+(parseInt(this.offsetParent.css("borderLeftWidth"),10)||0)}},_getRelativeOffset:function(){if("relative"===this.cssPosition){var e=this.currentItem.position();return{top:e.top-(parseInt(this.helper.css("top"),10)||0)+this.scrollParent.scrollTop(),left:e.left-(parseInt(this.helper.css("left"),10)||0)+this.scrollParent.scrollLeft()}}return{top:0,left:0}},_cacheMargins:function(){this.margins={left:parseInt(this.currentItem.css("marginLeft"),10)||0,top:parseInt(this.currentItem.css("marginTop"),10)||0}},_cacheHelperProportions:function(){this.helperProportions={width:this.helper.outerWidth(),height:this.helper.outerHeight()}},_setContainment:function(){var t,i,s,n=this.options;"parent"===n.containment&&(n.containment=this.helper[0].parentNode),("document"===n.containment||"window"===n.containment)&&(this.containment=[0-this.offset.relative.left-this.offset.parent.left,0-this.offset.relative.top-this.offset.parent.top,"document"===n.containment?this.document.width():this.window.width()-this.helperProportions.width-this.margins.left,("document"===n.containment?this.document.width():this.window.height()||this.document[0].body.parentNode.scrollHeight)-this.helperProportions.height-this.margins.top]),/^(document|window|parent)$/.test(n.containment)||(t=e(n.containment)[0],i=e(n.containment).offset(),s="hidden"!==e(t).css("overflow"),this.containment=[i.left+(parseInt(e(t).css("borderLeftWidth"),10)||0)+(parseInt(e(t).css("paddingLeft"),10)||0)-this.margins.left,i.top+(parseInt(e(t).css("borderTopWidth"),10)||0)+(parseInt(e(t).css("paddingTop"),10)||0)-this.margins.top,i.left+(s?Math.max(t.scrollWidth,t.offsetWidth):t.offsetWidth)-(parseInt(e(t).css("borderLeftWidth"),10)||0)-(parseInt(e(t).css("paddingRight"),10)||0)-this.helperProportions.width-this.margins.left,i.top+(s?Math.max(t.scrollHeight,t.offsetHeight):t.offsetHeight)-(parseInt(e(t).css("borderTopWidth"),10)||0)-(parseInt(e(t).css("paddingBottom"),10)||0)-this.helperProportions.height-this.margins.top])},_convertPositionTo:function(t,i){i||(i=this.position);var s="absolute"===t?1:-1,n="absolute"!==this.cssPosition||this.scrollParent[0]!==this.document[0]&&e.contains(this.scrollParent[0],this.offsetParent[0])?this.scrollParent:this.offsetParent,a=/(html|body)/i.test(n[0].tagName);return{top:i.top+this.offset.relative.top*s+this.offset.parent.top*s-("fixed"===this.cssPosition?-this.scrollParent.scrollTop():a?0:n.scrollTop())*s,left:i.left+this.offset.relative.left*s+this.offset.parent.left*s-("fixed"===this.cssPosition?-this.scrollParent.scrollLeft():a?0:n.scrollLeft())*s}},_generatePosition:function(t){var i,s,n=this.options,a=t.pageX,o=t.pageY,r="absolute"!==this.cssPosition||this.scrollParent[0]!==this.document[0]&&e.contains(this.scrollParent[0],this.offsetParent[0])?this.scrollParent:this.offsetParent,h=/(html|body)/i.test(r[0].tagName);return"relative"!==this.cssPosition||this.scrollParent[0]!==this.document[0]&&this.scrollParent[0]!==this.offsetParent[0]||(this.offset.relative=this._getRelativeOffset()),this.originalPosition&&(this.containment&&(t.pageX-this.offset.click.left<this.containment[0]&&(a=this.containment[0]+this.offset.click.left),t.pageY-this.offset.click.top<this.containment[1]&&(o=this.containment[1]+this.offset.click.top),t.pageX-this.offset.click.left>this.containment[2]&&(a=this.containment[2]+this.offset.click.left),t.pageY-this.offset.click.top>this.containment[3]&&(o=this.containment[3]+this.offset.click.top)),n.grid&&(i=this.originalPageY+Math.round((o-this.originalPageY)/n.grid[1])*n.grid[1],o=this.containment?i-this.offset.click.top>=this.containment[1]&&i-this.offset.click.top<=this.containment[3]?i:i-this.offset.click.top>=this.containment[1]?i-n.grid[1]:i+n.grid[1]:i,s=this.originalPageX+Math.round((a-this.originalPageX)/n.grid[0])*n.grid[0],a=this.containment?s-this.offset.click.left>=this.containment[0]&&s-this.offset.click.left<=this.containment[2]?s:s-this.offset.click.left>=this.containment[0]?s-n.grid[0]:s+n.grid[0]:s)),{top:o-this.offset.click.top-this.offset.relative.top-this.offset.parent.top+("fixed"===this.cssPosition?-this.scrollParent.scrollTop():h?0:r.scrollTop()),left:a-this.offset.click.left-this.offset.relative.left-this.offset.parent.left+("fixed"===this.cssPosition?-this.scrollParent.scrollLeft():h?0:r.scrollLeft())}},_rearrange:function(e,t,i,s){i?i[0].appendChild(this.placeholder[0]):t.item[0].parentNode.insertBefore(this.placeholder[0],"down"===this.direction?t.item[0]:t.item[0].nextSibling),this.counter=this.counter?++this.counter:1;var n=this.counter;this._delay(function(){n===this.counter&&this.refreshPositions(!s)})},_clear:function(e,t){function i(e,t,i){return function(s){i._trigger(e,s,t._uiHash(t))}}this.reverting=!1;var s,n=[];if(!this._noFinalSort&&this.currentItem.parent().length&&this.placeholder.before(this.currentItem),this._noFinalSort=null,this.helper[0]===this.currentItem[0]){for(s in this._storedCSS)("auto"===this._storedCSS[s]||"static"===this._storedCSS[s])&&(this._storedCSS[s]="");this.currentItem.css(this._storedCSS).removeClass("ui-sortable-helper")}else this.currentItem.show();for(this.fromOutside&&!t&&n.push(function(e){this._trigger("receive",e,this._uiHash(this.fromOutside))}),!this.fromOutside&&this.domPosition.prev===this.currentItem.prev().not(".ui-sortable-helper")[0]&&this.domPosition.parent===this.currentItem.parent()[0]||t||n.push(function(e){this._trigger("update",e,this._uiHash())}),this!==this.currentContainer&&(t||(n.push(function(e){this._trigger("remove",e,this._uiHash())}),n.push(function(e){return function(t){e._trigger("receive",t,this._uiHash(this))}}.call(this,this.currentContainer)),n.push(function(e){return function(t){e._trigger("update",t,this._uiHash(this))}}.call(this,this.currentContainer)))),s=this.containers.length-1;s>=0;s--)t||n.push(i("deactivate",this,this.containers[s])),this.containers[s].containerCache.over&&(n.push(i("out",this,this.containers[s])),this.containers[s].containerCache.over=0);if(this.storedCursor&&(this.document.find("body").css("cursor",this.storedCursor),this.storedStylesheet.remove()),this._storedOpacity&&this.helper.css("opacity",this._storedOpacity),this._storedZIndex&&this.helper.css("zIndex","auto"===this._storedZIndex?"":this._storedZIndex),this.dragging=!1,t||this._trigger("beforeStop",e,this._uiHash()),this.placeholder[0].parentNode.removeChild(this.placeholder[0]),this.cancelHelperRemoval||(this.helper[0]!==this.currentItem[0]&&this.helper.remove(),this.helper=null),!t){for(s=0;n.length>s;s++)n[s].call(this,e);this._trigger("stop",e,this._uiHash())}return this.fromOutside=!1,!this.cancelHelperRemoval},_trigger:function(){e.Widget.prototype._trigger.apply(this,arguments)===!1&&this.cancel()},_uiHash:function(t){var i=t||this;return{helper:i.helper,placeholder:i.placeholder||e([]),position:i.position,originalPosition:i.originalPosition,offset:i.positionAbs,item:i.currentItem,sender:t?t.element:null}}}),e.widget("ui.spinner",{version:"1.11.4",defaultElement:"<input>",widgetEventPrefix:"spin",options:{culture:null,icons:{down:"ui-icon-triangle-1-s",up:"ui-icon-triangle-1-n"},incremental:!0,max:null,min:null,numberFormat:null,page:10,step:1,change:null,spin:null,start:null,stop:null},_create:function(){this._setOption("max",this.options.max),this._setOption("min",this.options.min),this._setOption("step",this.options.step),""!==this.value()&&this._value(this.element.val(),!0),this._draw(),this._on(this._events),this._refresh(),this._on(this.window,{beforeunload:function(){this.element.removeAttr("autocomplete")}})},_getCreateOptions:function(){var t={},i=this.element;return e.each(["min","max","step"],function(e,s){var n=i.attr(s);void 0!==n&&n.length&&(t[s]=n)}),t},_events:{keydown:function(e){this._start(e)&&this._keydown(e)&&e.preventDefault()},keyup:"_stop",focus:function(){this.previous=this.element.val()},blur:function(e){return this.cancelBlur?(delete this.cancelBlur,void 0):(this._stop(),this._refresh(),this.previous!==this.element.val()&&this._trigger("change",e),void 0)},mousewheel:function(e,t){if(t){if(!this.spinning&&!this._start(e))return!1;this._spin((t>0?1:-1)*this.options.step,e),clearTimeout(this.mousewheelTimer),this.mousewheelTimer=this._delay(function(){this.spinning&&this._stop(e)},100),e.preventDefault()}},"mousedown .ui-spinner-button":function(t){function i(){var e=this.element[0]===this.document[0].activeElement;e||(this.element.focus(),this.previous=s,this._delay(function(){this.previous=s}))}var s;s=this.element[0]===this.document[0].activeElement?this.previous:this.element.val(),t.preventDefault(),i.call(this),this.cancelBlur=!0,this._delay(function(){delete this.cancelBlur,i.call(this)}),this._start(t)!==!1&&this._repeat(null,e(t.currentTarget).hasClass("ui-spinner-up")?1:-1,t)},"mouseup .ui-spinner-button":"_stop","mouseenter .ui-spinner-button":function(t){return e(t.currentTarget).hasClass("ui-state-active")?this._start(t)===!1?!1:(this._repeat(null,e(t.currentTarget).hasClass("ui-spinner-up")?1:-1,t),void 0):void 0},"mouseleave .ui-spinner-button":"_stop"},_draw:function(){var e=this.uiSpinner=this.element.addClass("ui-spinner-input").attr("autocomplete","off").wrap(this._uiSpinnerHtml()).parent().append(this._buttonHtml());this.element.attr("role","spinbutton"),this.buttons=e.find(".ui-spinner-button").attr("tabIndex",-1).button().removeClass("ui-corner-all"),this.buttons.height()>Math.ceil(.5*e.height())&&e.height()>0&&e.height(e.height()),this.options.disabled&&this.disable()},_keydown:function(t){var i=this.options,s=e.ui.keyCode;switch(t.keyCode){case s.UP:return this._repeat(null,1,t),!0;case s.DOWN:return this._repeat(null,-1,t),!0;case s.PAGE_UP:return this._repeat(null,i.page,t),!0;case s.PAGE_DOWN:return this._repeat(null,-i.page,t),!0}return!1},_uiSpinnerHtml:function(){return"<span class='ui-spinner ui-widget ui-widget-content ui-corner-all'></span>"},_buttonHtml:function(){return"<a class='ui-spinner-button ui-spinner-up ui-corner-tr'><span class='ui-icon "+this.options.icons.up+"'>&#9650;</span>"+"</a>"+"<a class='ui-spinner-button ui-spinner-down ui-corner-br'>"+"<span class='ui-icon "+this.options.icons.down+"'>&#9660;</span>"+"</a>"},_start:function(e){return this.spinning||this._trigger("start",e)!==!1?(this.counter||(this.counter=1),this.spinning=!0,!0):!1},_repeat:function(e,t,i){e=e||500,clearTimeout(this.timer),this.timer=this._delay(function(){this._repeat(40,t,i)},e),this._spin(t*this.options.step,i)},_spin:function(e,t){var i=this.value()||0;this.counter||(this.counter=1),i=this._adjustValue(i+e*this._increment(this.counter)),this.spinning&&this._trigger("spin",t,{value:i})===!1||(this._value(i),this.counter++)},_increment:function(t){var i=this.options.incremental;return i?e.isFunction(i)?i(t):Math.floor(t*t*t/5e4-t*t/500+17*t/200+1):1},_precision:function(){var e=this._precisionOf(this.options.step);return null!==this.options.min&&(e=Math.max(e,this._precisionOf(this.options.min))),e},_precisionOf:function(e){var t=""+e,i=t.indexOf(".");return-1===i?0:t.length-i-1},_adjustValue:function(e){var t,i,s=this.options;return t=null!==s.min?s.min:0,i=e-t,i=Math.round(i/s.step)*s.step,e=t+i,e=parseFloat(e.toFixed(this._precision())),null!==s.max&&e>s.max?s.max:null!==s.min&&s.min>e?s.min:e},_stop:function(e){this.spinning&&(clearTimeout(this.timer),clearTimeout(this.mousewheelTimer),this.counter=0,this.spinning=!1,this._trigger("stop",e))},_setOption:function(e,t){if("culture"===e||"numberFormat"===e){var i=this._parse(this.element.val());return this.options[e]=t,this.element.val(this._format(i)),void 0}("max"===e||"min"===e||"step"===e)&&"string"==typeof t&&(t=this._parse(t)),"icons"===e&&(this.buttons.first().find(".ui-icon").removeClass(this.options.icons.up).addClass(t.up),this.buttons.last().find(".ui-icon").removeClass(this.options.icons.down).addClass(t.down)),this._super(e,t),"disabled"===e&&(this.widget().toggleClass("ui-state-disabled",!!t),this.element.prop("disabled",!!t),this.buttons.button(t?"disable":"enable"))},_setOptions:h(function(e){this._super(e)}),_parse:function(e){return"string"==typeof e&&""!==e&&(e=window.Globalize&&this.options.numberFormat?Globalize.parseFloat(e,10,this.options.culture):+e),""===e||isNaN(e)?null:e},_format:function(e){return""===e?"":window.Globalize&&this.options.numberFormat?Globalize.format(e,this.options.numberFormat,this.options.culture):e},_refresh:function(){this.element.attr({"aria-valuemin":this.options.min,"aria-valuemax":this.options.max,"aria-valuenow":this._parse(this.element.val())})},isValid:function(){var e=this.value();return null===e?!1:e===this._adjustValue(e)},_value:function(e,t){var i;""!==e&&(i=this._parse(e),null!==i&&(t||(i=this._adjustValue(i)),e=this._format(i))),this.element.val(e),this._refresh()},_destroy:function(){this.element.removeClass("ui-spinner-input").prop("disabled",!1).removeAttr("autocomplete").removeAttr("role").removeAttr("aria-valuemin").removeAttr("aria-valuemax").removeAttr("aria-valuenow"),this.uiSpinner.replaceWith(this.element)},stepUp:h(function(e){this._stepUp(e)}),_stepUp:function(e){this._start()&&(this._spin((e||1)*this.options.step),this._stop())},stepDown:h(function(e){this._stepDown(e)}),_stepDown:function(e){this._start()&&(this._spin((e||1)*-this.options.step),this._stop())},pageUp:h(function(e){this._stepUp((e||1)*this.options.page)}),pageDown:h(function(e){this._stepDown((e||1)*this.options.page)}),value:function(e){return arguments.length?(h(this._value).call(this,e),void 0):this._parse(this.element.val())},widget:function(){return this.uiSpinner}}),e.widget("ui.tabs",{version:"1.11.4",delay:300,options:{active:null,collapsible:!1,event:"click",heightStyle:"content",hide:null,show:null,activate:null,beforeActivate:null,beforeLoad:null,load:null},_isLocal:function(){var e=/#.*$/;return function(t){var i,s;t=t.cloneNode(!1),i=t.href.replace(e,""),s=location.href.replace(e,"");try{i=decodeURIComponent(i)}catch(n){}try{s=decodeURIComponent(s)}catch(n){}return t.hash.length>1&&i===s}}(),_create:function(){var t=this,i=this.options;this.running=!1,this.element.addClass("ui-tabs ui-widget ui-widget-content ui-corner-all").toggleClass("ui-tabs-collapsible",i.collapsible),this._processTabs(),i.active=this._initialActive(),e.isArray(i.disabled)&&(i.disabled=e.unique(i.disabled.concat(e.map(this.tabs.filter(".ui-state-disabled"),function(e){return t.tabs.index(e)}))).sort()),this.active=this.options.active!==!1&&this.anchors.length?this._findActive(i.active):e(),this._refresh(),this.active.length&&this.load(i.active)},_initialActive:function(){var t=this.options.active,i=this.options.collapsible,s=location.hash.substring(1);return null===t&&(s&&this.tabs.each(function(i,n){return e(n).attr("aria-controls")===s?(t=i,!1):void 0}),null===t&&(t=this.tabs.index(this.tabs.filter(".ui-tabs-active"))),(null===t||-1===t)&&(t=this.tabs.length?0:!1)),t!==!1&&(t=this.tabs.index(this.tabs.eq(t)),-1===t&&(t=i?!1:0)),!i&&t===!1&&this.anchors.length&&(t=0),t},_getCreateEventData:function(){return{tab:this.active,panel:this.active.length?this._getPanelForTab(this.active):e()}},_tabKeydown:function(t){var i=e(this.document[0].activeElement).closest("li"),s=this.tabs.index(i),n=!0;if(!this._handlePageNav(t)){switch(t.keyCode){case e.ui.keyCode.RIGHT:case e.ui.keyCode.DOWN:s++;break;case e.ui.keyCode.UP:case e.ui.keyCode.LEFT:n=!1,s--;break;case e.ui.keyCode.END:s=this.anchors.length-1;break;case e.ui.keyCode.HOME:s=0;break;case e.ui.keyCode.SPACE:return t.preventDefault(),clearTimeout(this.activating),this._activate(s),void 0;case e.ui.keyCode.ENTER:return t.preventDefault(),clearTimeout(this.activating),this._activate(s===this.options.active?!1:s),void 0;default:return}t.preventDefault(),clearTimeout(this.activating),s=this._focusNextTab(s,n),t.ctrlKey||t.metaKey||(i.attr("aria-selected","false"),this.tabs.eq(s).attr("aria-selected","true"),this.activating=this._delay(function(){this.option("active",s)},this.delay))}},_panelKeydown:function(t){this._handlePageNav(t)||t.ctrlKey&&t.keyCode===e.ui.keyCode.UP&&(t.preventDefault(),this.active.focus())},_handlePageNav:function(t){return t.altKey&&t.keyCode===e.ui.keyCode.PAGE_UP?(this._activate(this._focusNextTab(this.options.active-1,!1)),!0):t.altKey&&t.keyCode===e.ui.keyCode.PAGE_DOWN?(this._activate(this._focusNextTab(this.options.active+1,!0)),!0):void 0},_findNextTab:function(t,i){function s(){return t>n&&(t=0),0>t&&(t=n),t}for(var n=this.tabs.length-1;-1!==e.inArray(s(),this.options.disabled);)t=i?t+1:t-1;return t},_focusNextTab:function(e,t){return e=this._findNextTab(e,t),this.tabs.eq(e).focus(),e},_setOption:function(e,t){return"active"===e?(this._activate(t),void 0):"disabled"===e?(this._setupDisabled(t),void 0):(this._super(e,t),"collapsible"===e&&(this.element.toggleClass("ui-tabs-collapsible",t),t||this.options.active!==!1||this._activate(0)),"event"===e&&this._setupEvents(t),"heightStyle"===e&&this._setupHeightStyle(t),void 0)},_sanitizeSelector:function(e){return e?e.replace(/[!"$%&'()*+,.\/:;<=>?@\[\]\^`{|}~]/g,"\\$&"):""},refresh:function(){var t=this.options,i=this.tablist.children(":has(a[href])");t.disabled=e.map(i.filter(".ui-state-disabled"),function(e){return i.index(e)}),this._processTabs(),t.active!==!1&&this.anchors.length?this.active.length&&!e.contains(this.tablist[0],this.active[0])?this.tabs.length===t.disabled.length?(t.active=!1,this.active=e()):this._activate(this._findNextTab(Math.max(0,t.active-1),!1)):t.active=this.tabs.index(this.active):(t.active=!1,this.active=e()),this._refresh()},_refresh:function(){this._setupDisabled(this.options.disabled),this._setupEvents(this.options.event),this._setupHeightStyle(this.options.heightStyle),this.tabs.not(this.active).attr({"aria-selected":"false","aria-expanded":"false",tabIndex:-1}),this.panels.not(this._getPanelForTab(this.active)).hide().attr({"aria-hidden":"true"}),this.active.length?(this.active.addClass("ui-tabs-active ui-state-active").attr({"aria-selected":"true","aria-expanded":"true",tabIndex:0}),this._getPanelForTab(this.active).show().attr({"aria-hidden":"false"})):this.tabs.eq(0).attr("tabIndex",0)},_processTabs:function(){var t=this,i=this.tabs,s=this.anchors,n=this.panels;
this.tablist=this._getList().addClass("ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all").attr("role","tablist").delegate("> li","mousedown"+this.eventNamespace,function(t){e(this).is(".ui-state-disabled")&&t.preventDefault()}).delegate(".ui-tabs-anchor","focus"+this.eventNamespace,function(){e(this).closest("li").is(".ui-state-disabled")&&this.blur()}),this.tabs=this.tablist.find("> li:has(a[href])").addClass("ui-state-default ui-corner-top").attr({role:"tab",tabIndex:-1}),this.anchors=this.tabs.map(function(){return e("a",this)[0]}).addClass("ui-tabs-anchor").attr({role:"presentation",tabIndex:-1}),this.panels=e(),this.anchors.each(function(i,s){var n,a,o,r=e(s).uniqueId().attr("id"),h=e(s).closest("li"),l=h.attr("aria-controls");t._isLocal(s)?(n=s.hash,o=n.substring(1),a=t.element.find(t._sanitizeSelector(n))):(o=h.attr("aria-controls")||e({}).uniqueId()[0].id,n="#"+o,a=t.element.find(n),a.length||(a=t._createPanel(o),a.insertAfter(t.panels[i-1]||t.tablist)),a.attr("aria-live","polite")),a.length&&(t.panels=t.panels.add(a)),l&&h.data("ui-tabs-aria-controls",l),h.attr({"aria-controls":o,"aria-labelledby":r}),a.attr("aria-labelledby",r)}),this.panels.addClass("ui-tabs-panel ui-widget-content ui-corner-bottom").attr("role","tabpanel"),i&&(this._off(i.not(this.tabs)),this._off(s.not(this.anchors)),this._off(n.not(this.panels)))},_getList:function(){return this.tablist||this.element.find("ol,ul").eq(0)},_createPanel:function(t){return e("<div>").attr("id",t).addClass("ui-tabs-panel ui-widget-content ui-corner-bottom").data("ui-tabs-destroy",!0)},_setupDisabled:function(t){e.isArray(t)&&(t.length?t.length===this.anchors.length&&(t=!0):t=!1);for(var i,s=0;i=this.tabs[s];s++)t===!0||-1!==e.inArray(s,t)?e(i).addClass("ui-state-disabled").attr("aria-disabled","true"):e(i).removeClass("ui-state-disabled").removeAttr("aria-disabled");this.options.disabled=t},_setupEvents:function(t){var i={};t&&e.each(t.split(" "),function(e,t){i[t]="_eventHandler"}),this._off(this.anchors.add(this.tabs).add(this.panels)),this._on(!0,this.anchors,{click:function(e){e.preventDefault()}}),this._on(this.anchors,i),this._on(this.tabs,{keydown:"_tabKeydown"}),this._on(this.panels,{keydown:"_panelKeydown"}),this._focusable(this.tabs),this._hoverable(this.tabs)},_setupHeightStyle:function(t){var i,s=this.element.parent();"fill"===t?(i=s.height(),i-=this.element.outerHeight()-this.element.height(),this.element.siblings(":visible").each(function(){var t=e(this),s=t.css("position");"absolute"!==s&&"fixed"!==s&&(i-=t.outerHeight(!0))}),this.element.children().not(this.panels).each(function(){i-=e(this).outerHeight(!0)}),this.panels.each(function(){e(this).height(Math.max(0,i-e(this).innerHeight()+e(this).height()))}).css("overflow","auto")):"auto"===t&&(i=0,this.panels.each(function(){i=Math.max(i,e(this).height("").height())}).height(i))},_eventHandler:function(t){var i=this.options,s=this.active,n=e(t.currentTarget),a=n.closest("li"),o=a[0]===s[0],r=o&&i.collapsible,h=r?e():this._getPanelForTab(a),l=s.length?this._getPanelForTab(s):e(),u={oldTab:s,oldPanel:l,newTab:r?e():a,newPanel:h};t.preventDefault(),a.hasClass("ui-state-disabled")||a.hasClass("ui-tabs-loading")||this.running||o&&!i.collapsible||this._trigger("beforeActivate",t,u)===!1||(i.active=r?!1:this.tabs.index(a),this.active=o?e():a,this.xhr&&this.xhr.abort(),l.length||h.length||e.error("jQuery UI Tabs: Mismatching fragment identifier."),h.length&&this.load(this.tabs.index(a),t),this._toggle(t,u))},_toggle:function(t,i){function s(){a.running=!1,a._trigger("activate",t,i)}function n(){i.newTab.closest("li").addClass("ui-tabs-active ui-state-active"),o.length&&a.options.show?a._show(o,a.options.show,s):(o.show(),s())}var a=this,o=i.newPanel,r=i.oldPanel;this.running=!0,r.length&&this.options.hide?this._hide(r,this.options.hide,function(){i.oldTab.closest("li").removeClass("ui-tabs-active ui-state-active"),n()}):(i.oldTab.closest("li").removeClass("ui-tabs-active ui-state-active"),r.hide(),n()),r.attr("aria-hidden","true"),i.oldTab.attr({"aria-selected":"false","aria-expanded":"false"}),o.length&&r.length?i.oldTab.attr("tabIndex",-1):o.length&&this.tabs.filter(function(){return 0===e(this).attr("tabIndex")}).attr("tabIndex",-1),o.attr("aria-hidden","false"),i.newTab.attr({"aria-selected":"true","aria-expanded":"true",tabIndex:0})},_activate:function(t){var i,s=this._findActive(t);s[0]!==this.active[0]&&(s.length||(s=this.active),i=s.find(".ui-tabs-anchor")[0],this._eventHandler({target:i,currentTarget:i,preventDefault:e.noop}))},_findActive:function(t){return t===!1?e():this.tabs.eq(t)},_getIndex:function(e){return"string"==typeof e&&(e=this.anchors.index(this.anchors.filter("[href$='"+e+"']"))),e},_destroy:function(){this.xhr&&this.xhr.abort(),this.element.removeClass("ui-tabs ui-widget ui-widget-content ui-corner-all ui-tabs-collapsible"),this.tablist.removeClass("ui-tabs-nav ui-helper-reset ui-helper-clearfix ui-widget-header ui-corner-all").removeAttr("role"),this.anchors.removeClass("ui-tabs-anchor").removeAttr("role").removeAttr("tabIndex").removeUniqueId(),this.tablist.unbind(this.eventNamespace),this.tabs.add(this.panels).each(function(){e.data(this,"ui-tabs-destroy")?e(this).remove():e(this).removeClass("ui-state-default ui-state-active ui-state-disabled ui-corner-top ui-corner-bottom ui-widget-content ui-tabs-active ui-tabs-panel").removeAttr("tabIndex").removeAttr("aria-live").removeAttr("aria-busy").removeAttr("aria-selected").removeAttr("aria-labelledby").removeAttr("aria-hidden").removeAttr("aria-expanded").removeAttr("role")}),this.tabs.each(function(){var t=e(this),i=t.data("ui-tabs-aria-controls");i?t.attr("aria-controls",i).removeData("ui-tabs-aria-controls"):t.removeAttr("aria-controls")}),this.panels.show(),"content"!==this.options.heightStyle&&this.panels.css("height","")},enable:function(t){var i=this.options.disabled;i!==!1&&(void 0===t?i=!1:(t=this._getIndex(t),i=e.isArray(i)?e.map(i,function(e){return e!==t?e:null}):e.map(this.tabs,function(e,i){return i!==t?i:null})),this._setupDisabled(i))},disable:function(t){var i=this.options.disabled;if(i!==!0){if(void 0===t)i=!0;else{if(t=this._getIndex(t),-1!==e.inArray(t,i))return;i=e.isArray(i)?e.merge([t],i).sort():[t]}this._setupDisabled(i)}},load:function(t,i){t=this._getIndex(t);var s=this,n=this.tabs.eq(t),a=n.find(".ui-tabs-anchor"),o=this._getPanelForTab(n),r={tab:n,panel:o},h=function(e,t){"abort"===t&&s.panels.stop(!1,!0),n.removeClass("ui-tabs-loading"),o.removeAttr("aria-busy"),e===s.xhr&&delete s.xhr};this._isLocal(a[0])||(this.xhr=e.ajax(this._ajaxSettings(a,i,r)),this.xhr&&"canceled"!==this.xhr.statusText&&(n.addClass("ui-tabs-loading"),o.attr("aria-busy","true"),this.xhr.done(function(e,t,n){setTimeout(function(){o.html(e),s._trigger("load",i,r),h(n,t)},1)}).fail(function(e,t){setTimeout(function(){h(e,t)},1)})))},_ajaxSettings:function(t,i,s){var n=this;return{url:t.attr("href"),beforeSend:function(t,a){return n._trigger("beforeLoad",i,e.extend({jqXHR:t,ajaxSettings:a},s))}}},_getPanelForTab:function(t){var i=e(t).attr("aria-controls");return this.element.find(this._sanitizeSelector("#"+i))}}),e.widget("ui.tooltip",{version:"1.11.4",options:{content:function(){var t=e(this).attr("title")||"";return e("<a>").text(t).html()},hide:!0,items:"[title]:not([disabled])",position:{my:"left top+15",at:"left bottom",collision:"flipfit flip"},show:!0,tooltipClass:null,track:!1,close:null,open:null},_addDescribedBy:function(t,i){var s=(t.attr("aria-describedby")||"").split(/\s+/);s.push(i),t.data("ui-tooltip-id",i).attr("aria-describedby",e.trim(s.join(" ")))},_removeDescribedBy:function(t){var i=t.data("ui-tooltip-id"),s=(t.attr("aria-describedby")||"").split(/\s+/),n=e.inArray(i,s);-1!==n&&s.splice(n,1),t.removeData("ui-tooltip-id"),s=e.trim(s.join(" ")),s?t.attr("aria-describedby",s):t.removeAttr("aria-describedby")},_create:function(){this._on({mouseover:"open",focusin:"open"}),this.tooltips={},this.parents={},this.options.disabled&&this._disable(),this.liveRegion=e("<div>").attr({role:"log","aria-live":"assertive","aria-relevant":"additions"}).addClass("ui-helper-hidden-accessible").appendTo(this.document[0].body)},_setOption:function(t,i){var s=this;return"disabled"===t?(this[i?"_disable":"_enable"](),this.options[t]=i,void 0):(this._super(t,i),"content"===t&&e.each(this.tooltips,function(e,t){s._updateContent(t.element)}),void 0)},_disable:function(){var t=this;e.each(this.tooltips,function(i,s){var n=e.Event("blur");n.target=n.currentTarget=s.element[0],t.close(n,!0)}),this.element.find(this.options.items).addBack().each(function(){var t=e(this);t.is("[title]")&&t.data("ui-tooltip-title",t.attr("title")).removeAttr("title")})},_enable:function(){this.element.find(this.options.items).addBack().each(function(){var t=e(this);t.data("ui-tooltip-title")&&t.attr("title",t.data("ui-tooltip-title"))})},open:function(t){var i=this,s=e(t?t.target:this.element).closest(this.options.items);s.length&&!s.data("ui-tooltip-id")&&(s.attr("title")&&s.data("ui-tooltip-title",s.attr("title")),s.data("ui-tooltip-open",!0),t&&"mouseover"===t.type&&s.parents().each(function(){var t,s=e(this);s.data("ui-tooltip-open")&&(t=e.Event("blur"),t.target=t.currentTarget=this,i.close(t,!0)),s.attr("title")&&(s.uniqueId(),i.parents[this.id]={element:this,title:s.attr("title")},s.attr("title",""))}),this._registerCloseHandlers(t,s),this._updateContent(s,t))},_updateContent:function(e,t){var i,s=this.options.content,n=this,a=t?t.type:null;return"string"==typeof s?this._open(t,e,s):(i=s.call(e[0],function(i){n._delay(function(){e.data("ui-tooltip-open")&&(t&&(t.type=a),this._open(t,e,i))})}),i&&this._open(t,e,i),void 0)},_open:function(t,i,s){function n(e){l.of=e,o.is(":hidden")||o.position(l)}var a,o,r,h,l=e.extend({},this.options.position);if(s){if(a=this._find(i))return a.tooltip.find(".ui-tooltip-content").html(s),void 0;i.is("[title]")&&(t&&"mouseover"===t.type?i.attr("title",""):i.removeAttr("title")),a=this._tooltip(i),o=a.tooltip,this._addDescribedBy(i,o.attr("id")),o.find(".ui-tooltip-content").html(s),this.liveRegion.children().hide(),s.clone?(h=s.clone(),h.removeAttr("id").find("[id]").removeAttr("id")):h=s,e("<div>").html(h).appendTo(this.liveRegion),this.options.track&&t&&/^mouse/.test(t.type)?(this._on(this.document,{mousemove:n}),n(t)):o.position(e.extend({of:i},this.options.position)),o.hide(),this._show(o,this.options.show),this.options.show&&this.options.show.delay&&(r=this.delayedShow=setInterval(function(){o.is(":visible")&&(n(l.of),clearInterval(r))},e.fx.interval)),this._trigger("open",t,{tooltip:o})}},_registerCloseHandlers:function(t,i){var s={keyup:function(t){if(t.keyCode===e.ui.keyCode.ESCAPE){var s=e.Event(t);s.currentTarget=i[0],this.close(s,!0)}}};i[0]!==this.element[0]&&(s.remove=function(){this._removeTooltip(this._find(i).tooltip)}),t&&"mouseover"!==t.type||(s.mouseleave="close"),t&&"focusin"!==t.type||(s.focusout="close"),this._on(!0,i,s)},close:function(t){var i,s=this,n=e(t?t.currentTarget:this.element),a=this._find(n);return a?(i=a.tooltip,a.closing||(clearInterval(this.delayedShow),n.data("ui-tooltip-title")&&!n.attr("title")&&n.attr("title",n.data("ui-tooltip-title")),this._removeDescribedBy(n),a.hiding=!0,i.stop(!0),this._hide(i,this.options.hide,function(){s._removeTooltip(e(this))}),n.removeData("ui-tooltip-open"),this._off(n,"mouseleave focusout keyup"),n[0]!==this.element[0]&&this._off(n,"remove"),this._off(this.document,"mousemove"),t&&"mouseleave"===t.type&&e.each(this.parents,function(t,i){e(i.element).attr("title",i.title),delete s.parents[t]}),a.closing=!0,this._trigger("close",t,{tooltip:i}),a.hiding||(a.closing=!1)),void 0):(n.removeData("ui-tooltip-open"),void 0)},_tooltip:function(t){var i=e("<div>").attr("role","tooltip").addClass("ui-tooltip ui-widget ui-corner-all ui-widget-content "+(this.options.tooltipClass||"")),s=i.uniqueId().attr("id");return e("<div>").addClass("ui-tooltip-content").appendTo(i),i.appendTo(this.document[0].body),this.tooltips[s]={element:t,tooltip:i}},_find:function(e){var t=e.data("ui-tooltip-id");return t?this.tooltips[t]:null},_removeTooltip:function(e){e.remove(),delete this.tooltips[e.attr("id")]},_destroy:function(){var t=this;e.each(this.tooltips,function(i,s){var n=e.Event("blur"),a=s.element;n.target=n.currentTarget=a[0],t.close(n,!0),e("#"+i).remove(),a.data("ui-tooltip-title")&&(a.attr("title")||a.attr("title",a.data("ui-tooltip-title")),a.removeData("ui-tooltip-title"))}),this.liveRegion.remove()}})});
/*!
 * Copyright 2012, Chris Wanstrath
 * Released under the MIT License
 * https://github.com/defunkt/jquery-pjax
 */

(function ($) {

    // When called on a container with a selector, fetches the href with
    // ajax into the container or with the data-pjax attribute on the link
    // itself.
    //
    // Tries to make sure the back button and ctrl+click work the way
    // you'd expect.
    //
    // Exported as $.fn.pjax
    //
    // Accepts a jQuery ajax options object that may include these
    // pjax specific options:
    //
    //
    // container - Where to stick the response body. Usually a String selector.
    //             $(container).html(xhr.responseBody)
    //             (default: current jquery context)
    //      push - Whether to pushState the URL. Defaults to true (of course).
    //   replace - Want to use replaceState instead? That's cool.
    //
    // For convenience the second parameter can be either the container or
    // the options object.
    //
    // Returns the jQuery object
    function fnPjax(selector, container, options) {
        var context = this
        return this.on('click.pjax', selector, function (event) {
            var opts = $.extend({}, optionsFor(container, options))
            if (!opts.container)
                opts.container = $(this).attr('data-pjax') || context
            handleClick(event, opts)
        })
    }

    // Public: pjax on click handler
    //
    // Exported as $.pjax.click.
    //
    // event   - "click" jQuery.Event
    // options - pjax options
    //
    // Examples
    //
    //   $(document).on('click', 'a', $.pjax.click)
    //   // is the same as
    //   $(document).pjax('a')
    //
    //  $(document).on('click', 'a', function(event) {
    //    var container = $(this).closest('[data-pjax-container]')
    //    $.pjax.click(event, container)
    //  })
    //
    // Returns nothing.
    function handleClick(event, container, options) {
        options = optionsFor(container, options)

        var link = event.currentTarget

        if (link.tagName.toUpperCase() !== 'A')
            throw "$.fn.pjax or $.pjax.click requires an anchor element"

        // Middle click, cmd click, and ctrl click should open
        // links in a new tab as normal.
        if (event.which > 1 || event.metaKey || event.ctrlKey || event.shiftKey || event.altKey)
            return

        // Ignore cross origin links
        if (location.protocol !== link.protocol || location.hostname !== link.hostname)
            return

        // Ignore case when a hash is being tacked on the current URL
        if (link.href.indexOf('#') > -1 && stripHash(link) == stripHash(location))
            return

        // Ignore event with default prevented
        if (event.isDefaultPrevented())
            return

        var defaults = {
            url: link.href,
            container: $(link).attr('data-pjax'),
            target: link
        }

        var opts = $.extend({}, defaults, options)
        var clickEvent = $.Event('pjax:click')
        $(link).trigger(clickEvent, [opts])

        if (!clickEvent.isDefaultPrevented()) {
            pjax(opts)
            event.preventDefault()
            $(link).trigger('pjax:clicked', [opts])
        }
    }

    // Public: pjax on form submit handler
    //
    // Exported as $.pjax.submit
    //
    // event   - "click" jQuery.Event
    // options - pjax options
    //
    // Examples
    //
    //  $(document).on('submit', 'form', function(event) {
    //    var container = $(this).closest('[data-pjax-container]')
    //    $.pjax.submit(event, container)
    //  })
    //
    // Returns nothing.
    function handleSubmit(event, container, options) {
        options = optionsFor(container, options)

        var form = event.currentTarget
        var $form = $(form)

        if (form.tagName.toUpperCase() !== 'FORM')
            throw "$.pjax.submit requires a form element"

        var defaults = {
            type: ($form.attr('method') || 'GET').toUpperCase(),
            url: $form.attr('action'),
            container: $form.attr('data-pjax'),
            target: form
        }

        if (defaults.type !== 'GET' && window.FormData !== undefined) {
            defaults.data = new FormData(form);
            defaults.processData = false;
            defaults.contentType = false;
        } else {
            // Can't handle file uploads, exit
            if ($(form).find(':file').length) {
                return;
            }

            // Fallback to manually serializing the fields
            defaults.data = $(form).serializeArray();
        }

        pjax($.extend({}, defaults, options))

        event.preventDefault()
    }

    // Loads a URL with ajax, puts the response body inside a container,
    // then pushState()'s the loaded URL.
    //
    // Works just like $.ajax in that it accepts a jQuery ajax
    // settings object (with keys like url, type, data, etc).
    //
    // Accepts these extra keys:
    //
    // container - Where to stick the response body.
    //             $(container).html(xhr.responseBody)
    //      push - Whether to pushState the URL. Defaults to true (of course).
    //   replace - Want to use replaceState instead? That's cool.
    //
    // Use it just like $.ajax:
    //
    //   var xhr = $.pjax({ url: this.href, container: '#main' })
    //   console.log( xhr.readyState )
    //
    // Returns whatever $.ajax returns.
    function pjax(options) {
        options = $.extend(true, {}, $.ajaxSettings, pjax.defaults, options)

        if ($.isFunction(options.url)) {
            options.url = options.url()
        }

        var target = options.target

        var hash = parseURL(options.url).hash

        var context = options.context = findContainerFor(options.container)

        // We want the browser to maintain two separate internal caches: one
        // for pjax'd partial page loads and one for normal page loads.
        // Without adding this secret parameter, some browsers will often
        // confuse the two.
        if (!options.data) options.data = {}
        if ($.isArray(options.data)) {
            options.data.push({ name: '_pjax', value: context.selector })
        } else {
            options.data._pjax = context.selector
        }

        function fire(type, args, props) {
            if (!props) props = {}
            props.relatedTarget = target
            var event = $.Event(type, props)
            context.trigger(event, args)
            return !event.isDefaultPrevented()
        }

        var timeoutTimer

        options.beforeSend = function (xhr, settings) {
            // No timeout for non-GET requests
            // Its not safe to request the resource again with a fallback method.
            if (settings.type !== 'GET') {
                settings.timeout = 0
            }

            xhr.setRequestHeader('X-PJAX', 'true')
            xhr.setRequestHeader('X-PJAX-Container', context.selector)

            if (!fire('pjax:beforeSend', [xhr, settings]))
                return false

            if (settings.timeout > 0) {
                timeoutTimer = setTimeout(function () {
                    if (fire('pjax:timeout', [xhr, options]))
                        xhr.abort('timeout')
                }, settings.timeout)

                // Clear timeout setting so jquerys internal timeout isn't invoked
                settings.timeout = 0
            }

            var url = parseURL(settings.url)
            if (hash) url.hash = hash
            options.requestUrl = stripInternalParams(url)
        }

        options.complete = function (xhr, textStatus) {
            if (timeoutTimer)
                clearTimeout(timeoutTimer)

            fire('pjax:complete', [xhr, textStatus, options])

            fire('pjax:end', [xhr, options])
        }

        options.error = function (xhr, textStatus, errorThrown) {
            var container = extractContainer("", xhr, options)

            var allowed = fire('pjax:error', [xhr, textStatus, errorThrown, options])
            if (options.type == 'GET' && textStatus !== 'abort' && allowed) {
                locationReplace(container.url)
            }
        }

        options.success = function (data, status, xhr) {
            var previousState = pjax.state;

            // If $.pjax.defaults.version is a function, invoke it first.
            // Otherwise it can be a static string.
            var currentVersion = (typeof $.pjax.defaults.version === 'function') ?
              $.pjax.defaults.version() :
              $.pjax.defaults.version

            var latestVersion = xhr.getResponseHeader('X-PJAX-Version')

            var container = extractContainer(data, xhr, options)

            var url = parseURL(container.url)
            if (hash) {
                url.hash = hash
                container.url = url.href
            }

            // If there is a layout version mismatch, hard load the new url
            if (currentVersion && latestVersion && currentVersion !== latestVersion) {
                locationReplace(container.url)
                return
            }

            // If the new response is missing a body, hard load the page
            if (!container.contents) {
                locationReplace(container.url)
                return
            }

            pjax.state = {
                id: options.id || uniqueId(),
                url: container.url,
                title: container.title,
                container: context.selector,
                fragment: options.fragment,
                timeout: options.timeout
            }

            if (options.push || options.replace) {
                window.history.replaceState(pjax.state, container.title, container.url)
            }

            // Only blur the focus if the focused element is within the container.
            var blurFocus = $.contains(options.container, document.activeElement)

            // Clear out any focused controls before inserting new page contents.
            if (blurFocus) {
                try {
                    document.activeElement.blur()
                } catch (e) { }
            }

            if (container.title) document.title = container.title

            fire('pjax:beforeReplace', [container.contents, options], {
                state: pjax.state,
                previousState: previousState
            })
            context.html(container.contents)

            // FF bug: Won't autofocus fields that are inserted via JS.
            // This behavior is incorrect. So if theres no current focus, autofocus
            // the last field.
            //
            // http://www.w3.org/html/wg/drafts/html/master/forms.html
            var autofocusEl = context.find('input[autofocus], textarea[autofocus]').last()[0]
            if (autofocusEl && document.activeElement !== autofocusEl) {
                autofocusEl.focus();
            }

            executeScriptTags(container.scripts)

            var scrollTo = options.scrollTo

            // Ensure browser scrolls to the element referenced by the URL anchor
            if (hash) {
                var name = decodeURIComponent(hash.slice(1))
                var target = document.getElementById(name) || document.getElementsByName(name)[0]
                if (target) scrollTo = $(target).offset().top
            }

            if (typeof scrollTo == 'number') $(window).scrollTop(scrollTo)

            fire('pjax:success', [data, status, xhr, options])
        }


        // Initialize pjax.state for the initial page load. Assume we're
        // using the container and options of the link we're loading for the
        // back button to the initial page. This ensures good back button
        // behavior.
        if (!pjax.state) {
            pjax.state = {
                id: uniqueId(),
                url: window.location.href,
                title: document.title,
                container: context.selector,
                fragment: options.fragment,
                timeout: options.timeout
            }
            window.history.replaceState(pjax.state, document.title)
        }

        // Cancel the current request if we're already pjaxing
        abortXHR(pjax.xhr)

        pjax.options = options
        var xhr = pjax.xhr = $.ajax(options)

        if (xhr.readyState > 0) {
            if (options.push && !options.replace) {
                // Cache current container element before replacing it
                cachePush(pjax.state.id, cloneContents(context))

                window.history.pushState(null, "", options.requestUrl)
            }

            fire('pjax:start', [xhr, options])
            fire('pjax:send', [xhr, options])
        }

        return pjax.xhr
    }

    // Public: Reload current page with pjax.
    //
    // Returns whatever $.pjax returns.
    function pjaxReload(container, options) {
        var defaults = {
            url: window.location.href,
            push: false,
            replace: true,
            scrollTo: false
        }

        return pjax($.extend(defaults, optionsFor(container, options)))
    }

    // Internal: Hard replace current state with url.
    //
    // Work for around WebKit
    //   https://bugs.webkit.org/show_bug.cgi?id=93506
    //
    // Returns nothing.
    function locationReplace(url) {
        window.history.replaceState(null, "", pjax.state.url)
        window.location.replace(url)
    }


    var initialPop = true
    var initialURL = window.location.href
    var initialState = window.history.state

    // Initialize $.pjax.state if possible
    // Happens when reloading a page and coming forward from a different
    // session history.
    if (initialState && initialState.container) {
        pjax.state = initialState
    }

    // Non-webkit browsers don't fire an initial popstate event
    if ('state' in window.history) {
        initialPop = false
    }

    // popstate handler takes care of the back and forward buttons
    //
    // You probably shouldn't use pjax on pages with other pushState
    // stuff yet.
    function onPjaxPopstate(event) {

        // Hitting back or forward should override any pending PJAX request.
        if (!initialPop) {
            abortXHR(pjax.xhr)
        }

        var previousState = pjax.state
        var state = event.state
        var direction

        if (state && state.container) {
            // When coming forward from a separate history session, will get an
            // initial pop with a state we are already at. Skip reloading the current
            // page.
            if (initialPop && initialURL == state.url) return

            if (previousState) {
                // If popping back to the same state, just skip.
                // Could be clicking back from hashchange rather than a pushState.
                if (previousState.id === state.id) return

                // Since state IDs always increase, we can deduce the navigation direction
                direction = previousState.id < state.id ? 'forward' : 'back'
            }

            var cache = cacheMapping[state.id] || []
            var container = $(cache[0] || state.container), contents = cache[1]

            if (container.length) {
                if (previousState) {
                    // Cache current container before replacement and inform the
                    // cache which direction the history shifted.
                    cachePop(direction, previousState.id, cloneContents(container))
                }

                var popstateEvent = $.Event('pjax:popstate', {
                    state: state,
                    direction: direction
                })
                container.trigger(popstateEvent)

                var options = {
                    id: state.id,
                    url: state.url,
                    container: container,
                    push: false,
                    fragment: state.fragment,
                    timeout: state.timeout,
                    scrollTo: false
                }

                if (contents) {
                    container.trigger('pjax:start', [null, options])

                    pjax.state = state
                    if (state.title) document.title = state.title
                    var beforeReplaceEvent = $.Event('pjax:beforeReplace', {
                        state: state,
                        previousState: previousState
                    })
                    container.trigger(beforeReplaceEvent, [contents, options])
                    container.html(contents)

                    container.trigger('pjax:end', [null, options])
                } else {
                    pjax(options)
                }

                // Force reflow/relayout before the browser tries to restore the
                // scroll position.
                container[0].offsetHeight
            } else {
                locationReplace(location.href)
            }
        }
        initialPop = false
    }

    // Fallback version of main pjax function for browsers that don't
    // support pushState.
    //
    // Returns nothing since it retriggers a hard form submission.
    function fallbackPjax(options) {
        var url = $.isFunction(options.url) ? options.url() : options.url,
            method = options.type ? options.type.toUpperCase() : 'GET'

        var form = $('<form>', {
            method: method === 'GET' ? 'GET' : 'POST',
            action: url,
            style: 'display:none'
        })

        if (method !== 'GET' && method !== 'POST') {
            form.append($('<input>', {
                type: 'hidden',
                name: '_method',
                value: method.toLowerCase()
            }))
        }

        var data = options.data
        if (typeof data === 'string') {
            $.each(data.split('&'), function (index, value) {
                var pair = value.split('=')
                form.append($('<input>', { type: 'hidden', name: pair[0], value: pair[1] }))
            })
        } else if ($.isArray(data)) {
            $.each(data, function (index, value) {
                form.append($('<input>', { type: 'hidden', name: value.name, value: value.value }))
            })
        } else if (typeof data === 'object') {
            var key
            for (key in data)
                form.append($('<input>', { type: 'hidden', name: key, value: data[key] }))
        }

        $(document.body).append(form)
        form.submit()
    }

    // Internal: Abort an XmlHttpRequest if it hasn't been completed,
    // also removing its event handlers.
    function abortXHR(xhr) {
        if (xhr && xhr.readyState < 4) {
            xhr.onreadystatechange = $.noop
            xhr.abort()
        }
    }

    // Internal: Generate unique id for state object.
    //
    // Use a timestamp instead of a counter since ids should still be
    // unique across page loads.
    //
    // Returns Number.
    function uniqueId() {
        return (new Date).getTime()
    }

    function cloneContents(container) {
        var cloned = container.clone()
        // Unmark script tags as already being eval'd so they can get executed again
        // when restored from cache. HAXX: Uses jQuery internal method.
        cloned.find('script').each(function () {
            if (!this.src) jQuery._data(this, 'globalEval', false)
        })
        return [container.selector, cloned.contents()]
    }

    // Internal: Strip internal query params from parsed URL.
    //
    // Returns sanitized url.href String.
    function stripInternalParams(url) {
        url.search = url.search.replace(/([?&])(_pjax|_)=[^&]*/g, '')
        return url.href.replace(/\?($|#)/, '$1')
    }

    // Internal: Parse URL components and returns a Locationish object.
    //
    // url - String URL
    //
    // Returns HTMLAnchorElement that acts like Location.
    function parseURL(url) {
        var a = document.createElement('a')
        a.href = url
        return a
    }

    // Internal: Return the `href` component of given URL object with the hash
    // portion removed.
    //
    // location - Location or HTMLAnchorElement
    //
    // Returns String
    function stripHash(location) {
        return location.href.replace(/#.*/, '')
    }

    // Internal: Build options Object for arguments.
    //
    // For convenience the first parameter can be either the container or
    // the options object.
    //
    // Examples
    //
    //   optionsFor('#container')
    //   // => {container: '#container'}
    //
    //   optionsFor('#container', {push: true})
    //   // => {container: '#container', push: true}
    //
    //   optionsFor({container: '#container', push: true})
    //   // => {container: '#container', push: true}
    //
    // Returns options Object.
    function optionsFor(container, options) {
        // Both container and options
        if (container && options)
            options.container = container

            // First argument is options Object
        else if ($.isPlainObject(container))
            options = container

            // Only container
        else
            options = { container: container }

        // Find and validate container
        if (options.container)
            options.container = findContainerFor(options.container)

        return options
    }

    // Internal: Find container element for a variety of inputs.
    //
    // Because we can't persist elements using the history API, we must be
    // able to find a String selector that will consistently find the Element.
    //
    // container - A selector String, jQuery object, or DOM Element.
    //
    // Returns a jQuery object whose context is `document` and has a selector.
    function findContainerFor(container) {
        container = $(container)

        if (!container.length) {
            throw "no pjax container for " + container.selector
        } else if (container.selector !== '' && container.context === document) {
            return container
        } else if (container.attr('id')) {
            return $('#' + container.attr('id'))
        } else {
            throw "cant get selector for pjax container!"
        }
    }

    // Internal: Filter and find all elements matching the selector.
    //
    // Where $.fn.find only matches descendants, findAll will test all the
    // top level elements in the jQuery object as well.
    //
    // elems    - jQuery object of Elements
    // selector - String selector to match
    //
    // Returns a jQuery object.
    function findAll(elems, selector) {
        return elems.filter(selector).add(elems.find(selector));
    }

    function parseHTML(html) {
        return $.parseHTML(html, document, true)
    }

    // Internal: Extracts container and metadata from response.
    //
    // 1. Extracts X-PJAX-URL header if set
    // 2. Extracts inline <title> tags
    // 3. Builds response Element and extracts fragment if set
    //
    // data    - String response data
    // xhr     - XHR response
    // options - pjax options Object
    //
    // Returns an Object with url, title, and contents keys.
    function extractContainer(data, xhr, options) {
        var obj = {}, fullDocument = /<html/i.test(data)

        // Prefer X-PJAX-URL header if it was set, otherwise fallback to
        // using the original requested url.
        var serverUrl = xhr.getResponseHeader('X-PJAX-URL')
        obj.url = serverUrl ? stripInternalParams(parseURL(serverUrl)) : options.requestUrl

        // Attempt to parse response html into elements
        if (fullDocument) {
            var $head = $(parseHTML(data.match(/<head[^>]*>([\s\S.]*)<\/head>/i)[0]))
            var $body = $(parseHTML(data.match(/<body[^>]*>([\s\S.]*)<\/body>/i)[0]))
        } else {
            var $head = $body = $(parseHTML(data))
        }

        // If response data is empty, return fast
        if ($body.length === 0)
            return obj

        // If there's a <title> tag in the header, use it as
        // the page's title.
        //obj.title = findAll($head, 'title').last().text()
        obj.title = findAll($body, '*[data-title]').last().attr("data-title");

        if (options.fragment) {
            // If they specified a fragment, look for it in the response
            // and pull it out.
            if (options.fragment === 'body') {
                var $fragment = $body
            } else {
                var $fragment = findAll($body, options.fragment).first()
            }

            if ($fragment.length) {
                obj.contents = options.fragment === 'body' ? $fragment : $fragment.contents()

                // If there's no title, look for data-title and title attributes
                // on the fragment
                if (!obj.title)
                    obj.title = $fragment.attr('title') || $fragment.data('title')
            }

        } else if (!fullDocument) {
            obj.contents = $body
        }

        // Clean up any <title> tags
        if (obj.contents) {
            // Remove any parent title elements
            obj.contents = obj.contents.not(function () { return $(this).is('title') })

            // Then scrub any titles from their descendants
            obj.contents.find('title').remove()

            // Gather all script[src] elements
            obj.scripts = findAll(obj.contents, 'script[src]').remove()
            obj.contents = obj.contents.not(obj.scripts)
        }

        // Trim any whitespace off the title
        if (obj.title) obj.title = $.trim(obj.title)

        return obj
    }

    // Load an execute scripts using standard script request.
    //
    // Avoids jQuery's traditional $.getScript which does a XHR request and
    // globalEval.
    //
    // scripts - jQuery object of script Elements
    //
    // Returns nothing.
    function executeScriptTags(scripts) {
        if (!scripts) return

        var existingScripts = $('script[src]')

        scripts.each(function () {
            var src = this.src
            var matchedScripts = existingScripts.filter(function () {
                return this.src === src
            })
            if (matchedScripts.length) return

            var script = document.createElement('script')
            var type = $(this).attr('type')
            if (type) script.type = type
            script.src = $(this).attr('src')
            document.head.appendChild(script)
        })
    }

    // Internal: History DOM caching class.
    var cacheMapping = {}
    var cacheForwardStack = []
    var cacheBackStack = []

    // Push previous state id and container contents into the history
    // cache. Should be called in conjunction with `pushState` to save the
    // previous container contents.
    //
    // id    - State ID Number
    // value - DOM Element to cache
    //
    // Returns nothing.
    function cachePush(id, value) {
        cacheMapping[id] = value
        cacheBackStack.push(id)

        // Remove all entries in forward history stack after pushing a new page.
        trimCacheStack(cacheForwardStack, 0)

        // Trim back history stack to max cache length.
        trimCacheStack(cacheBackStack, pjax.defaults.maxCacheLength)
    }

    // Shifts cache from directional history cache. Should be
    // called on `popstate` with the previous state id and container
    // contents.
    //
    // direction - "forward" or "back" String
    // id        - State ID Number
    // value     - DOM Element to cache
    //
    // Returns nothing.
    function cachePop(direction, id, value) {
        var pushStack, popStack
        cacheMapping[id] = value

        if (direction === 'forward') {
            pushStack = cacheBackStack
            popStack = cacheForwardStack
        } else {
            pushStack = cacheForwardStack
            popStack = cacheBackStack
        }

        pushStack.push(id)
        if (id = popStack.pop())
            delete cacheMapping[id]

        // Trim whichever stack we just pushed to to max cache length.
        trimCacheStack(pushStack, pjax.defaults.maxCacheLength)
    }

    // Trim a cache stack (either cacheBackStack or cacheForwardStack) to be no
    // longer than the specified length, deleting cached DOM elements as necessary.
    //
    // stack  - Array of state IDs
    // length - Maximum length to trim to
    //
    // Returns nothing.
    function trimCacheStack(stack, length) {
        while (stack.length > length)
            delete cacheMapping[stack.shift()]
    }

    // Public: Find version identifier for the initial page load.
    //
    // Returns String version or undefined.
    function findVersion() {
        return $('meta').filter(function () {
            var name = $(this).attr('http-equiv')
            return name && name.toUpperCase() === 'X-PJAX-VERSION'
        }).attr('content')
    }

    // Install pjax functions on $.pjax to enable pushState behavior.
    //
    // Does nothing if already enabled.
    //
    // Examples
    //
    //     $.pjax.enable()
    //
    // Returns nothing.
    function enable() {
        $.fn.pjax = fnPjax
        $.pjax = pjax
        $.pjax.enable = $.noop
        $.pjax.disable = disable
        $.pjax.click = handleClick
        $.pjax.submit = handleSubmit
        $.pjax.reload = pjaxReload
        $.pjax.defaults = {
            timeout: 650,
            push: true,
            replace: false,
            type: 'GET',
            dataType: 'html',
            scrollTo: 0,
            maxCacheLength: 20,
            version: findVersion
        }
        $(window).on('popstate.pjax', onPjaxPopstate)
    }

    // Disable pushState behavior.
    //
    // This is the case when a browser doesn't support pushState. It is
    // sometimes useful to disable pushState for debugging on a modern
    // browser.
    //
    // Examples
    //
    //     $.pjax.disable()
    //
    // Returns nothing.
    function disable() {
        $.fn.pjax = function () { return this }
        $.pjax = fallbackPjax
        $.pjax.enable = enable
        $.pjax.disable = $.noop
        $.pjax.click = $.noop
        $.pjax.submit = $.noop
        $.pjax.reload = function () { window.location.reload() }

        $(window).off('popstate.pjax', onPjaxPopstate)
    }


    // Add the state property to jQuery's event object so we can use it in
    // $(window).bind('popstate')
    if ($.inArray('state', $.event.props) < 0)
        $.event.props.push('state')

    // Is pjax supported by this browser?
    $.support.pjax =
      window.history && window.history.pushState && window.history.replaceState &&
      // pushState isn't reliable on iOS until 5.
      !navigator.userAgent.match(/((iPod|iPhone|iPad).+\bOS\s+[1-4]\D|WebApps\/.+CFNetwork)/)

    $.support.pjax ? enable() : disable()

})(jQuery);
/* NUGET: BEGIN LICENSE TEXT
 *
 * Microsoft grants you the right to use these script files for the sole
 * purpose of either: (i) interacting through your browser with the Microsoft
 * website or online service, subject to the applicable licensing or use
 * terms; or (ii) using the files as included with a Microsoft product subject
 * to that product's license terms. Microsoft reserves all other rights to the
 * files not expressly granted by Microsoft, whether by implication, estoppel
 * or otherwise. Insofar as a script file is dual licensed under GPL,
 * Microsoft neither took the code under GPL nor distributes it thereunder but
 * under the terms set out in this paragraph. All notices and licenses
 * below are for informational purposes only.
 *
 * NUGET: END LICENSE TEXT */

/**
* bootstrap.js v3.0.0 by @fat and @mdo
* Copyright 2013 Twitter Inc.
* http://www.apache.org/licenses/LICENSE-2.0
*/
if (!jQuery) throw new Error("Bootstrap requires jQuery"); +function (a) { "use strict"; function b() { var a = document.createElement("bootstrap"), b = { WebkitTransition: "webkitTransitionEnd", MozTransition: "transitionend", OTransition: "oTransitionEnd otransitionend", transition: "transitionend" }; for (var c in b) if (void 0 !== a.style[c]) return { end: b[c] } } a.fn.emulateTransitionEnd = function (b) { var c = !1, d = this; a(this).one(a.support.transition.end, function () { c = !0 }); var e = function () { c || a(d).trigger(a.support.transition.end) }; return setTimeout(e, b), this }, a(function () { a.support.transition = b() }) }(window.jQuery), +function (a) { "use strict"; var b = '[data-dismiss="alert"]', c = function (c) { a(c).on("click", b, this.close) }; c.prototype.close = function (b) { function c() { f.trigger("closed.bs.alert").remove() } var d = a(this), e = d.attr("data-target"); e || (e = d.attr("href"), e = e && e.replace(/.*(?=#[^\s]*$)/, "")); var f = a(e); b && b.preventDefault(), f.length || (f = d.hasClass("alert") ? d : d.parent()), f.trigger(b = a.Event("close.bs.alert")), b.isDefaultPrevented() || (f.removeClass("in"), a.support.transition && f.hasClass("fade") ? f.one(a.support.transition.end, c).emulateTransitionEnd(150) : c()) }; var d = a.fn.alert; a.fn.alert = function (b) { return this.each(function () { var d = a(this), e = d.data("bs.alert"); e || d.data("bs.alert", e = new c(this)), "string" == typeof b && e[b].call(d) }) }, a.fn.alert.Constructor = c, a.fn.alert.noConflict = function () { return a.fn.alert = d, this }, a(document).on("click.bs.alert.data-api", b, c.prototype.close) }(window.jQuery), +function (a) { "use strict"; var b = function (c, d) { this.$element = a(c), this.options = a.extend({}, b.DEFAULTS, d) }; b.DEFAULTS = { loadingText: "loading..." }, b.prototype.setState = function (a) { var b = "disabled", c = this.$element, d = c.is("input") ? "val" : "html", e = c.data(); a += "Text", e.resetText || c.data("resetText", c[d]()), c[d](e[a] || this.options[a]), setTimeout(function () { "loadingText" == a ? c.addClass(b).attr(b, b) : c.removeClass(b).removeAttr(b) }, 0) }, b.prototype.toggle = function () { var a = this.$element.closest('[data-toggle="buttons"]'); if (a.length) { var b = this.$element.find("input").prop("checked", !this.$element.hasClass("active")).trigger("change"); "radio" === b.prop("type") && a.find(".active").removeClass("active") } this.$element.toggleClass("active") }; var c = a.fn.button; a.fn.button = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.button"), f = "object" == typeof c && c; e || d.data("bs.button", e = new b(this, f)), "toggle" == c ? e.toggle() : c && e.setState(c) }) }, a.fn.button.Constructor = b, a.fn.button.noConflict = function () { return a.fn.button = c, this }, a(document).on("click.bs.button.data-api", "[data-toggle^=button]", function (b) { var c = a(b.target); c.hasClass("btn") || (c = c.closest(".btn")), c.button("toggle"), b.preventDefault() }) }(window.jQuery), +function (a) { "use strict"; var b = function (b, c) { this.$element = a(b), this.$indicators = this.$element.find(".carousel-indicators"), this.options = c, this.paused = this.sliding = this.interval = this.$active = this.$items = null, "hover" == this.options.pause && this.$element.on("mouseenter", a.proxy(this.pause, this)).on("mouseleave", a.proxy(this.cycle, this)) }; b.DEFAULTS = { interval: 5e3, pause: "hover", wrap: !0 }, b.prototype.cycle = function (b) { return b || (this.paused = !1), this.interval && clearInterval(this.interval), this.options.interval && !this.paused && (this.interval = setInterval(a.proxy(this.next, this), this.options.interval)), this }, b.prototype.getActiveIndex = function () { return this.$active = this.$element.find(".item.active"), this.$items = this.$active.parent().children(), this.$items.index(this.$active) }, b.prototype.to = function (b) { var c = this, d = this.getActiveIndex(); return b > this.$items.length - 1 || 0 > b ? void 0 : this.sliding ? this.$element.one("slid", function () { c.to(b) }) : d == b ? this.pause().cycle() : this.slide(b > d ? "next" : "prev", a(this.$items[b])) }, b.prototype.pause = function (b) { return b || (this.paused = !0), this.$element.find(".next, .prev").length && a.support.transition.end && (this.$element.trigger(a.support.transition.end), this.cycle(!0)), this.interval = clearInterval(this.interval), this }, b.prototype.next = function () { return this.sliding ? void 0 : this.slide("next") }, b.prototype.prev = function () { return this.sliding ? void 0 : this.slide("prev") }, b.prototype.slide = function (b, c) { var d = this.$element.find(".item.active"), e = c || d[b](), f = this.interval, g = "next" == b ? "left" : "right", h = "next" == b ? "first" : "last", i = this; if (!e.length) { if (!this.options.wrap) return; e = this.$element.find(".item")[h]() } this.sliding = !0, f && this.pause(); var j = a.Event("slide.bs.carousel", { relatedTarget: e[0], direction: g }); if (!e.hasClass("active")) { if (this.$indicators.length && (this.$indicators.find(".active").removeClass("active"), this.$element.one("slid", function () { var b = a(i.$indicators.children()[i.getActiveIndex()]); b && b.addClass("active") })), a.support.transition && this.$element.hasClass("slide")) { if (this.$element.trigger(j), j.isDefaultPrevented()) return; e.addClass(b), e[0].offsetWidth, d.addClass(g), e.addClass(g), d.one(a.support.transition.end, function () { e.removeClass([b, g].join(" ")).addClass("active"), d.removeClass(["active", g].join(" ")), i.sliding = !1, setTimeout(function () { i.$element.trigger("slid") }, 0) }).emulateTransitionEnd(600) } else { if (this.$element.trigger(j), j.isDefaultPrevented()) return; d.removeClass("active"), e.addClass("active"), this.sliding = !1, this.$element.trigger("slid") } return f && this.cycle(), this } }; var c = a.fn.carousel; a.fn.carousel = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.carousel"), f = a.extend({}, b.DEFAULTS, d.data(), "object" == typeof c && c), g = "string" == typeof c ? c : f.slide; e || d.data("bs.carousel", e = new b(this, f)), "number" == typeof c ? e.to(c) : g ? e[g]() : f.interval && e.pause().cycle() }) }, a.fn.carousel.Constructor = b, a.fn.carousel.noConflict = function () { return a.fn.carousel = c, this }, a(document).on("click.bs.carousel.data-api", "[data-slide], [data-slide-to]", function (b) { var c, d = a(this), e = a(d.attr("data-target") || (c = d.attr("href")) && c.replace(/.*(?=#[^\s]+$)/, "")), f = a.extend({}, e.data(), d.data()), g = d.attr("data-slide-to"); g && (f.interval = !1), e.carousel(f), (g = d.attr("data-slide-to")) && e.data("bs.carousel").to(g), b.preventDefault() }), a(window).on("load", function () { a('[data-ride="carousel"]').each(function () { var b = a(this); b.carousel(b.data()) }) }) }(window.jQuery), +function (a) { "use strict"; var b = function (c, d) { this.$element = a(c), this.options = a.extend({}, b.DEFAULTS, d), this.transitioning = null, this.options.parent && (this.$parent = a(this.options.parent)), this.options.toggle && this.toggle() }; b.DEFAULTS = { toggle: !0 }, b.prototype.dimension = function () { var a = this.$element.hasClass("width"); return a ? "width" : "height" }, b.prototype.show = function () { if (!this.transitioning && !this.$element.hasClass("in")) { var b = a.Event("show.bs.collapse"); if (this.$element.trigger(b), !b.isDefaultPrevented()) { var c = this.$parent && this.$parent.find("> .panel > .in"); if (c && c.length) { var d = c.data("bs.collapse"); if (d && d.transitioning) return; c.collapse("hide"), d || c.data("bs.collapse", null) } var e = this.dimension(); this.$element.removeClass("collapse").addClass("collapsing")[e](0), this.transitioning = 1; var f = function () { this.$element.removeClass("collapsing").addClass("in")[e]("auto"), this.transitioning = 0, this.$element.trigger("shown.bs.collapse") }; if (!a.support.transition) return f.call(this); var g = a.camelCase(["scroll", e].join("-")); this.$element.one(a.support.transition.end, a.proxy(f, this)).emulateTransitionEnd(350)[e](this.$element[0][g]) } } }, b.prototype.hide = function () { if (!this.transitioning && this.$element.hasClass("in")) { var b = a.Event("hide.bs.collapse"); if (this.$element.trigger(b), !b.isDefaultPrevented()) { var c = this.dimension(); this.$element[c](this.$element[c]())[0].offsetHeight, this.$element.addClass("collapsing").removeClass("collapse").removeClass("in"), this.transitioning = 1; var d = function () { this.transitioning = 0, this.$element.trigger("hidden.bs.collapse").removeClass("collapsing").addClass("collapse") }; return a.support.transition ? (this.$element[c](0).one(a.support.transition.end, a.proxy(d, this)).emulateTransitionEnd(350), void 0) : d.call(this) } } }, b.prototype.toggle = function () { this[this.$element.hasClass("in") ? "hide" : "show"]() }; var c = a.fn.collapse; a.fn.collapse = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.collapse"), f = a.extend({}, b.DEFAULTS, d.data(), "object" == typeof c && c); e || d.data("bs.collapse", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.collapse.Constructor = b, a.fn.collapse.noConflict = function () { return a.fn.collapse = c, this }, a(document).on("click.bs.collapse.data-api", "[data-toggle=collapse]", function (b) { var c, d = a(this), e = d.attr("data-target") || b.preventDefault() || (c = d.attr("href")) && c.replace(/.*(?=#[^\s]+$)/, ""), f = a(e), g = f.data("bs.collapse"), h = g ? "toggle" : d.data(), i = d.attr("data-parent"), j = i && a(i); g && g.transitioning || (j && j.find('[data-toggle=collapse][data-parent="' + i + '"]').not(d).addClass("collapsed"), d[f.hasClass("in") ? "addClass" : "removeClass"]("collapsed")), f.collapse(h) }) }(window.jQuery), +function (a) { "use strict"; function b() { a(d).remove(), a(e).each(function (b) { var d = c(a(this)); d.hasClass("open") && (d.trigger(b = a.Event("hide.bs.dropdown")), b.isDefaultPrevented() || d.removeClass("open").trigger("hidden.bs.dropdown")) }) } function c(b) { var c = b.attr("data-target"); c || (c = b.attr("href"), c = c && /#/.test(c) && c.replace(/.*(?=#[^\s]*$)/, "")); var d = c && a(c); return d && d.length ? d : b.parent() } var d = ".dropdown-backdrop", e = "[data-toggle=dropdown]", f = function (b) { a(b).on("click.bs.dropdown", this.toggle) }; f.prototype.toggle = function (d) { var e = a(this); if (!e.is(".disabled, :disabled")) { var f = c(e), g = f.hasClass("open"); if (b(), !g) { if ("ontouchstart" in document.documentElement && !f.closest(".navbar-nav").length && a('<div class="dropdown-backdrop"/>').insertAfter(a(this)).on("click", b), f.trigger(d = a.Event("show.bs.dropdown")), d.isDefaultPrevented()) return; f.toggleClass("open").trigger("shown.bs.dropdown"), e.focus() } return !1 } }, f.prototype.keydown = function (b) { if (/(38|40|27)/.test(b.keyCode)) { var d = a(this); if (b.preventDefault(), b.stopPropagation(), !d.is(".disabled, :disabled")) { var f = c(d), g = f.hasClass("open"); if (!g || g && 27 == b.keyCode) return 27 == b.which && f.find(e).focus(), d.click(); var h = a("[role=menu] li:not(.divider):visible a", f); if (h.length) { var i = h.index(h.filter(":focus")); 38 == b.keyCode && i > 0 && i--, 40 == b.keyCode && i < h.length - 1 && i++, ~i || (i = 0), h.eq(i).focus() } } } }; var g = a.fn.dropdown; a.fn.dropdown = function (b) { return this.each(function () { var c = a(this), d = c.data("dropdown"); d || c.data("dropdown", d = new f(this)), "string" == typeof b && d[b].call(c) }) }, a.fn.dropdown.Constructor = f, a.fn.dropdown.noConflict = function () { return a.fn.dropdown = g, this }, a(document).on("click.bs.dropdown.data-api", b).on("click.bs.dropdown.data-api", ".dropdown form", function (a) { a.stopPropagation() }).on("click.bs.dropdown.data-api", e, f.prototype.toggle).on("keydown.bs.dropdown.data-api", e + ", [role=menu]", f.prototype.keydown) }(window.jQuery), +function (a) { "use strict"; var b = function (b, c) { this.options = c, this.$element = a(b), this.$backdrop = this.isShown = null, this.options.remote && this.$element.load(this.options.remote) }; b.DEFAULTS = { backdrop: !0, keyboard: !0, show: !0 }, b.prototype.toggle = function (a) { return this[this.isShown ? "hide" : "show"](a) }, b.prototype.show = function (b) { var c = this, d = a.Event("show.bs.modal", { relatedTarget: b }); this.$element.trigger(d), this.isShown || d.isDefaultPrevented() || (this.isShown = !0, this.escape(), this.$element.on("click.dismiss.modal", '[data-dismiss="modal"]', a.proxy(this.hide, this)), this.backdrop(function () { var d = a.support.transition && c.$element.hasClass("fade"); c.$element.parent().length || c.$element.appendTo(document.body), c.$element.show(), d && c.$element[0].offsetWidth, c.$element.addClass("in").attr("aria-hidden", !1), c.enforceFocus(); var e = a.Event("shown.bs.modal", { relatedTarget: b }); d ? c.$element.find(".modal-dialog").one(a.support.transition.end, function () { c.$element.focus().trigger(e) }).emulateTransitionEnd(300) : c.$element.focus().trigger(e) })) }, b.prototype.hide = function (b) { b && b.preventDefault(), b = a.Event("hide.bs.modal"), this.$element.trigger(b), this.isShown && !b.isDefaultPrevented() && (this.isShown = !1, this.escape(), a(document).off("focusin.bs.modal"), this.$element.removeClass("in").attr("aria-hidden", !0).off("click.dismiss.modal"), a.support.transition && this.$element.hasClass("fade") ? this.$element.one(a.support.transition.end, a.proxy(this.hideModal, this)).emulateTransitionEnd(300) : this.hideModal()) }, b.prototype.enforceFocus = function () { a(document).off("focusin.bs.modal").on("focusin.bs.modal", a.proxy(function (a) { this.$element[0] === a.target || this.$element.has(a.target).length || this.$element.focus() }, this)) }, b.prototype.escape = function () { this.isShown && this.options.keyboard ? this.$element.on("keyup.dismiss.bs.modal", a.proxy(function (a) { 27 == a.which && this.hide() }, this)) : this.isShown || this.$element.off("keyup.dismiss.bs.modal") }, b.prototype.hideModal = function () { var a = this; this.$element.hide(), this.backdrop(function () { a.removeBackdrop(), a.$element.trigger("hidden.bs.modal") }) }, b.prototype.removeBackdrop = function () { this.$backdrop && this.$backdrop.remove(), this.$backdrop = null }, b.prototype.backdrop = function (b) { var c = this.$element.hasClass("fade") ? "fade" : ""; if (this.isShown && this.options.backdrop) { var d = a.support.transition && c; if (this.$backdrop = a('<div class="modal-backdrop ' + c + '" />').appendTo(document.body), this.$element.on("click.dismiss.modal", a.proxy(function (a) { a.target === a.currentTarget && ("static" == this.options.backdrop ? this.$element[0].focus.call(this.$element[0]) : this.hide.call(this)) }, this)), d && this.$backdrop[0].offsetWidth, this.$backdrop.addClass("in"), !b) return; d ? this.$backdrop.one(a.support.transition.end, b).emulateTransitionEnd(150) : b() } else !this.isShown && this.$backdrop ? (this.$backdrop.removeClass("in"), a.support.transition && this.$element.hasClass("fade") ? this.$backdrop.one(a.support.transition.end, b).emulateTransitionEnd(150) : b()) : b && b() }; var c = a.fn.modal; a.fn.modal = function (c, d) { return this.each(function () { var e = a(this), f = e.data("bs.modal"), g = a.extend({}, b.DEFAULTS, e.data(), "object" == typeof c && c); f || e.data("bs.modal", f = new b(this, g)), "string" == typeof c ? f[c](d) : g.show && f.show(d) }) }, a.fn.modal.Constructor = b, a.fn.modal.noConflict = function () { return a.fn.modal = c, this }, a(document).on("click.bs.modal.data-api", '[data-toggle="modal"]', function (b) { var c = a(this), d = c.attr("href"), e = a(c.attr("data-target") || d && d.replace(/.*(?=#[^\s]+$)/, "")), f = e.data("modal") ? "toggle" : a.extend({ remote: !/#/.test(d) && d }, e.data(), c.data()); b.preventDefault(), e.modal(f, this).one("hide", function () { c.is(":visible") && c.focus() }) }), a(document).on("show.bs.modal", ".modal", function () { a(document.body).addClass("modal-open") }).on("hidden.bs.modal", ".modal", function () { a(document.body).removeClass("modal-open") }) }(window.jQuery), +function (a) { "use strict"; var b = function (a, b) { this.type = this.options = this.enabled = this.timeout = this.hoverState = this.$element = null, this.init("tooltip", a, b) }; b.DEFAULTS = { animation: !0, placement: "top", selector: !1, template: '<div class="tooltip"><div class="tooltip-arrow"></div><div class="tooltip-inner"></div></div>', trigger: "hover focus", title: "", delay: 0, html: !1, container: !1 }, b.prototype.init = function (b, c, d) { this.enabled = !0, this.type = b, this.$element = a(c), this.options = this.getOptions(d); for (var e = this.options.trigger.split(" "), f = e.length; f--;) { var g = e[f]; if ("click" == g) this.$element.on("click." + this.type, this.options.selector, a.proxy(this.toggle, this)); else if ("manual" != g) { var h = "hover" == g ? "mouseenter" : "focus", i = "hover" == g ? "mouseleave" : "blur"; this.$element.on(h + "." + this.type, this.options.selector, a.proxy(this.enter, this)), this.$element.on(i + "." + this.type, this.options.selector, a.proxy(this.leave, this)) } } this.options.selector ? this._options = a.extend({}, this.options, { trigger: "manual", selector: "" }) : this.fixTitle() }, b.prototype.getDefaults = function () { return b.DEFAULTS }, b.prototype.getOptions = function (b) { return b = a.extend({}, this.getDefaults(), this.$element.data(), b), b.delay && "number" == typeof b.delay && (b.delay = { show: b.delay, hide: b.delay }), b }, b.prototype.getDelegateOptions = function () { var b = {}, c = this.getDefaults(); return this._options && a.each(this._options, function (a, d) { c[a] != d && (b[a] = d) }), b }, b.prototype.enter = function (b) { var c = b instanceof this.constructor ? b : a(b.currentTarget)[this.type](this.getDelegateOptions()).data("bs." + this.type); return clearTimeout(c.timeout), c.hoverState = "in", c.options.delay && c.options.delay.show ? (c.timeout = setTimeout(function () { "in" == c.hoverState && c.show() }, c.options.delay.show), void 0) : c.show() }, b.prototype.leave = function (b) { var c = b instanceof this.constructor ? b : a(b.currentTarget)[this.type](this.getDelegateOptions()).data("bs." + this.type); return clearTimeout(c.timeout), c.hoverState = "out", c.options.delay && c.options.delay.hide ? (c.timeout = setTimeout(function () { "out" == c.hoverState && c.hide() }, c.options.delay.hide), void 0) : c.hide() }, b.prototype.show = function () { var b = a.Event("show.bs." + this.type); if (this.hasContent() && this.enabled) { if (this.$element.trigger(b), b.isDefaultPrevented()) return; var c = this.tip(); this.setContent(), this.options.animation && c.addClass("fade"); var d = "function" == typeof this.options.placement ? this.options.placement.call(this, c[0], this.$element[0]) : this.options.placement, e = /\s?auto?\s?/i, f = e.test(d); f && (d = d.replace(e, "") || "top"), c.detach().css({ top: 0, left: 0, display: "block" }).addClass(d), this.options.container ? c.appendTo(this.options.container) : c.insertAfter(this.$element); var g = this.getPosition(), h = c[0].offsetWidth, i = c[0].offsetHeight; if (f) { var j = this.$element.parent(), k = d, l = document.documentElement.scrollTop || document.body.scrollTop, m = "body" == this.options.container ? window.innerWidth : j.outerWidth(), n = "body" == this.options.container ? window.innerHeight : j.outerHeight(), o = "body" == this.options.container ? 0 : j.offset().left; d = "bottom" == d && g.top + g.height + i - l > n ? "top" : "top" == d && g.top - l - i < 0 ? "bottom" : "right" == d && g.right + h > m ? "left" : "left" == d && g.left - h < o ? "right" : d, c.removeClass(k).addClass(d) } var p = this.getCalculatedOffset(d, g, h, i); this.applyPlacement(p, d), this.$element.trigger("shown.bs." + this.type) } }, b.prototype.applyPlacement = function (a, b) { var c, d = this.tip(), e = d[0].offsetWidth, f = d[0].offsetHeight, g = parseInt(d.css("margin-top"), 10), h = parseInt(d.css("margin-left"), 10); isNaN(g) && (g = 0), isNaN(h) && (h = 0), a.top = a.top + g, a.left = a.left + h, d.offset(a).addClass("in"); var i = d[0].offsetWidth, j = d[0].offsetHeight; if ("top" == b && j != f && (c = !0, a.top = a.top + f - j), /bottom|top/.test(b)) { var k = 0; a.left < 0 && (k = -2 * a.left, a.left = 0, d.offset(a), i = d[0].offsetWidth, j = d[0].offsetHeight), this.replaceArrow(k - e + i, i, "left") } else this.replaceArrow(j - f, j, "top"); c && d.offset(a) }, b.prototype.replaceArrow = function (a, b, c) { this.arrow().css(c, a ? 50 * (1 - a / b) + "%" : "") }, b.prototype.setContent = function () { var a = this.tip(), b = this.getTitle(); a.find(".tooltip-inner")[this.options.html ? "html" : "text"](b), a.removeClass("fade in top bottom left right") }, b.prototype.hide = function () { function b() { "in" != c.hoverState && d.detach() } var c = this, d = this.tip(), e = a.Event("hide.bs." + this.type); return this.$element.trigger(e), e.isDefaultPrevented() ? void 0 : (d.removeClass("in"), a.support.transition && this.$tip.hasClass("fade") ? d.one(a.support.transition.end, b).emulateTransitionEnd(150) : b(), this.$element.trigger("hidden.bs." + this.type), this) }, b.prototype.fixTitle = function () { var a = this.$element; (a.attr("title") || "string" != typeof a.attr("data-original-title")) && a.attr("data-original-title", a.attr("title") || "").attr("title", "") }, b.prototype.hasContent = function () { return this.getTitle() }, b.prototype.getPosition = function () { var b = this.$element[0]; return a.extend({}, "function" == typeof b.getBoundingClientRect ? b.getBoundingClientRect() : { width: b.offsetWidth, height: b.offsetHeight }, this.$element.offset()) }, b.prototype.getCalculatedOffset = function (a, b, c, d) { return "bottom" == a ? { top: b.top + b.height, left: b.left + b.width / 2 - c / 2 } : "top" == a ? { top: b.top - d, left: b.left + b.width / 2 - c / 2 } : "left" == a ? { top: b.top + b.height / 2 - d / 2, left: b.left - c } : { top: b.top + b.height / 2 - d / 2, left: b.left + b.width } }, b.prototype.getTitle = function () { var a, b = this.$element, c = this.options; return a = b.attr("data-original-title") || ("function" == typeof c.title ? c.title.call(b[0]) : c.title) }, b.prototype.tip = function () { return this.$tip = this.$tip || a(this.options.template) }, b.prototype.arrow = function () { return this.$arrow = this.$arrow || this.tip().find(".tooltip-arrow") }, b.prototype.validate = function () { this.$element[0].parentNode || (this.hide(), this.$element = null, this.options = null) }, b.prototype.enable = function () { this.enabled = !0 }, b.prototype.disable = function () { this.enabled = !1 }, b.prototype.toggleEnabled = function () { this.enabled = !this.enabled }, b.prototype.toggle = function (b) { var c = b ? a(b.currentTarget)[this.type](this.getDelegateOptions()).data("bs." + this.type) : this; c.tip().hasClass("in") ? c.leave(c) : c.enter(c) }, b.prototype.destroy = function () { this.hide().$element.off("." + this.type).removeData("bs." + this.type) }; var c = a.fn.tooltip; a.fn.tooltip = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.tooltip"), f = "object" == typeof c && c; e || d.data("bs.tooltip", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.tooltip.Constructor = b, a.fn.tooltip.noConflict = function () { return a.fn.tooltip = c, this } }(window.jQuery), +function (a) { "use strict"; var b = function (a, b) { this.init("popover", a, b) }; if (!a.fn.tooltip) throw new Error("Popover requires tooltip.js"); b.DEFAULTS = a.extend({}, a.fn.tooltip.Constructor.DEFAULTS, { placement: "right", trigger: "click", content: "", template: '<div class="popover"><div class="arrow"></div><h3 class="popover-title"></h3><div class="popover-content"></div></div>' }), b.prototype = a.extend({}, a.fn.tooltip.Constructor.prototype), b.prototype.constructor = b, b.prototype.getDefaults = function () { return b.DEFAULTS }, b.prototype.setContent = function () { var a = this.tip(), b = this.getTitle(), c = this.getContent(); a.find(".popover-title")[this.options.html ? "html" : "text"](b), a.find(".popover-content")[this.options.html ? "html" : "text"](c), a.removeClass("fade top bottom left right in"), a.find(".popover-title").html() || a.find(".popover-title").hide() }, b.prototype.hasContent = function () { return this.getTitle() || this.getContent() }, b.prototype.getContent = function () { var a = this.$element, b = this.options; return a.attr("data-content") || ("function" == typeof b.content ? b.content.call(a[0]) : b.content) }, b.prototype.arrow = function () { return this.$arrow = this.$arrow || this.tip().find(".arrow") }, b.prototype.tip = function () { return this.$tip || (this.$tip = a(this.options.template)), this.$tip }; var c = a.fn.popover; a.fn.popover = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.popover"), f = "object" == typeof c && c; e || d.data("bs.popover", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.popover.Constructor = b, a.fn.popover.noConflict = function () { return a.fn.popover = c, this } }(window.jQuery), +function (a) { "use strict"; function b(c, d) { var e, f = a.proxy(this.process, this); this.$element = a(c).is("body") ? a(window) : a(c), this.$body = a("body"), this.$scrollElement = this.$element.on("scroll.bs.scroll-spy.data-api", f), this.options = a.extend({}, b.DEFAULTS, d), this.selector = (this.options.target || (e = a(c).attr("href")) && e.replace(/.*(?=#[^\s]+$)/, "") || "") + " .nav li > a", this.offsets = a([]), this.targets = a([]), this.activeTarget = null, this.refresh(), this.process() } b.DEFAULTS = { offset: 10 }, b.prototype.refresh = function () { var b = this.$element[0] == window ? "offset" : "position"; this.offsets = a([]), this.targets = a([]); var c = this; this.$body.find(this.selector).map(function () { var d = a(this), e = d.data("target") || d.attr("href"), f = /^#\w/.test(e) && a(e); return f && f.length && [[f[b]().top + (!a.isWindow(c.$scrollElement.get(0)) && c.$scrollElement.scrollTop()), e]] || null }).sort(function (a, b) { return a[0] - b[0] }).each(function () { c.offsets.push(this[0]), c.targets.push(this[1]) }) }, b.prototype.process = function () { var a, b = this.$scrollElement.scrollTop() + this.options.offset, c = this.$scrollElement[0].scrollHeight || this.$body[0].scrollHeight, d = c - this.$scrollElement.height(), e = this.offsets, f = this.targets, g = this.activeTarget; if (b >= d) return g != (a = f.last()[0]) && this.activate(a); for (a = e.length; a--;) g != f[a] && b >= e[a] && (!e[a + 1] || b <= e[a + 1]) && this.activate(f[a]) }, b.prototype.activate = function (b) { this.activeTarget = b, a(this.selector).parents(".active").removeClass("active"); var c = this.selector + '[data-target="' + b + '"],' + this.selector + '[href="' + b + '"]', d = a(c).parents("li").addClass("active"); d.parent(".dropdown-menu").length && (d = d.closest("li.dropdown").addClass("active")), d.trigger("activate") }; var c = a.fn.scrollspy; a.fn.scrollspy = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.scrollspy"), f = "object" == typeof c && c; e || d.data("bs.scrollspy", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.scrollspy.Constructor = b, a.fn.scrollspy.noConflict = function () { return a.fn.scrollspy = c, this }, a(window).on("load", function () { a('[data-spy="scroll"]').each(function () { var b = a(this); b.scrollspy(b.data()) }) }) }(window.jQuery), +function (a) { "use strict"; var b = function (b) { this.element = a(b) }; b.prototype.show = function () { var b = this.element, c = b.closest("ul:not(.dropdown-menu)"), d = b.attr("data-target"); if (d || (d = b.attr("href"), d = d && d.replace(/.*(?=#[^\s]*$)/, "")), !b.parent("li").hasClass("active")) { var e = c.find(".active:last a")[0], f = a.Event("show.bs.tab", { relatedTarget: e }); if (b.trigger(f), !f.isDefaultPrevented()) { var g = a(d); this.activate(b.parent("li"), c), this.activate(g, g.parent(), function () { b.trigger({ type: "shown.bs.tab", relatedTarget: e }) }) } } }, b.prototype.activate = function (b, c, d) { function e() { f.removeClass("active").find("> .dropdown-menu > .active").removeClass("active"), b.addClass("active"), g ? (b[0].offsetWidth, b.addClass("in")) : b.removeClass("fade"), b.parent(".dropdown-menu") && b.closest("li.dropdown").addClass("active"), d && d() } var f = c.find("> .active"), g = d && a.support.transition && f.hasClass("fade"); g ? f.one(a.support.transition.end, e).emulateTransitionEnd(150) : e(), f.removeClass("in") }; var c = a.fn.tab; a.fn.tab = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.tab"); e || d.data("bs.tab", e = new b(this)), "string" == typeof c && e[c]() }) }, a.fn.tab.Constructor = b, a.fn.tab.noConflict = function () { return a.fn.tab = c, this }, a(document).on("click.bs.tab.data-api", '[data-toggle="tab"], [data-toggle="pill"]', function (b) { b.preventDefault(), a(this).tab("show") }) }(window.jQuery), +function (a) { "use strict"; var b = function (c, d) { this.options = a.extend({}, b.DEFAULTS, d), this.$window = a(window).on("scroll.bs.affix.data-api", a.proxy(this.checkPosition, this)).on("click.bs.affix.data-api", a.proxy(this.checkPositionWithEventLoop, this)), this.$element = a(c), this.affixed = this.unpin = null, this.checkPosition() }; b.RESET = "affix affix-top affix-bottom", b.DEFAULTS = { offset: 0 }, b.prototype.checkPositionWithEventLoop = function () { setTimeout(a.proxy(this.checkPosition, this), 1) }, b.prototype.checkPosition = function () { if (this.$element.is(":visible")) { var c = a(document).height(), d = this.$window.scrollTop(), e = this.$element.offset(), f = this.options.offset, g = f.top, h = f.bottom; "object" != typeof f && (h = g = f), "function" == typeof g && (g = f.top()), "function" == typeof h && (h = f.bottom()); var i = null != this.unpin && d + this.unpin <= e.top ? !1 : null != h && e.top + this.$element.height() >= c - h ? "bottom" : null != g && g >= d ? "top" : !1; this.affixed !== i && (this.unpin && this.$element.css("top", ""), this.affixed = i, this.unpin = "bottom" == i ? e.top - d : null, this.$element.removeClass(b.RESET).addClass("affix" + (i ? "-" + i : "")), "bottom" == i && this.$element.offset({ top: document.body.offsetHeight - h - this.$element.height() })) } }; var c = a.fn.affix; a.fn.affix = function (c) { return this.each(function () { var d = a(this), e = d.data("bs.affix"), f = "object" == typeof c && c; e || d.data("bs.affix", e = new b(this, f)), "string" == typeof c && e[c]() }) }, a.fn.affix.Constructor = b, a.fn.affix.noConflict = function () { return a.fn.affix = c, this }, a(window).on("load", function () { a('[data-spy="affix"]').each(function () { var b = a(this), c = b.data(); c.offset = c.offset || {}, c.offsetBottom && (c.offset.bottom = c.offsetBottom), c.offsetTop && (c.offset.top = c.offsetTop), b.affix(c) }) }) }(window.jQuery);
//! moment.js
//! version : 2.10.6
//! authors : Tim Wood, Iskren Chernev, Moment.js contributors
//! license : MIT
//! momentjs.com
!function (a, b) { "object" == typeof exports && "undefined" != typeof module ? module.exports = b() : "function" == typeof define && define.amd ? define(b) : a.moment = b() }(this, function () {
    "use strict"; function a() { return Hc.apply(null, arguments) } function b(a) { Hc = a } function c(a) { return "[object Array]" === Object.prototype.toString.call(a) } function d(a) { return a instanceof Date || "[object Date]" === Object.prototype.toString.call(a) } function e(a, b) { var c, d = []; for (c = 0; c < a.length; ++c) d.push(b(a[c], c)); return d } function f(a, b) { return Object.prototype.hasOwnProperty.call(a, b) } function g(a, b) { for (var c in b) f(b, c) && (a[c] = b[c]); return f(b, "toString") && (a.toString = b.toString), f(b, "valueOf") && (a.valueOf = b.valueOf), a } function h(a, b, c, d) { return Ca(a, b, c, d, !0).utc() } function i() { return { empty: !1, unusedTokens: [], unusedInput: [], overflow: -2, charsLeftOver: 0, nullInput: !1, invalidMonth: null, invalidFormat: !1, userInvalidated: !1, iso: !1 } } function j(a) { return null == a._pf && (a._pf = i()), a._pf } function k(a) { if (null == a._isValid) { var b = j(a); a._isValid = !(isNaN(a._d.getTime()) || !(b.overflow < 0) || b.empty || b.invalidMonth || b.invalidWeekday || b.nullInput || b.invalidFormat || b.userInvalidated), a._strict && (a._isValid = a._isValid && 0 === b.charsLeftOver && 0 === b.unusedTokens.length && void 0 === b.bigHour) } return a._isValid } function l(a) { var b = h(NaN); return null != a ? g(j(b), a) : j(b).userInvalidated = !0, b } function m(a, b) { var c, d, e; if ("undefined" != typeof b._isAMomentObject && (a._isAMomentObject = b._isAMomentObject), "undefined" != typeof b._i && (a._i = b._i), "undefined" != typeof b._f && (a._f = b._f), "undefined" != typeof b._l && (a._l = b._l), "undefined" != typeof b._strict && (a._strict = b._strict), "undefined" != typeof b._tzm && (a._tzm = b._tzm), "undefined" != typeof b._isUTC && (a._isUTC = b._isUTC), "undefined" != typeof b._offset && (a._offset = b._offset), "undefined" != typeof b._pf && (a._pf = j(b)), "undefined" != typeof b._locale && (a._locale = b._locale), Jc.length > 0) for (c in Jc) d = Jc[c], e = b[d], "undefined" != typeof e && (a[d] = e); return a } function n(b) { m(this, b), this._d = new Date(null != b._d ? b._d.getTime() : NaN), Kc === !1 && (Kc = !0, a.updateOffset(this), Kc = !1) } function o(a) { return a instanceof n || null != a && null != a._isAMomentObject } function p(a) { return 0 > a ? Math.ceil(a) : Math.floor(a) } function q(a) { var b = +a, c = 0; return 0 !== b && isFinite(b) && (c = p(b)), c } function r(a, b, c) { var d, e = Math.min(a.length, b.length), f = Math.abs(a.length - b.length), g = 0; for (d = 0; e > d; d++) (c && a[d] !== b[d] || !c && q(a[d]) !== q(b[d])) && g++; return g + f } function s() { } function t(a) { return a ? a.toLowerCase().replace("_", "-") : a } function u(a) { for (var b, c, d, e, f = 0; f < a.length;) { for (e = t(a[f]).split("-"), b = e.length, c = t(a[f + 1]), c = c ? c.split("-") : null; b > 0;) { if (d = v(e.slice(0, b).join("-"))) return d; if (c && c.length >= b && r(e, c, !0) >= b - 1) break; b-- } f++ } return null } function v(a) { var b = null; if (!Lc[a] && "undefined" != typeof module && module && module.exports) try { b = Ic._abbr, require("./locale/" + a), w(b) } catch (c) { } return Lc[a] } function w(a, b) { var c; return a && (c = "undefined" == typeof b ? y(a) : x(a, b), c && (Ic = c)), Ic._abbr } function x(a, b) { return null !== b ? (b.abbr = a, Lc[a] = Lc[a] || new s, Lc[a].set(b), w(a), Lc[a]) : (delete Lc[a], null) } function y(a) { var b; if (a && a._locale && a._locale._abbr && (a = a._locale._abbr), !a) return Ic; if (!c(a)) { if (b = v(a)) return b; a = [a] } return u(a) } function z(a, b) { var c = a.toLowerCase(); Mc[c] = Mc[c + "s"] = Mc[b] = a } function A(a) { return "string" == typeof a ? Mc[a] || Mc[a.toLowerCase()] : void 0 } function B(a) { var b, c, d = {}; for (c in a) f(a, c) && (b = A(c), b && (d[b] = a[c])); return d } function C(b, c) { return function (d) { return null != d ? (E(this, b, d), a.updateOffset(this, c), this) : D(this, b) } } function D(a, b) { return a._d["get" + (a._isUTC ? "UTC" : "") + b]() } function E(a, b, c) { return a._d["set" + (a._isUTC ? "UTC" : "") + b](c) } function F(a, b) { var c; if ("object" == typeof a) for (c in a) this.set(c, a[c]); else if (a = A(a), "function" == typeof this[a]) return this[a](b); return this } function G(a, b, c) { var d = "" + Math.abs(a), e = b - d.length, f = a >= 0; return (f ? c ? "+" : "" : "-") + Math.pow(10, Math.max(0, e)).toString().substr(1) + d } function H(a, b, c, d) { var e = d; "string" == typeof d && (e = function () { return this[d]() }), a && (Qc[a] = e), b && (Qc[b[0]] = function () { return G(e.apply(this, arguments), b[1], b[2]) }), c && (Qc[c] = function () { return this.localeData().ordinal(e.apply(this, arguments), a) }) } function I(a) { return a.match(/\[[\s\S]/) ? a.replace(/^\[|\]$/g, "") : a.replace(/\\/g, "") } function J(a) { var b, c, d = a.match(Nc); for (b = 0, c = d.length; c > b; b++) Qc[d[b]] ? d[b] = Qc[d[b]] : d[b] = I(d[b]); return function (e) { var f = ""; for (b = 0; c > b; b++) f += d[b] instanceof Function ? d[b].call(e, a) : d[b]; return f } } function K(a, b) { return a.isValid() ? (b = L(b, a.localeData()), Pc[b] = Pc[b] || J(b), Pc[b](a)) : a.localeData().invalidDate() } function L(a, b) { function c(a) { return b.longDateFormat(a) || a } var d = 5; for (Oc.lastIndex = 0; d >= 0 && Oc.test(a) ;) a = a.replace(Oc, c), Oc.lastIndex = 0, d -= 1; return a } function M(a) { return "function" == typeof a && "[object Function]" === Object.prototype.toString.call(a) } function N(a, b, c) { dd[a] = M(b) ? b : function (a) { return a && c ? c : b } } function O(a, b) { return f(dd, a) ? dd[a](b._strict, b._locale) : new RegExp(P(a)) } function P(a) { return a.replace("\\", "").replace(/\\(\[)|\\(\])|\[([^\]\[]*)\]|\\(.)/g, function (a, b, c, d, e) { return b || c || d || e }).replace(/[-\/\\^$*+?.()|[\]{}]/g, "\\$&") } function Q(a, b) { var c, d = b; for ("string" == typeof a && (a = [a]), "number" == typeof b && (d = function (a, c) { c[b] = q(a) }), c = 0; c < a.length; c++) ed[a[c]] = d } function R(a, b) { Q(a, function (a, c, d, e) { d._w = d._w || {}, b(a, d._w, d, e) }) } function S(a, b, c) { null != b && f(ed, a) && ed[a](b, c._a, c, a) } function T(a, b) { return new Date(Date.UTC(a, b + 1, 0)).getUTCDate() } function U(a) { return this._months[a.month()] } function V(a) { return this._monthsShort[a.month()] } function W(a, b, c) { var d, e, f; for (this._monthsParse || (this._monthsParse = [], this._longMonthsParse = [], this._shortMonthsParse = []), d = 0; 12 > d; d++) { if (e = h([2e3, d]), c && !this._longMonthsParse[d] && (this._longMonthsParse[d] = new RegExp("^" + this.months(e, "").replace(".", "") + "$", "i"), this._shortMonthsParse[d] = new RegExp("^" + this.monthsShort(e, "").replace(".", "") + "$", "i")), c || this._monthsParse[d] || (f = "^" + this.months(e, "") + "|^" + this.monthsShort(e, ""), this._monthsParse[d] = new RegExp(f.replace(".", ""), "i")), c && "MMMM" === b && this._longMonthsParse[d].test(a)) return d; if (c && "MMM" === b && this._shortMonthsParse[d].test(a)) return d; if (!c && this._monthsParse[d].test(a)) return d } } function X(a, b) { var c; return "string" == typeof b && (b = a.localeData().monthsParse(b), "number" != typeof b) ? a : (c = Math.min(a.date(), T(a.year(), b)), a._d["set" + (a._isUTC ? "UTC" : "") + "Month"](b, c), a) } function Y(b) { return null != b ? (X(this, b), a.updateOffset(this, !0), this) : D(this, "Month") } function Z() { return T(this.year(), this.month()) } function $(a) { var b, c = a._a; return c && -2 === j(a).overflow && (b = c[gd] < 0 || c[gd] > 11 ? gd : c[hd] < 1 || c[hd] > T(c[fd], c[gd]) ? hd : c[id] < 0 || c[id] > 24 || 24 === c[id] && (0 !== c[jd] || 0 !== c[kd] || 0 !== c[ld]) ? id : c[jd] < 0 || c[jd] > 59 ? jd : c[kd] < 0 || c[kd] > 59 ? kd : c[ld] < 0 || c[ld] > 999 ? ld : -1, j(a)._overflowDayOfYear && (fd > b || b > hd) && (b = hd), j(a).overflow = b), a } function _(b) { a.suppressDeprecationWarnings === !1 && "undefined" != typeof console && console.warn && console.warn("Deprecation warning: " + b) } function aa(a, b) { var c = !0; return g(function () { return c && (_(a + "\n" + (new Error).stack), c = !1), b.apply(this, arguments) }, b) } function ba(a, b) { od[a] || (_(b), od[a] = !0) } function ca(a) { var b, c, d = a._i, e = pd.exec(d); if (e) { for (j(a).iso = !0, b = 0, c = qd.length; c > b; b++) if (qd[b][1].exec(d)) { a._f = qd[b][0]; break } for (b = 0, c = rd.length; c > b; b++) if (rd[b][1].exec(d)) { a._f += (e[6] || " ") + rd[b][0]; break } d.match(ad) && (a._f += "Z"), va(a) } else a._isValid = !1 } function da(b) { var c = sd.exec(b._i); return null !== c ? void (b._d = new Date(+c[1])) : (ca(b), void (b._isValid === !1 && (delete b._isValid, a.createFromInputFallback(b)))) } function ea(a, b, c, d, e, f, g) { var h = new Date(a, b, c, d, e, f, g); return 1970 > a && h.setFullYear(a), h } function fa(a) { var b = new Date(Date.UTC.apply(null, arguments)); return 1970 > a && b.setUTCFullYear(a), b } function ga(a) { return ha(a) ? 366 : 365 } function ha(a) { return a % 4 === 0 && a % 100 !== 0 || a % 400 === 0 } function ia() { return ha(this.year()) } function ja(a, b, c) { var d, e = c - b, f = c - a.day(); return f > e && (f -= 7), e - 7 > f && (f += 7), d = Da(a).add(f, "d"), { week: Math.ceil(d.dayOfYear() / 7), year: d.year() } } function ka(a) { return ja(a, this._week.dow, this._week.doy).week } function la() { return this._week.dow } function ma() { return this._week.doy } function na(a) { var b = this.localeData().week(this); return null == a ? b : this.add(7 * (a - b), "d") } function oa(a) { var b = ja(this, 1, 4).week; return null == a ? b : this.add(7 * (a - b), "d") } function pa(a, b, c, d, e) { var f, g = 6 + e - d, h = fa(a, 0, 1 + g), i = h.getUTCDay(); return e > i && (i += 7), c = null != c ? 1 * c : e, f = 1 + g + 7 * (b - 1) - i + c, { year: f > 0 ? a : a - 1, dayOfYear: f > 0 ? f : ga(a - 1) + f } } function qa(a) { var b = Math.round((this.clone().startOf("day") - this.clone().startOf("year")) / 864e5) + 1; return null == a ? b : this.add(a - b, "d") } function ra(a, b, c) { return null != a ? a : null != b ? b : c } function sa(a) { var b = new Date; return a._useUTC ? [b.getUTCFullYear(), b.getUTCMonth(), b.getUTCDate()] : [b.getFullYear(), b.getMonth(), b.getDate()] } function ta(a) { var b, c, d, e, f = []; if (!a._d) { for (d = sa(a), a._w && null == a._a[hd] && null == a._a[gd] && ua(a), a._dayOfYear && (e = ra(a._a[fd], d[fd]), a._dayOfYear > ga(e) && (j(a)._overflowDayOfYear = !0), c = fa(e, 0, a._dayOfYear), a._a[gd] = c.getUTCMonth(), a._a[hd] = c.getUTCDate()), b = 0; 3 > b && null == a._a[b]; ++b) a._a[b] = f[b] = d[b]; for (; 7 > b; b++) a._a[b] = f[b] = null == a._a[b] ? 2 === b ? 1 : 0 : a._a[b]; 24 === a._a[id] && 0 === a._a[jd] && 0 === a._a[kd] && 0 === a._a[ld] && (a._nextDay = !0, a._a[id] = 0), a._d = (a._useUTC ? fa : ea).apply(null, f), null != a._tzm && a._d.setUTCMinutes(a._d.getUTCMinutes() - a._tzm), a._nextDay && (a._a[id] = 24) } } function ua(a) { var b, c, d, e, f, g, h; b = a._w, null != b.GG || null != b.W || null != b.E ? (f = 1, g = 4, c = ra(b.GG, a._a[fd], ja(Da(), 1, 4).year), d = ra(b.W, 1), e = ra(b.E, 1)) : (f = a._locale._week.dow, g = a._locale._week.doy, c = ra(b.gg, a._a[fd], ja(Da(), f, g).year), d = ra(b.w, 1), null != b.d ? (e = b.d, f > e && ++d) : e = null != b.e ? b.e + f : f), h = pa(c, d, e, g, f), a._a[fd] = h.year, a._dayOfYear = h.dayOfYear } function va(b) { if (b._f === a.ISO_8601) return void ca(b); b._a = [], j(b).empty = !0; var c, d, e, f, g, h = "" + b._i, i = h.length, k = 0; for (e = L(b._f, b._locale).match(Nc) || [], c = 0; c < e.length; c++) f = e[c], d = (h.match(O(f, b)) || [])[0], d && (g = h.substr(0, h.indexOf(d)), g.length > 0 && j(b).unusedInput.push(g), h = h.slice(h.indexOf(d) + d.length), k += d.length), Qc[f] ? (d ? j(b).empty = !1 : j(b).unusedTokens.push(f), S(f, d, b)) : b._strict && !d && j(b).unusedTokens.push(f); j(b).charsLeftOver = i - k, h.length > 0 && j(b).unusedInput.push(h), j(b).bigHour === !0 && b._a[id] <= 12 && b._a[id] > 0 && (j(b).bigHour = void 0), b._a[id] = wa(b._locale, b._a[id], b._meridiem), ta(b), $(b) } function wa(a, b, c) { var d; return null == c ? b : null != a.meridiemHour ? a.meridiemHour(b, c) : null != a.isPM ? (d = a.isPM(c), d && 12 > b && (b += 12), d || 12 !== b || (b = 0), b) : b } function xa(a) { var b, c, d, e, f; if (0 === a._f.length) return j(a).invalidFormat = !0, void (a._d = new Date(NaN)); for (e = 0; e < a._f.length; e++) f = 0, b = m({}, a), null != a._useUTC && (b._useUTC = a._useUTC), b._f = a._f[e], va(b), k(b) && (f += j(b).charsLeftOver, f += 10 * j(b).unusedTokens.length, j(b).score = f, (null == d || d > f) && (d = f, c = b)); g(a, c || b) } function ya(a) { if (!a._d) { var b = B(a._i); a._a = [b.year, b.month, b.day || b.date, b.hour, b.minute, b.second, b.millisecond], ta(a) } } function za(a) { var b = new n($(Aa(a))); return b._nextDay && (b.add(1, "d"), b._nextDay = void 0), b } function Aa(a) { var b = a._i, e = a._f; return a._locale = a._locale || y(a._l), null === b || void 0 === e && "" === b ? l({ nullInput: !0 }) : ("string" == typeof b && (a._i = b = a._locale.preparse(b)), o(b) ? new n($(b)) : (c(e) ? xa(a) : e ? va(a) : d(b) ? a._d = b : Ba(a), a)) } function Ba(b) { var f = b._i; void 0 === f ? b._d = new Date : d(f) ? b._d = new Date(+f) : "string" == typeof f ? da(b) : c(f) ? (b._a = e(f.slice(0), function (a) { return parseInt(a, 10) }), ta(b)) : "object" == typeof f ? ya(b) : "number" == typeof f ? b._d = new Date(f) : a.createFromInputFallback(b) } function Ca(a, b, c, d, e) { var f = {}; return "boolean" == typeof c && (d = c, c = void 0), f._isAMomentObject = !0, f._useUTC = f._isUTC = e, f._l = c, f._i = a, f._f = b, f._strict = d, za(f) } function Da(a, b, c, d) { return Ca(a, b, c, d, !1) } function Ea(a, b) { var d, e; if (1 === b.length && c(b[0]) && (b = b[0]), !b.length) return Da(); for (d = b[0], e = 1; e < b.length; ++e) (!b[e].isValid() || b[e][a](d)) && (d = b[e]); return d } function Fa() { var a = [].slice.call(arguments, 0); return Ea("isBefore", a) } function Ga() { var a = [].slice.call(arguments, 0); return Ea("isAfter", a) } function Ha(a) { var b = B(a), c = b.year || 0, d = b.quarter || 0, e = b.month || 0, f = b.week || 0, g = b.day || 0, h = b.hour || 0, i = b.minute || 0, j = b.second || 0, k = b.millisecond || 0; this._milliseconds = +k + 1e3 * j + 6e4 * i + 36e5 * h, this._days = +g + 7 * f, this._months = +e + 3 * d + 12 * c, this._data = {}, this._locale = y(), this._bubble() } function Ia(a) { return a instanceof Ha } function Ja(a, b) { H(a, 0, 0, function () { var a = this.utcOffset(), c = "+"; return 0 > a && (a = -a, c = "-"), c + G(~~(a / 60), 2) + b + G(~~a % 60, 2) }) } function Ka(a) { var b = (a || "").match(ad) || [], c = b[b.length - 1] || [], d = (c + "").match(xd) || ["-", 0, 0], e = +(60 * d[1]) + q(d[2]); return "+" === d[0] ? e : -e } function La(b, c) { var e, f; return c._isUTC ? (e = c.clone(), f = (o(b) || d(b) ? +b : +Da(b)) - +e, e._d.setTime(+e._d + f), a.updateOffset(e, !1), e) : Da(b).local() } function Ma(a) { return 15 * -Math.round(a._d.getTimezoneOffset() / 15) } function Na(b, c) { var d, e = this._offset || 0; return null != b ? ("string" == typeof b && (b = Ka(b)), Math.abs(b) < 16 && (b = 60 * b), !this._isUTC && c && (d = Ma(this)), this._offset = b, this._isUTC = !0, null != d && this.add(d, "m"), e !== b && (!c || this._changeInProgress ? bb(this, Ya(b - e, "m"), 1, !1) : this._changeInProgress || (this._changeInProgress = !0, a.updateOffset(this, !0), this._changeInProgress = null)), this) : this._isUTC ? e : Ma(this) } function Oa(a, b) { return null != a ? ("string" != typeof a && (a = -a), this.utcOffset(a, b), this) : -this.utcOffset() } function Pa(a) { return this.utcOffset(0, a) } function Qa(a) { return this._isUTC && (this.utcOffset(0, a), this._isUTC = !1, a && this.subtract(Ma(this), "m")), this } function Ra() { return this._tzm ? this.utcOffset(this._tzm) : "string" == typeof this._i && this.utcOffset(Ka(this._i)), this } function Sa(a) { return a = a ? Da(a).utcOffset() : 0, (this.utcOffset() - a) % 60 === 0 } function Ta() { return this.utcOffset() > this.clone().month(0).utcOffset() || this.utcOffset() > this.clone().month(5).utcOffset() } function Ua() { if ("undefined" != typeof this._isDSTShifted) return this._isDSTShifted; var a = {}; if (m(a, this), a = Aa(a), a._a) { var b = a._isUTC ? h(a._a) : Da(a._a); this._isDSTShifted = this.isValid() && r(a._a, b.toArray()) > 0 } else this._isDSTShifted = !1; return this._isDSTShifted } function Va() { return !this._isUTC } function Wa() { return this._isUTC } function Xa() { return this._isUTC && 0 === this._offset } function Ya(a, b) { var c, d, e, g = a, h = null; return Ia(a) ? g = { ms: a._milliseconds, d: a._days, M: a._months } : "number" == typeof a ? (g = {}, b ? g[b] = a : g.milliseconds = a) : (h = yd.exec(a)) ? (c = "-" === h[1] ? -1 : 1, g = { y: 0, d: q(h[hd]) * c, h: q(h[id]) * c, m: q(h[jd]) * c, s: q(h[kd]) * c, ms: q(h[ld]) * c }) : (h = zd.exec(a)) ? (c = "-" === h[1] ? -1 : 1, g = { y: Za(h[2], c), M: Za(h[3], c), d: Za(h[4], c), h: Za(h[5], c), m: Za(h[6], c), s: Za(h[7], c), w: Za(h[8], c) }) : null == g ? g = {} : "object" == typeof g && ("from" in g || "to" in g) && (e = _a(Da(g.from), Da(g.to)), g = {}, g.ms = e.milliseconds, g.M = e.months), d = new Ha(g), Ia(a) && f(a, "_locale") && (d._locale = a._locale), d } function Za(a, b) { var c = a && parseFloat(a.replace(",", ".")); return (isNaN(c) ? 0 : c) * b } function $a(a, b) { var c = { milliseconds: 0, months: 0 }; return c.months = b.month() - a.month() + 12 * (b.year() - a.year()), a.clone().add(c.months, "M").isAfter(b) && --c.months, c.milliseconds = +b - +a.clone().add(c.months, "M"), c } function _a(a, b) { var c; return b = La(b, a), a.isBefore(b) ? c = $a(a, b) : (c = $a(b, a), c.milliseconds = -c.milliseconds, c.months = -c.months), c } function ab(a, b) { return function (c, d) { var e, f; return null === d || isNaN(+d) || (ba(b, "moment()." + b + "(period, number) is deprecated. Please use moment()." + b + "(number, period)."), f = c, c = d, d = f), c = "string" == typeof c ? +c : c, e = Ya(c, d), bb(this, e, a), this } } function bb(b, c, d, e) { var f = c._milliseconds, g = c._days, h = c._months; e = null == e ? !0 : e, f && b._d.setTime(+b._d + f * d), g && E(b, "Date", D(b, "Date") + g * d), h && X(b, D(b, "Month") + h * d), e && a.updateOffset(b, g || h) } function cb(a, b) { var c = a || Da(), d = La(c, this).startOf("day"), e = this.diff(d, "days", !0), f = -6 > e ? "sameElse" : -1 > e ? "lastWeek" : 0 > e ? "lastDay" : 1 > e ? "sameDay" : 2 > e ? "nextDay" : 7 > e ? "nextWeek" : "sameElse"; return this.format(b && b[f] || this.localeData().calendar(f, this, Da(c))) } function db() { return new n(this) } function eb(a, b) { var c; return b = A("undefined" != typeof b ? b : "millisecond"), "millisecond" === b ? (a = o(a) ? a : Da(a), +this > +a) : (c = o(a) ? +a : +Da(a), c < +this.clone().startOf(b)) } function fb(a, b) { var c; return b = A("undefined" != typeof b ? b : "millisecond"), "millisecond" === b ? (a = o(a) ? a : Da(a), +a > +this) : (c = o(a) ? +a : +Da(a), +this.clone().endOf(b) < c) } function gb(a, b, c) { return this.isAfter(a, c) && this.isBefore(b, c) } function hb(a, b) { var c; return b = A(b || "millisecond"), "millisecond" === b ? (a = o(a) ? a : Da(a), +this === +a) : (c = +Da(a), +this.clone().startOf(b) <= c && c <= +this.clone().endOf(b)) } function ib(a, b, c) { var d, e, f = La(a, this), g = 6e4 * (f.utcOffset() - this.utcOffset()); return b = A(b), "year" === b || "month" === b || "quarter" === b ? (e = jb(this, f), "quarter" === b ? e /= 3 : "year" === b && (e /= 12)) : (d = this - f, e = "second" === b ? d / 1e3 : "minute" === b ? d / 6e4 : "hour" === b ? d / 36e5 : "day" === b ? (d - g) / 864e5 : "week" === b ? (d - g) / 6048e5 : d), c ? e : p(e) } function jb(a, b) { var c, d, e = 12 * (b.year() - a.year()) + (b.month() - a.month()), f = a.clone().add(e, "months"); return 0 > b - f ? (c = a.clone().add(e - 1, "months"), d = (b - f) / (f - c)) : (c = a.clone().add(e + 1, "months"), d = (b - f) / (c - f)), -(e + d) } function kb() { return this.clone().locale("en").format("ddd MMM DD YYYY HH:mm:ss [GMT]ZZ") } function lb() { var a = this.clone().utc(); return 0 < a.year() && a.year() <= 9999 ? "function" == typeof Date.prototype.toISOString ? this.toDate().toISOString() : K(a, "YYYY-MM-DD[T]HH:mm:ss.SSS[Z]") : K(a, "YYYYYY-MM-DD[T]HH:mm:ss.SSS[Z]") } function mb(b) { var c = K(this, b || a.defaultFormat); return this.localeData().postformat(c) } function nb(a, b) { return this.isValid() ? Ya({ to: this, from: a }).locale(this.locale()).humanize(!b) : this.localeData().invalidDate() } function ob(a) { return this.from(Da(), a) } function pb(a, b) { return this.isValid() ? Ya({ from: this, to: a }).locale(this.locale()).humanize(!b) : this.localeData().invalidDate() } function qb(a) { return this.to(Da(), a) } function rb(a) { var b; return void 0 === a ? this._locale._abbr : (b = y(a), null != b && (this._locale = b), this) } function sb() { return this._locale } function tb(a) { switch (a = A(a)) { case "year": this.month(0); case "quarter": case "month": this.date(1); case "week": case "isoWeek": case "day": this.hours(0); case "hour": this.minutes(0); case "minute": this.seconds(0); case "second": this.milliseconds(0) } return "week" === a && this.weekday(0), "isoWeek" === a && this.isoWeekday(1), "quarter" === a && this.month(3 * Math.floor(this.month() / 3)), this } function ub(a) { return a = A(a), void 0 === a || "millisecond" === a ? this : this.startOf(a).add(1, "isoWeek" === a ? "week" : a).subtract(1, "ms") } function vb() { return +this._d - 6e4 * (this._offset || 0) } function wb() { return Math.floor(+this / 1e3) } function xb() { return this._offset ? new Date(+this) : this._d } function yb() { var a = this; return [a.year(), a.month(), a.date(), a.hour(), a.minute(), a.second(), a.millisecond()] } function zb() { var a = this; return { years: a.year(), months: a.month(), date: a.date(), hours: a.hours(), minutes: a.minutes(), seconds: a.seconds(), milliseconds: a.milliseconds() } } function Ab() { return k(this) } function Bb() { return g({}, j(this)) } function Cb() { return j(this).overflow } function Db(a, b) { H(0, [a, a.length], 0, b) } function Eb(a, b, c) { return ja(Da([a, 11, 31 + b - c]), b, c).week } function Fb(a) { var b = ja(this, this.localeData()._week.dow, this.localeData()._week.doy).year; return null == a ? b : this.add(a - b, "y") } function Gb(a) { var b = ja(this, 1, 4).year; return null == a ? b : this.add(a - b, "y") } function Hb() { return Eb(this.year(), 1, 4) } function Ib() { var a = this.localeData()._week; return Eb(this.year(), a.dow, a.doy) } function Jb(a) { return null == a ? Math.ceil((this.month() + 1) / 3) : this.month(3 * (a - 1) + this.month() % 3) } function Kb(a, b) { return "string" != typeof a ? a : isNaN(a) ? (a = b.weekdaysParse(a), "number" == typeof a ? a : null) : parseInt(a, 10) } function Lb(a) { return this._weekdays[a.day()] } function Mb(a) { return this._weekdaysShort[a.day()] } function Nb(a) { return this._weekdaysMin[a.day()] } function Ob(a) { var b, c, d; for (this._weekdaysParse = this._weekdaysParse || [], b = 0; 7 > b; b++) if (this._weekdaysParse[b] || (c = Da([2e3, 1]).day(b), d = "^" + this.weekdays(c, "") + "|^" + this.weekdaysShort(c, "") + "|^" + this.weekdaysMin(c, ""), this._weekdaysParse[b] = new RegExp(d.replace(".", ""), "i")), this._weekdaysParse[b].test(a)) return b } function Pb(a) { var b = this._isUTC ? this._d.getUTCDay() : this._d.getDay(); return null != a ? (a = Kb(a, this.localeData()), this.add(a - b, "d")) : b } function Qb(a) { var b = (this.day() + 7 - this.localeData()._week.dow) % 7; return null == a ? b : this.add(a - b, "d") } function Rb(a) { return null == a ? this.day() || 7 : this.day(this.day() % 7 ? a : a - 7) } function Sb(a, b) { H(a, 0, 0, function () { return this.localeData().meridiem(this.hours(), this.minutes(), b) }) } function Tb(a, b) { return b._meridiemParse } function Ub(a) { return "p" === (a + "").toLowerCase().charAt(0) } function Vb(a, b, c) { return a > 11 ? c ? "pm" : "PM" : c ? "am" : "AM" } function Wb(a, b) { b[ld] = q(1e3 * ("0." + a)) } function Xb() { return this._isUTC ? "UTC" : "" } function Yb() { return this._isUTC ? "Coordinated Universal Time" : "" } function Zb(a) { return Da(1e3 * a) } function $b() { return Da.apply(null, arguments).parseZone() } function _b(a, b, c) { var d = this._calendar[a]; return "function" == typeof d ? d.call(b, c) : d } function ac(a) { var b = this._longDateFormat[a], c = this._longDateFormat[a.toUpperCase()]; return b || !c ? b : (this._longDateFormat[a] = c.replace(/MMMM|MM|DD|dddd/g, function (a) { return a.slice(1) }), this._longDateFormat[a]) } function bc() { return this._invalidDate } function cc(a) { return this._ordinal.replace("%d", a) } function dc(a) { return a } function ec(a, b, c, d) { var e = this._relativeTime[c]; return "function" == typeof e ? e(a, b, c, d) : e.replace(/%d/i, a) } function fc(a, b) { var c = this._relativeTime[a > 0 ? "future" : "past"]; return "function" == typeof c ? c(b) : c.replace(/%s/i, b) } function gc(a) { var b, c; for (c in a) b = a[c], "function" == typeof b ? this[c] = b : this["_" + c] = b; this._ordinalParseLenient = new RegExp(this._ordinalParse.source + "|" + /\d{1,2}/.source) } function hc(a, b, c, d) { var e = y(), f = h().set(d, b); return e[c](f, a) } function ic(a, b, c, d, e) { if ("number" == typeof a && (b = a, a = void 0), a = a || "", null != b) return hc(a, b, c, e); var f, g = []; for (f = 0; d > f; f++) g[f] = hc(a, f, c, e); return g } function jc(a, b) { return ic(a, b, "months", 12, "month") } function kc(a, b) { return ic(a, b, "monthsShort", 12, "month") } function lc(a, b) { return ic(a, b, "weekdays", 7, "day") } function mc(a, b) { return ic(a, b, "weekdaysShort", 7, "day") } function nc(a, b) { return ic(a, b, "weekdaysMin", 7, "day") } function oc() { var a = this._data; return this._milliseconds = Wd(this._milliseconds), this._days = Wd(this._days), this._months = Wd(this._months), a.milliseconds = Wd(a.milliseconds), a.seconds = Wd(a.seconds), a.minutes = Wd(a.minutes), a.hours = Wd(a.hours), a.months = Wd(a.months), a.years = Wd(a.years), this } function pc(a, b, c, d) { var e = Ya(b, c); return a._milliseconds += d * e._milliseconds, a._days += d * e._days, a._months += d * e._months, a._bubble() } function qc(a, b) { return pc(this, a, b, 1) } function rc(a, b) { return pc(this, a, b, -1) } function sc(a) { return 0 > a ? Math.floor(a) : Math.ceil(a) } function tc() { var a, b, c, d, e, f = this._milliseconds, g = this._days, h = this._months, i = this._data; return f >= 0 && g >= 0 && h >= 0 || 0 >= f && 0 >= g && 0 >= h || (f += 864e5 * sc(vc(h) + g), g = 0, h = 0), i.milliseconds = f % 1e3, a = p(f / 1e3), i.seconds = a % 60, b = p(a / 60), i.minutes = b % 60, c = p(b / 60), i.hours = c % 24, g += p(c / 24), e = p(uc(g)), h += e, g -= sc(vc(e)), d = p(h / 12), h %= 12, i.days = g, i.months = h, i.years = d, this } function uc(a) { return 4800 * a / 146097 } function vc(a) { return 146097 * a / 4800 } function wc(a) { var b, c, d = this._milliseconds; if (a = A(a), "month" === a || "year" === a) return b = this._days + d / 864e5, c = this._months + uc(b), "month" === a ? c : c / 12; switch (b = this._days + Math.round(vc(this._months)), a) { case "week": return b / 7 + d / 6048e5; case "day": return b + d / 864e5; case "hour": return 24 * b + d / 36e5; case "minute": return 1440 * b + d / 6e4; case "second": return 86400 * b + d / 1e3; case "millisecond": return Math.floor(864e5 * b) + d; default: throw new Error("Unknown unit " + a) } } function xc() { return this._milliseconds + 864e5 * this._days + this._months % 12 * 2592e6 + 31536e6 * q(this._months / 12) } function yc(a) { return function () { return this.as(a) } } function zc(a) { return a = A(a), this[a + "s"]() } function Ac(a) { return function () { return this._data[a] } } function Bc() { return p(this.days() / 7) } function Cc(a, b, c, d, e) { return e.relativeTime(b || 1, !!c, a, d) } function Dc(a, b, c) { var d = Ya(a).abs(), e = ke(d.as("s")), f = ke(d.as("m")), g = ke(d.as("h")), h = ke(d.as("d")), i = ke(d.as("M")), j = ke(d.as("y")), k = e < le.s && ["s", e] || 1 === f && ["m"] || f < le.m && ["mm", f] || 1 === g && ["h"] || g < le.h && ["hh", g] || 1 === h && ["d"] || h < le.d && ["dd", h] || 1 === i && ["M"] || i < le.M && ["MM", i] || 1 === j && ["y"] || ["yy", j]; return k[2] = b, k[3] = +a > 0, k[4] = c, Cc.apply(null, k) } function Ec(a, b) { return void 0 === le[a] ? !1 : void 0 === b ? le[a] : (le[a] = b, !0) } function Fc(a) { var b = this.localeData(), c = Dc(this, !a, b); return a && (c = b.pastFuture(+this, c)), b.postformat(c) } function Gc() { var a, b, c, d = me(this._milliseconds) / 1e3, e = me(this._days), f = me(this._months); a = p(d / 60), b = p(a / 60), d %= 60, a %= 60, c = p(f / 12), f %= 12; var g = c, h = f, i = e, j = b, k = a, l = d, m = this.asSeconds(); return m ? (0 > m ? "-" : "") + "P" + (g ? g + "Y" : "") + (h ? h + "M" : "") + (i ? i + "D" : "") + (j || k || l ? "T" : "") + (j ? j + "H" : "") + (k ? k + "M" : "") + (l ? l + "S" : "") : "P0D" } var Hc, Ic, Jc = a.momentProperties = [], Kc = !1, Lc = {}, Mc = {}, Nc = /(\[[^\[]*\])|(\\)?(Mo|MM?M?M?|Do|DDDo|DD?D?D?|ddd?d?|do?|w[o|w]?|W[o|W]?|Q|YYYYYY|YYYYY|YYYY|YY|gg(ggg?)?|GG(GGG?)?|e|E|a|A|hh?|HH?|mm?|ss?|S{1,9}|x|X|zz?|ZZ?|.)/g, Oc = /(\[[^\[]*\])|(\\)?(LTS|LT|LL?L?L?|l{1,4})/g, Pc = {}, Qc = {}, Rc = /\d/, Sc = /\d\d/, Tc = /\d{3}/, Uc = /\d{4}/, Vc = /[+-]?\d{6}/, Wc = /\d\d?/, Xc = /\d{1,3}/, Yc = /\d{1,4}/, Zc = /[+-]?\d{1,6}/, $c = /\d+/, _c = /[+-]?\d+/, ad = /Z|[+-]\d\d:?\d\d/gi, bd = /[+-]?\d+(\.\d{1,3})?/, cd = /[0-9]*['a-z\u00A0-\u05FF\u0700-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]+|[\u0600-\u06FF\/]+(\s*?[\u0600-\u06FF]+){1,2}/i, dd = {}, ed = {}, fd = 0, gd = 1, hd = 2, id = 3, jd = 4, kd = 5, ld = 6; H("M", ["MM", 2], "Mo", function () { return this.month() + 1 }), H("MMM", 0, 0, function (a) { return this.localeData().monthsShort(this, a) }), H("MMMM", 0, 0, function (a) { return this.localeData().months(this, a) }), z("month", "M"), N("M", Wc), N("MM", Wc, Sc), N("MMM", cd), N("MMMM", cd), Q(["M", "MM"], function (a, b) { b[gd] = q(a) - 1 }), Q(["MMM", "MMMM"], function (a, b, c, d) { var e = c._locale.monthsParse(a, d, c._strict); null != e ? b[gd] = e : j(c).invalidMonth = a }); var md = "January_February_March_April_May_June_July_August_September_October_November_December".split("_"), nd = "Jan_Feb_Mar_Apr_May_Jun_Jul_Aug_Sep_Oct_Nov_Dec".split("_"), od = {}; a.suppressDeprecationWarnings = !1; var pd = /^\s*(?:[+-]\d{6}|\d{4})-(?:(\d\d-\d\d)|(W\d\d$)|(W\d\d-\d)|(\d\d\d))((T| )(\d\d(:\d\d(:\d\d(\.\d+)?)?)?)?([\+\-]\d\d(?::?\d\d)?|\s*Z)?)?$/, qd = [["YYYYYY-MM-DD", /[+-]\d{6}-\d{2}-\d{2}/], ["YYYY-MM-DD", /\d{4}-\d{2}-\d{2}/], ["GGGG-[W]WW-E", /\d{4}-W\d{2}-\d/], ["GGGG-[W]WW", /\d{4}-W\d{2}/], ["YYYY-DDD", /\d{4}-\d{3}/]], rd = [["HH:mm:ss.SSSS", /(T| )\d\d:\d\d:\d\d\.\d+/], ["HH:mm:ss", /(T| )\d\d:\d\d:\d\d/], ["HH:mm", /(T| )\d\d:\d\d/], ["HH", /(T| )\d\d/]], sd = /^\/?Date\((\-?\d+)/i; a.createFromInputFallback = aa("moment construction falls back to js Date. This is discouraged and will be removed in upcoming major release. Please refer to https://github.com/moment/moment/issues/1407 for more info.", function (a) { a._d = new Date(a._i + (a._useUTC ? " UTC" : "")) }), H(0, ["YY", 2], 0, function () { return this.year() % 100 }), H(0, ["YYYY", 4], 0, "year"), H(0, ["YYYYY", 5], 0, "year"), H(0, ["YYYYYY", 6, !0], 0, "year"), z("year", "y"), N("Y", _c), N("YY", Wc, Sc), N("YYYY", Yc, Uc), N("YYYYY", Zc, Vc), N("YYYYYY", Zc, Vc), Q(["YYYYY", "YYYYYY"], fd), Q("YYYY", function (b, c) { c[fd] = 2 === b.length ? a.parseTwoDigitYear(b) : q(b) }), Q("YY", function (b, c) { c[fd] = a.parseTwoDigitYear(b) }), a.parseTwoDigitYear = function (a) { return q(a) + (q(a) > 68 ? 1900 : 2e3) }; var td = C("FullYear", !1); H("w", ["ww", 2], "wo", "week"), H("W", ["WW", 2], "Wo", "isoWeek"), z("week", "w"), z("isoWeek", "W"), N("w", Wc), N("ww", Wc, Sc), N("W", Wc), N("WW", Wc, Sc), R(["w", "ww", "W", "WW"], function (a, b, c, d) { b[d.substr(0, 1)] = q(a) }); var ud = { dow: 0, doy: 6 }; H("DDD", ["DDDD", 3], "DDDo", "dayOfYear"), z("dayOfYear", "DDD"), N("DDD", Xc), N("DDDD", Tc), Q(["DDD", "DDDD"], function (a, b, c) { c._dayOfYear = q(a) }), a.ISO_8601 = function () { }; var vd = aa("moment().min is deprecated, use moment.min instead. https://github.com/moment/moment/issues/1548", function () { var a = Da.apply(null, arguments); return this > a ? this : a }), wd = aa("moment().max is deprecated, use moment.max instead. https://github.com/moment/moment/issues/1548", function () { var a = Da.apply(null, arguments); return a > this ? this : a }); Ja("Z", ":"), Ja("ZZ", ""), N("Z", ad), N("ZZ", ad), Q(["Z", "ZZ"], function (a, b, c) { c._useUTC = !0, c._tzm = Ka(a) }); var xd = /([\+\-]|\d\d)/gi; a.updateOffset = function () { }; var yd = /(\-)?(?:(\d*)\.)?(\d+)\:(\d+)(?:\:(\d+)\.?(\d{3})?)?/, zd = /^(-)?P(?:(?:([0-9,.]*)Y)?(?:([0-9,.]*)M)?(?:([0-9,.]*)D)?(?:T(?:([0-9,.]*)H)?(?:([0-9,.]*)M)?(?:([0-9,.]*)S)?)?|([0-9,.]*)W)$/; Ya.fn = Ha.prototype; var Ad = ab(1, "add"), Bd = ab(-1, "subtract"); a.defaultFormat = "YYYY-MM-DDTHH:mm:ssZ"; var Cd = aa("moment().lang() is deprecated. Instead, use moment().localeData() to get the language configuration. Use moment().locale() to change languages.", function (a) { return void 0 === a ? this.localeData() : this.locale(a) }); H(0, ["gg", 2], 0, function () { return this.weekYear() % 100 }), H(0, ["GG", 2], 0, function () { return this.isoWeekYear() % 100 }), Db("gggg", "weekYear"), Db("ggggg", "weekYear"), Db("GGGG", "isoWeekYear"), Db("GGGGG", "isoWeekYear"), z("weekYear", "gg"), z("isoWeekYear", "GG"), N("G", _c), N("g", _c), N("GG", Wc, Sc), N("gg", Wc, Sc), N("GGGG", Yc, Uc), N("gggg", Yc, Uc), N("GGGGG", Zc, Vc), N("ggggg", Zc, Vc), R(["gggg", "ggggg", "GGGG", "GGGGG"], function (a, b, c, d) { b[d.substr(0, 2)] = q(a) }), R(["gg", "GG"], function (b, c, d, e) { c[e] = a.parseTwoDigitYear(b) }), H("Q", 0, 0, "quarter"), z("quarter", "Q"), N("Q", Rc), Q("Q", function (a, b) { b[gd] = 3 * (q(a) - 1) }), H("D", ["DD", 2], "Do", "date"), z("date", "D"), N("D", Wc), N("DD", Wc, Sc), N("Do", function (a, b) { return a ? b._ordinalParse : b._ordinalParseLenient }), Q(["D", "DD"], hd), Q("Do", function (a, b) { b[hd] = q(a.match(Wc)[0], 10) }); var Dd = C("Date", !0); H("d", 0, "do", "day"), H("dd", 0, 0, function (a) { return this.localeData().weekdaysMin(this, a) }), H("ddd", 0, 0, function (a) { return this.localeData().weekdaysShort(this, a) }), H("dddd", 0, 0, function (a) { return this.localeData().weekdays(this, a) }), H("e", 0, 0, "weekday"), H("E", 0, 0, "isoWeekday"), z("day", "d"), z("weekday", "e"), z("isoWeekday", "E"), N("d", Wc), N("e", Wc), N("E", Wc), N("dd", cd), N("ddd", cd), N("dddd", cd), R(["dd", "ddd", "dddd"], function (a, b, c) { var d = c._locale.weekdaysParse(a); null != d ? b.d = d : j(c).invalidWeekday = a }), R(["d", "e", "E"], function (a, b, c, d) { b[d] = q(a) }); var Ed = "Sunday_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday".split("_"), Fd = "Sun_Mon_Tue_Wed_Thu_Fri_Sat".split("_"), Gd = "Su_Mo_Tu_We_Th_Fr_Sa".split("_"); H("H", ["HH", 2], 0, "hour"), H("h", ["hh", 2], 0, function () { return this.hours() % 12 || 12 }), Sb("a", !0), Sb("A", !1), z("hour", "h"), N("a", Tb), N("A", Tb), N("H", Wc), N("h", Wc), N("HH", Wc, Sc), N("hh", Wc, Sc), Q(["H", "HH"], id), Q(["a", "A"], function (a, b, c) { c._isPm = c._locale.isPM(a), c._meridiem = a }), Q(["h", "hh"], function (a, b, c) { b[id] = q(a), j(c).bigHour = !0 }); var Hd = /[ap]\.?m?\.?/i, Id = C("Hours", !0); H("m", ["mm", 2], 0, "minute"), z("minute", "m"), N("m", Wc), N("mm", Wc, Sc), Q(["m", "mm"], jd); var Jd = C("Minutes", !1); H("s", ["ss", 2], 0, "second"), z("second", "s"), N("s", Wc), N("ss", Wc, Sc), Q(["s", "ss"], kd); var Kd = C("Seconds", !1); H("S", 0, 0, function () { return ~~(this.millisecond() / 100) }), H(0, ["SS", 2], 0, function () { return ~~(this.millisecond() / 10) }), H(0, ["SSS", 3], 0, "millisecond"), H(0, ["SSSS", 4], 0, function () { return 10 * this.millisecond() }), H(0, ["SSSSS", 5], 0, function () { return 100 * this.millisecond() }), H(0, ["SSSSSS", 6], 0, function () { return 1e3 * this.millisecond() }), H(0, ["SSSSSSS", 7], 0, function () { return 1e4 * this.millisecond() }), H(0, ["SSSSSSSS", 8], 0, function () { return 1e5 * this.millisecond() }), H(0, ["SSSSSSSSS", 9], 0, function () { return 1e6 * this.millisecond() }), z("millisecond", "ms"), N("S", Xc, Rc), N("SS", Xc, Sc), N("SSS", Xc, Tc); var Ld; for (Ld = "SSSS"; Ld.length <= 9; Ld += "S") N(Ld, $c); for (Ld = "S"; Ld.length <= 9; Ld += "S") Q(Ld, Wb); var Md = C("Milliseconds", !1); H("z", 0, 0, "zoneAbbr"), H("zz", 0, 0, "zoneName"); var Nd = n.prototype; Nd.add = Ad, Nd.calendar = cb, Nd.clone = db, Nd.diff = ib, Nd.endOf = ub, Nd.format = mb, Nd.from = nb, Nd.fromNow = ob, Nd.to = pb, Nd.toNow = qb, Nd.get = F, Nd.invalidAt = Cb, Nd.isAfter = eb, Nd.isBefore = fb, Nd.isBetween = gb, Nd.isSame = hb, Nd.isValid = Ab, Nd.lang = Cd, Nd.locale = rb, Nd.localeData = sb, Nd.max = wd, Nd.min = vd, Nd.parsingFlags = Bb, Nd.set = F, Nd.startOf = tb, Nd.subtract = Bd, Nd.toArray = yb, Nd.toObject = zb, Nd.toDate = xb, Nd.toISOString = lb, Nd.toJSON = lb, Nd.toString = kb, Nd.unix = wb, Nd.valueOf = vb, Nd.year = td, Nd.isLeapYear = ia, Nd.weekYear = Fb, Nd.isoWeekYear = Gb, Nd.quarter = Nd.quarters = Jb, Nd.month = Y, Nd.daysInMonth = Z, Nd.week = Nd.weeks = na, Nd.isoWeek = Nd.isoWeeks = oa, Nd.weeksInYear = Ib, Nd.isoWeeksInYear = Hb, Nd.date = Dd, Nd.day = Nd.days = Pb, Nd.weekday = Qb, Nd.isoWeekday = Rb, Nd.dayOfYear = qa, Nd.hour = Nd.hours = Id, Nd.minute = Nd.minutes = Jd, Nd.second = Nd.seconds = Kd,
    Nd.millisecond = Nd.milliseconds = Md, Nd.utcOffset = Na, Nd.utc = Pa, Nd.local = Qa, Nd.parseZone = Ra, Nd.hasAlignedHourOffset = Sa, Nd.isDST = Ta, Nd.isDSTShifted = Ua, Nd.isLocal = Va, Nd.isUtcOffset = Wa, Nd.isUtc = Xa, Nd.isUTC = Xa, Nd.zoneAbbr = Xb, Nd.zoneName = Yb, Nd.dates = aa("dates accessor is deprecated. Use date instead.", Dd), Nd.months = aa("months accessor is deprecated. Use month instead", Y), Nd.years = aa("years accessor is deprecated. Use year instead", td), Nd.zone = aa("moment().zone is deprecated, use moment().utcOffset instead. https://github.com/moment/moment/issues/1779", Oa); var Od = Nd, Pd = { sameDay: "[Today at] LT", nextDay: "[Tomorrow at] LT", nextWeek: "dddd [at] LT", lastDay: "[Yesterday at] LT", lastWeek: "[Last] dddd [at] LT", sameElse: "L" }, Qd = { LTS: "h:mm:ss A", LT: "h:mm A", L: "MM/DD/YYYY", LL: "MMMM D, YYYY", LLL: "MMMM D, YYYY h:mm A", LLLL: "dddd, MMMM D, YYYY h:mm A" }, Rd = "Invalid date", Sd = "%d", Td = /\d{1,2}/, Ud = { future: "in %s", past: "%s ago", s: "a few seconds", m: "a minute", mm: "%d minutes", h: "an hour", hh: "%d hours", d: "a day", dd: "%d days", M: "a month", MM: "%d months", y: "a year", yy: "%d years" }, Vd = s.prototype; Vd._calendar = Pd, Vd.calendar = _b, Vd._longDateFormat = Qd, Vd.longDateFormat = ac, Vd._invalidDate = Rd, Vd.invalidDate = bc, Vd._ordinal = Sd, Vd.ordinal = cc, Vd._ordinalParse = Td, Vd.preparse = dc, Vd.postformat = dc, Vd._relativeTime = Ud, Vd.relativeTime = ec, Vd.pastFuture = fc, Vd.set = gc, Vd.months = U, Vd._months = md, Vd.monthsShort = V, Vd._monthsShort = nd, Vd.monthsParse = W, Vd.week = ka, Vd._week = ud, Vd.firstDayOfYear = ma, Vd.firstDayOfWeek = la, Vd.weekdays = Lb, Vd._weekdays = Ed, Vd.weekdaysMin = Nb, Vd._weekdaysMin = Gd, Vd.weekdaysShort = Mb, Vd._weekdaysShort = Fd, Vd.weekdaysParse = Ob, Vd.isPM = Ub, Vd._meridiemParse = Hd, Vd.meridiem = Vb, w("en", { ordinalParse: /\d{1,2}(th|st|nd|rd)/, ordinal: function (a) { var b = a % 10, c = 1 === q(a % 100 / 10) ? "th" : 1 === b ? "st" : 2 === b ? "nd" : 3 === b ? "rd" : "th"; return a + c } }), a.lang = aa("moment.lang is deprecated. Use moment.locale instead.", w), a.langData = aa("moment.langData is deprecated. Use moment.localeData instead.", y); var Wd = Math.abs, Xd = yc("ms"), Yd = yc("s"), Zd = yc("m"), $d = yc("h"), _d = yc("d"), ae = yc("w"), be = yc("M"), ce = yc("y"), de = Ac("milliseconds"), ee = Ac("seconds"), fe = Ac("minutes"), ge = Ac("hours"), he = Ac("days"), ie = Ac("months"), je = Ac("years"), ke = Math.round, le = { s: 45, m: 45, h: 22, d: 26, M: 11 }, me = Math.abs, ne = Ha.prototype; ne.abs = oc, ne.add = qc, ne.subtract = rc, ne.as = wc, ne.asMilliseconds = Xd, ne.asSeconds = Yd, ne.asMinutes = Zd, ne.asHours = $d, ne.asDays = _d, ne.asWeeks = ae, ne.asMonths = be, ne.asYears = ce, ne.valueOf = xc, ne._bubble = tc, ne.get = zc, ne.milliseconds = de, ne.seconds = ee, ne.minutes = fe, ne.hours = ge, ne.days = he, ne.weeks = Bc, ne.months = ie, ne.years = je, ne.humanize = Fc, ne.toISOString = Gc, ne.toString = Gc, ne.toJSON = Gc, ne.locale = rb, ne.localeData = sb, ne.toIsoString = aa("toIsoString() is deprecated. Please use toISOString() instead (notice the capitals)", Gc), ne.lang = Cd, H("X", 0, 0, "unix"), H("x", 0, 0, "valueOf"), N("x", _c), N("X", bd), Q("X", function (a, b, c) { c._d = new Date(1e3 * parseFloat(a, 10)) }), Q("x", function (a, b, c) { c._d = new Date(q(a)) }), a.version = "2.10.6", b(Da), a.fn = Od, a.min = Fa, a.max = Ga, a.utc = h, a.unix = Zb, a.months = jc, a.isDate = d, a.locale = w, a.invalid = l, a.duration = Ya, a.isMoment = o, a.weekdays = lc, a.parseZone = $b, a.localeData = y, a.isDuration = Ia, a.monthsShort = kc, a.weekdaysMin = nc, a.defineLocale = x, a.weekdaysShort = mc, a.normalizeUnits = A, a.relativeTimeThreshold = Ec; var oe = a; return oe
});
/*! version : 4.15.35
 =========================================================
 bootstrap-datetimejs
 https://github.com/Eonasdan/bootstrap-datetimepicker
 Copyright (c) 2015 Jonathan Peterson
 =========================================================
 */
/*
 The MIT License (MIT)

 Copyright (c) 2015 Jonathan Peterson

 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.
 */
/*global define:false */
/*global exports:false */
/*global require:false */
/*global jQuery:false */
/*global moment:false */
(function (factory) {
    'use strict';
    if (typeof define === 'function' && define.amd) {
        // AMD is used - Register as an anonymous module.
        define(['jquery', 'moment'], factory);
    } else if (typeof exports === 'object') {
        factory(require('jquery'), require('moment'));
    } else {
        // Neither AMD nor CommonJS used. Use global variables.
        if (typeof jQuery === 'undefined') {
            throw 'bootstrap-datetimepicker requires jQuery to be loaded first';
        }
        if (typeof moment === 'undefined') {
            throw 'bootstrap-datetimepicker requires Moment.js to be loaded first';
        }
        factory(jQuery, moment);
    }
}(function ($, moment) {
    'use strict';
    if (!moment) {
        throw new Error('bootstrap-datetimepicker requires Moment.js to be loaded first');
    }

    var dateTimePicker = function (element, options) {
        var picker = {},
            date = moment().startOf('d'),
            viewDate = date.clone(),
            unset = true,
            input,
            component = false,
            widget = false,
            use24Hours,
            minViewModeNumber = 0,
            actualFormat,
            parseFormats,
            currentViewMode,
            datePickerModes = [
                {
                    clsName: 'days',
                    navFnc: 'M',
                    navStep: 1
                },
                {
                    clsName: 'months',
                    navFnc: 'y',
                    navStep: 1
                },
                {
                    clsName: 'years',
                    navFnc: 'y',
                    navStep: 10
                },
                {
                    clsName: 'decades',
                    navFnc: 'y',
                    navStep: 100
                }
            ],
            viewModes = ['days', 'months', 'years', 'decades'],
            verticalModes = ['top', 'bottom', 'auto'],
            horizontalModes = ['left', 'right', 'auto'],
            toolbarPlacements = ['default', 'top', 'bottom'],
            keyMap = {
                'up': 38,
                38: 'up',
                'down': 40,
                40: 'down',
                'left': 37,
                37: 'left',
                'right': 39,
                39: 'right',
                'tab': 9,
                9: 'tab',
                'escape': 27,
                27: 'escape',
                'enter': 13,
                13: 'enter',
                'pageUp': 33,
                33: 'pageUp',
                'pageDown': 34,
                34: 'pageDown',
                'shift': 16,
                16: 'shift',
                'control': 17,
                17: 'control',
                'space': 32,
                32: 'space',
                't': 84,
                84: 't',
                'delete': 46,
                46: 'delete'
            },
            keyState = {},

            /********************************************************************************
             *
             * Private functions
             *
             ********************************************************************************/
            isEnabled = function (granularity) {
                if (typeof granularity !== 'string' || granularity.length > 1) {
                    throw new TypeError('isEnabled expects a single character string parameter');
                }
                switch (granularity) {
                    case 'y':
                        return actualFormat.indexOf('Y') !== -1;
                    case 'M':
                        return actualFormat.indexOf('M') !== -1;
                    case 'd':
                        return actualFormat.toLowerCase().indexOf('d') !== -1;
                    case 'h':
                    case 'H':
                        return actualFormat.toLowerCase().indexOf('h') !== -1;
                    case 'm':
                        return actualFormat.indexOf('m') !== -1;
                    case 's':
                        return actualFormat.indexOf('s') !== -1;
                    default:
                        return false;
                }
            },
            hasTime = function () {
                return (isEnabled('h') || isEnabled('m') || isEnabled('s'));
            },

            hasDate = function () {
                return (isEnabled('y') || isEnabled('M') || isEnabled('d'));
            },

            getDatePickerTemplate = function () {
                var headTemplate = $('<thead>')
                        .append($('<tr>')
                            .append($('<th>').addClass('prev').attr('data-action', 'previous')
                                .append($('<span>').addClass(options.icons.previous))
                                )
                            .append($('<th>').addClass('picker-switch').attr('data-action', 'pickerSwitch').attr('colspan', (options.calendarWeeks ? '6' : '5')))
                            .append($('<th>').addClass('next').attr('data-action', 'next')
                                .append($('<span>').addClass(options.icons.next))
                                )
                            ),
                    contTemplate = $('<tbody>')
                        .append($('<tr>')
                            .append($('<td>').attr('colspan', (options.calendarWeeks ? '8' : '7')))
                            );

                return [
                    $('<div>').addClass('datepicker-days')
                        .append($('<table>').addClass('table-condensed')
                            .append(headTemplate)
                            .append($('<tbody>'))
                            ),
                    $('<div>').addClass('datepicker-months')
                        .append($('<table>').addClass('table-condensed')
                            .append(headTemplate.clone())
                            .append(contTemplate.clone())
                            ),
                    $('<div>').addClass('datepicker-years')
                        .append($('<table>').addClass('table-condensed')
                            .append(headTemplate.clone())
                            .append(contTemplate.clone())
                            ),
                    $('<div>').addClass('datepicker-decades')
                        .append($('<table>').addClass('table-condensed')
                            .append(headTemplate.clone())
                            .append(contTemplate.clone())
                            )
                ];
            },

            getTimePickerMainTemplate = function () {
                var topRow = $('<tr>'),
                    middleRow = $('<tr>'),
                    bottomRow = $('<tr>');

                if (isEnabled('h')) {
                    topRow.append($('<td>')
                        .append($('<a>').attr({ href: '#', tabindex: '-1', 'title': 'Increment Hour' }).addClass('btn').attr('data-action', 'incrementHours')
                            .append($('<span>').addClass(options.icons.up))));
                    middleRow.append($('<td>')
                        .append($('<span>').addClass('timepicker-hour').attr({ 'data-time-component': 'hours', 'title': 'Pick Hour' }).attr('data-action', 'showHours')));
                    bottomRow.append($('<td>')
                        .append($('<a>').attr({ href: '#', tabindex: '-1', 'title': 'Decrement Hour' }).addClass('btn').attr('data-action', 'decrementHours')
                            .append($('<span>').addClass(options.icons.down))));
                }
                if (isEnabled('m')) {
                    if (isEnabled('h')) {
                        topRow.append($('<td>').addClass('separator'));
                        middleRow.append($('<td>').addClass('separator').html(':'));
                        bottomRow.append($('<td>').addClass('separator'));
                    }
                    topRow.append($('<td>')
                        .append($('<a>').attr({ href: '#', tabindex: '-1', 'title': 'Increment Minute' }).addClass('btn').attr('data-action', 'incrementMinutes')
                            .append($('<span>').addClass(options.icons.up))));
                    middleRow.append($('<td>')
                        .append($('<span>').addClass('timepicker-minute').attr({ 'data-time-component': 'minutes', 'title': 'Pick Minute' }).attr('data-action', 'showMinutes')));
                    bottomRow.append($('<td>')
                        .append($('<a>').attr({ href: '#', tabindex: '-1', 'title': 'Decrement Minute' }).addClass('btn').attr('data-action', 'decrementMinutes')
                            .append($('<span>').addClass(options.icons.down))));
                }
                if (isEnabled('s')) {
                    if (isEnabled('m')) {
                        topRow.append($('<td>').addClass('separator'));
                        middleRow.append($('<td>').addClass('separator').html(':'));
                        bottomRow.append($('<td>').addClass('separator'));
                    }
                    topRow.append($('<td>')
                        .append($('<a>').attr({ href: '#', tabindex: '-1', 'title': 'Increment Second' }).addClass('btn').attr('data-action', 'incrementSeconds')
                            .append($('<span>').addClass(options.icons.up))));
                    middleRow.append($('<td>')
                        .append($('<span>').addClass('timepicker-second').attr({ 'data-time-component': 'seconds', 'title': 'Pick Second' }).attr('data-action', 'showSeconds')));
                    bottomRow.append($('<td>')
                        .append($('<a>').attr({ href: '#', tabindex: '-1', 'title': 'Decrement Second' }).addClass('btn').attr('data-action', 'decrementSeconds')
                            .append($('<span>').addClass(options.icons.down))));
                }

                if (!use24Hours) {
                    topRow.append($('<td>').addClass('separator'));
                    middleRow.append($('<td>')
                        .append($('<button>').addClass('btn btn-primary').attr({ 'data-action': 'togglePeriod', tabindex: '-1', 'title': 'Toggle Period' })));
                    bottomRow.append($('<td>').addClass('separator'));
                }

                return $('<div>').addClass('timepicker-picker')
                    .append($('<table>').addClass('table-condensed')
                        .append([topRow, middleRow, bottomRow]));
            },

            getTimePickerTemplate = function () {
                var hoursView = $('<div>').addClass('timepicker-hours')
                        .append($('<table>').addClass('table-condensed')),
                    minutesView = $('<div>').addClass('timepicker-minutes')
                        .append($('<table>').addClass('table-condensed')),
                    secondsView = $('<div>').addClass('timepicker-seconds')
                        .append($('<table>').addClass('table-condensed')),
                    ret = [getTimePickerMainTemplate()];

                if (isEnabled('h')) {
                    ret.push(hoursView);
                }
                if (isEnabled('m')) {
                    ret.push(minutesView);
                }
                if (isEnabled('s')) {
                    ret.push(secondsView);
                }

                return ret;
            },

            getToolbar = function () {
                var row = [];
                if (options.showTodayButton) {
                    row.push($('<td>').append($('<a>').attr({ 'data-action': 'today', 'title': options.tooltips.today }).append($('<span>').addClass(options.icons.today))));
                }
                if (!options.sideBySide && hasDate() && hasTime()) {
                    row.push($('<td>').append($('<a>').attr({ 'data-action': 'togglePicker', 'title': 'Select Time' }).append($('<span>').addClass(options.icons.time))));
                }
                if (options.showClear) {
                    row.push($('<td>').append($('<a>').attr({ 'data-action': 'clear', 'title': options.tooltips.clear }).append($('<span>').addClass(options.icons.clear))));
                }
                if (options.showClose) {
                    row.push($('<td>').append($('<a>').attr({ 'data-action': 'close', 'title': options.tooltips.close }).append($('<span>').addClass(options.icons.close))));
                }
                return $('<table>').addClass('table-condensed').append($('<tbody>').append($('<tr>').append(row)));
            },

            getTemplate = function () {
                var template = $('<div>').addClass('bootstrap-datetimepicker-widget dropdown-menu'),
                    dateView = $('<div>').addClass('datepicker').append(getDatePickerTemplate()),
                    timeView = $('<div>').addClass('timepicker').append(getTimePickerTemplate()),
                    content = $('<ul>').addClass('list-unstyled'),
                    toolbar = $('<li>').addClass('picker-switch' + (options.collapse ? ' accordion-toggle' : '')).append(getToolbar());

                if (options.inline) {
                    template.removeClass('dropdown-menu');
                }

                if (use24Hours) {
                    template.addClass('usetwentyfour');
                }
                if (isEnabled('s') && !use24Hours) {
                    template.addClass('wider');
                }

                if (options.sideBySide && hasDate() && hasTime()) {
                    template.addClass('timepicker-sbs');
                    if (options.toolbarPlacement === 'top') {
                        template.append(toolbar);
                    }
                    template.append(
                        $('<div>').addClass('row')
                            .append(dateView.addClass('col-md-6'))
                            .append(timeView.addClass('col-md-6'))
                    );
                    if (options.toolbarPlacement === 'bottom') {
                        template.append(toolbar);
                    }
                    return template;
                }

                if (options.toolbarPlacement === 'top') {
                    content.append(toolbar);
                }
                if (hasDate()) {
                    content.append($('<li>').addClass((options.collapse && hasTime() ? 'collapse in' : '')).append(dateView));
                }
                if (options.toolbarPlacement === 'default') {
                    content.append(toolbar);
                }
                if (hasTime()) {
                    content.append($('<li>').addClass((options.collapse && hasDate() ? 'collapse' : '')).append(timeView));
                }
                if (options.toolbarPlacement === 'bottom') {
                    content.append(toolbar);
                }
                return template.append(content);
            },

            dataToOptions = function () {
                var eData,
                    dataOptions = {};

                if (element.is('input') || options.inline) {
                    eData = element.data();
                } else {
                    eData = element.find('input').data();
                }

                if (eData.dateOptions && eData.dateOptions instanceof Object) {
                    dataOptions = $.extend(true, dataOptions, eData.dateOptions);
                }

                $.each(options, function (key) {
                    var attributeName = 'date' + key.charAt(0).toUpperCase() + key.slice(1);
                    if (eData[attributeName] !== undefined) {
                        dataOptions[key] = eData[attributeName];
                    }
                });
                return dataOptions;
            },

            place = function () {
                var position = (component || element).position(),
                    offset = (component || element).offset(),
                    vertical = options.widgetPositioning.vertical,
                    horizontal = options.widgetPositioning.horizontal,
                    parent;

                if (options.widgetParent) {
                    parent = options.widgetParent.append(widget);
                } else if (element.is('input')) {
                    parent = element.after(widget).parent();
                } else if (options.inline) {
                    parent = element.append(widget);
                    return;
                } else {
                    parent = element;
                    element.children().first().after(widget);
                }

                // Top and bottom logic
                if (vertical === 'auto') {
                    if (offset.top + widget.height() * 1.5 >= $(window).height() + $(window).scrollTop() &&
                        widget.height() + element.outerHeight() < offset.top) {
                        vertical = 'top';
                    } else {
                        vertical = 'bottom';
                    }
                }

                // Left and right logic
                if (horizontal === 'auto') {
                    if (parent.width() < offset.left + widget.outerWidth() / 2 &&
                        offset.left + widget.outerWidth() > $(window).width()) {
                        horizontal = 'right';
                    } else {
                        horizontal = 'left';
                    }
                }

                if (vertical === 'top') {
                    widget.addClass('top').removeClass('bottom');
                } else {
                    widget.addClass('bottom').removeClass('top');
                }

                if (horizontal === 'right') {
                    widget.addClass('pull-right');
                } else {
                    widget.removeClass('pull-right');
                }

                // find the first parent element that has a relative css positioning
                if (parent.css('position') !== 'relative') {
                    parent = parent.parents().filter(function () {
                        return $(this).css('position') === 'relative';
                    }).first();
                }

                if (parent.length === 0) {
                    throw new Error('datetimepicker component should be placed within a relative positioned container');
                }

                widget.css({
                    top: vertical === 'top' ? 'auto' : position.top + element.outerHeight(),
                    bottom: vertical === 'top' ? position.top + element.outerHeight() : 'auto',
                    left: horizontal === 'left' ? (parent === element ? 0 : position.left) : 'auto',
                    right: horizontal === 'left' ? 'auto' : parent.outerWidth() - element.outerWidth() - (parent === element ? 0 : position.left)
                });
            },

            notifyEvent = function (e) {
                if (e.type === 'dp.change' && ((e.date && e.date.isSame(e.oldDate)) || (!e.date && !e.oldDate))) {
                    return;
                }
                element.trigger(e);
            },

            viewUpdate = function (e) {
                if (e === 'y') {
                    e = 'YYYY';
                }
                notifyEvent({
                    type: 'dp.update',
                    change: e,
                    viewDate: viewDate.clone()
                });
            },

            showMode = function (dir) {
                if (!widget) {
                    return;
                }
                if (dir) {
                    currentViewMode = Math.max(minViewModeNumber, Math.min(3, currentViewMode + dir));
                }
                widget.find('.datepicker > div').hide().filter('.datepicker-' + datePickerModes[currentViewMode].clsName).show();
            },

            fillDow = function () {
                var row = $('<tr>'),
                    currentDate = viewDate.clone().startOf('w').startOf('d');

                if (options.calendarWeeks === true) {
                    row.append($('<th>').addClass('cw').text('#'));
                }

                while (currentDate.isBefore(viewDate.clone().endOf('w'))) {
                    row.append($('<th>').addClass('dow').text(currentDate.format('dd')));
                    currentDate.add(1, 'd');
                }
                widget.find('.datepicker-days thead').append(row);
            },

            isInDisabledDates = function (testDate) {
                return options.disabledDates[testDate.format('YYYY-MM-DD')] === true;
            },

            isInEnabledDates = function (testDate) {
                return options.enabledDates[testDate.format('YYYY-MM-DD')] === true;
            },

            isInDisabledHours = function (testDate) {
                return options.disabledHours[testDate.format('H')] === true;
            },

            isInEnabledHours = function (testDate) {
                return options.enabledHours[testDate.format('H')] === true;
            },

            isValid = function (targetMoment, granularity) {
                if (!targetMoment.isValid()) {
                    return false;
                }
                if (options.disabledDates && granularity === 'd' && isInDisabledDates(targetMoment)) {
                    return false;
                }
                if (options.enabledDates && granularity === 'd' && !isInEnabledDates(targetMoment)) {
                    return false;
                }
                if (options.minDate && targetMoment.isBefore(options.minDate, granularity)) {
                    return false;
                }
                if (options.maxDate && targetMoment.isAfter(options.maxDate, granularity)) {
                    return false;
                }
                if (options.daysOfWeekDisabled && granularity === 'd' && options.daysOfWeekDisabled.indexOf(targetMoment.day()) !== -1) {
                    return false;
                }
                if (options.disabledHours && (granularity === 'h' || granularity === 'm' || granularity === 's') && isInDisabledHours(targetMoment)) {
                    return false;
                }
                if (options.enabledHours && (granularity === 'h' || granularity === 'm' || granularity === 's') && !isInEnabledHours(targetMoment)) {
                    return false;
                }
                if (options.disabledTimeIntervals && (granularity === 'h' || granularity === 'm' || granularity === 's')) {
                    var found = false;
                    $.each(options.disabledTimeIntervals, function () {
                        if (targetMoment.isBetween(this[0], this[1])) {
                            found = true;
                            return false;
                        }
                    });
                    if (found) {
                        return false;
                    }
                }
                return true;
            },

            fillMonths = function () {
                var spans = [],
                    monthsShort = viewDate.clone().startOf('y').startOf('d');
                while (monthsShort.isSame(viewDate, 'y')) {
                    spans.push($('<span>').attr('data-action', 'selectMonth').addClass('month').text(monthsShort.format('MMM')));
                    monthsShort.add(1, 'M');
                }
                widget.find('.datepicker-months td').empty().append(spans);
            },

            updateMonths = function () {
                var monthsView = widget.find('.datepicker-months'),
                    monthsViewHeader = monthsView.find('th'),
                    months = monthsView.find('tbody').find('span');

                monthsViewHeader.eq(0).find('span').attr('title', options.tooltips.prevYear);
                monthsViewHeader.eq(1).attr('title', options.tooltips.selectYear);
                monthsViewHeader.eq(2).find('span').attr('title', options.tooltips.nextYear);

                monthsView.find('.disabled').removeClass('disabled');

                if (!isValid(viewDate.clone().subtract(1, 'y'), 'y')) {
                    monthsViewHeader.eq(0).addClass('disabled');
                }

                monthsViewHeader.eq(1).text(viewDate.year());

                if (!isValid(viewDate.clone().add(1, 'y'), 'y')) {
                    monthsViewHeader.eq(2).addClass('disabled');
                }

                months.removeClass('active');
                if (date.isSame(viewDate, 'y') && !unset) {
                    months.eq(date.month()).addClass('active');
                }

                months.each(function (index) {
                    if (!isValid(viewDate.clone().month(index), 'M')) {
                        $(this).addClass('disabled');
                    }
                });
            },

            updateYears = function () {
                var yearsView = widget.find('.datepicker-years'),
                    yearsViewHeader = yearsView.find('th'),
                    startYear = viewDate.clone().subtract(5, 'y'),
                    endYear = viewDate.clone().add(6, 'y'),
                    html = '';

                yearsViewHeader.eq(0).find('span').attr('title', options.tooltips.nextDecade);
                yearsViewHeader.eq(1).attr('title', options.tooltips.selectDecade);
                yearsViewHeader.eq(2).find('span').attr('title', options.tooltips.prevDecade);

                yearsView.find('.disabled').removeClass('disabled');

                if (options.minDate && options.minDate.isAfter(startYear, 'y')) {
                    yearsViewHeader.eq(0).addClass('disabled');
                }

                yearsViewHeader.eq(1).text(startYear.year() + '-' + endYear.year());

                if (options.maxDate && options.maxDate.isBefore(endYear, 'y')) {
                    yearsViewHeader.eq(2).addClass('disabled');
                }

                while (!startYear.isAfter(endYear, 'y')) {
                    html += '<span data-action="selectYear" class="year' + (startYear.isSame(date, 'y') && !unset ? ' active' : '') + (!isValid(startYear, 'y') ? ' disabled' : '') + '">' + startYear.year() + '</span>';
                    startYear.add(1, 'y');
                }

                yearsView.find('td').html(html);
            },

            updateDecades = function () {
                var decadesView = widget.find('.datepicker-decades'),
                    decadesViewHeader = decadesView.find('th'),
                    startDecade = viewDate.isBefore(moment({ y: 1999 })) ? moment({ y: 1899 }) : moment({ y: 1999 }),
                    endDecade = startDecade.clone().add(100, 'y'),
                    html = '';

                decadesViewHeader.eq(0).find('span').attr('title', options.tooltips.prevCentury);
                decadesViewHeader.eq(2).find('span').attr('title', options.tooltips.nextCentury);

                decadesView.find('.disabled').removeClass('disabled');

                if (startDecade.isSame(moment({ y: 1900 })) || (options.minDate && options.minDate.isAfter(startDecade, 'y'))) {
                    decadesViewHeader.eq(0).addClass('disabled');
                }

                decadesViewHeader.eq(1).text(startDecade.year() + '-' + endDecade.year());

                if (startDecade.isSame(moment({ y: 2000 })) || (options.maxDate && options.maxDate.isBefore(endDecade, 'y'))) {
                    decadesViewHeader.eq(2).addClass('disabled');
                }

                while (!startDecade.isAfter(endDecade, 'y')) {
                    html += '<span data-action="selectDecade" class="decade' + (startDecade.isSame(date, 'y') ? ' active' : '') +
                        (!isValid(startDecade, 'y') ? ' disabled' : '') + '" data-selection="' + (startDecade.year() + 6) + '">' + (startDecade.year() + 1) + ' - ' + (startDecade.year() + 12) + '</span>';
                    startDecade.add(12, 'y');
                }
                html += '<span></span><span></span><span></span>'; //push the dangling block over, at least this way it's even

                decadesView.find('td').html(html);
            },

            fillDate = function () {
                var daysView = widget.find('.datepicker-days'),
                    daysViewHeader = daysView.find('th'),
                    currentDate,
                    html = [],
                    row,
                    clsName,
                    i;

                if (!hasDate()) {
                    return;
                }

                daysViewHeader.eq(0).find('span').attr('title', options.tooltips.prevMonth);
                daysViewHeader.eq(1).attr('title', options.tooltips.selectMonth);
                daysViewHeader.eq(2).find('span').attr('title', options.tooltips.nextMonth);

                daysView.find('.disabled').removeClass('disabled');
                daysViewHeader.eq(1).text(viewDate.format(options.dayViewHeaderFormat));

                if (!isValid(viewDate.clone().subtract(1, 'M'), 'M')) {
                    daysViewHeader.eq(0).addClass('disabled');
                }
                if (!isValid(viewDate.clone().add(1, 'M'), 'M')) {
                    daysViewHeader.eq(2).addClass('disabled');
                }

                currentDate = viewDate.clone().startOf('M').startOf('w').startOf('d');

                for (i = 0; i < 42; i++) { //always display 42 days (should show 6 weeks)
                    if (currentDate.weekday() === 0) {
                        row = $('<tr>');
                        if (options.calendarWeeks) {
                            row.append('<td class="cw">' + currentDate.week() + '</td>');
                        }
                        html.push(row);
                    }
                    clsName = '';
                    if (currentDate.isBefore(viewDate, 'M')) {
                        clsName += ' old';
                    }
                    if (currentDate.isAfter(viewDate, 'M')) {
                        clsName += ' new';
                    }
                    if (currentDate.isSame(date, 'd') && !unset) {
                        clsName += ' active';
                    }
                    if (!isValid(currentDate, 'd')) {
                        clsName += ' disabled';
                    }
                    if (currentDate.isSame(moment(), 'd')) {
                        clsName += ' today';
                    }
                    if (currentDate.day() === 0 || currentDate.day() === 6) {
                        clsName += ' weekend';
                    }
                    row.append('<td data-action="selectDay" data-day="' + currentDate.format('L') + '" class="day' + clsName + '">' + currentDate.date() + '</td>');
                    currentDate.add(1, 'd');
                }

                daysView.find('tbody').empty().append(html);

                updateMonths();

                updateYears();

                updateDecades();
            },

            fillHours = function () {
                var table = widget.find('.timepicker-hours table'),
                    currentHour = viewDate.clone().startOf('d'),
                    html = [],
                    row = $('<tr>');

                if (viewDate.hour() > 11 && !use24Hours) {
                    currentHour.hour(12);
                }
                while (currentHour.isSame(viewDate, 'd') && (use24Hours || (viewDate.hour() < 12 && currentHour.hour() < 12) || viewDate.hour() > 11)) {
                    if (currentHour.hour() % 4 === 0) {
                        row = $('<tr>');
                        html.push(row);
                    }
                    row.append('<td data-action="selectHour" class="hour' + (!isValid(currentHour, 'h') ? ' disabled' : '') + '">' + currentHour.format(use24Hours ? 'HH' : 'hh') + '</td>');
                    currentHour.add(1, 'h');
                }
                table.empty().append(html);
            },

            fillMinutes = function () {
                var table = widget.find('.timepicker-minutes table'),
                    currentMinute = viewDate.clone().startOf('h'),
                    html = [],
                    row = $('<tr>'),
                    step = options.stepping === 1 ? 5 : options.stepping;

                while (viewDate.isSame(currentMinute, 'h')) {
                    if (currentMinute.minute() % (step * 4) === 0) {
                        row = $('<tr>');
                        html.push(row);
                    }
                    row.append('<td data-action="selectMinute" class="minute' + (!isValid(currentMinute, 'm') ? ' disabled' : '') + '">' + currentMinute.format('mm') + '</td>');
                    currentMinute.add(step, 'm');
                }
                table.empty().append(html);
            },

            fillSeconds = function () {
                var table = widget.find('.timepicker-seconds table'),
                    currentSecond = viewDate.clone().startOf('m'),
                    html = [],
                    row = $('<tr>');

                while (viewDate.isSame(currentSecond, 'm')) {
                    if (currentSecond.second() % 20 === 0) {
                        row = $('<tr>');
                        html.push(row);
                    }
                    row.append('<td data-action="selectSecond" class="second' + (!isValid(currentSecond, 's') ? ' disabled' : '') + '">' + currentSecond.format('ss') + '</td>');
                    currentSecond.add(5, 's');
                }

                table.empty().append(html);
            },

            fillTime = function () {
                var toggle, newDate, timeComponents = widget.find('.timepicker span[data-time-component]');

                if (!use24Hours) {
                    toggle = widget.find('.timepicker [data-action=togglePeriod]');
                    newDate = date.clone().add((date.hours() >= 12) ? -12 : 12, 'h');

                    toggle.text(date.format('A'));

                    if (isValid(newDate, 'h')) {
                        toggle.removeClass('disabled');
                    } else {
                        toggle.addClass('disabled');
                    }
                }
                timeComponents.filter('[data-time-component=hours]').text(date.format(use24Hours ? 'HH' : 'hh'));
                timeComponents.filter('[data-time-component=minutes]').text(date.format('mm'));
                timeComponents.filter('[data-time-component=seconds]').text(date.format('ss'));

                fillHours();
                fillMinutes();
                fillSeconds();
            },

            update = function () {
                if (!widget) {
                    return;
                }
                fillDate();
                fillTime();
            },

            setValue = function (targetMoment) {
                var oldDate = unset ? null : date;

                // case of calling setValue(null or false)
                if (!targetMoment) {
                    unset = true;
                    input.val('');
                    element.data('date', '');
                    notifyEvent({
                        type: 'dp.change',
                        date: false,
                        oldDate: oldDate
                    });
                    update();
                    return;
                }

                targetMoment = targetMoment.clone().locale(options.locale);

                if (options.stepping !== 1) {
                    targetMoment.minutes((Math.round(targetMoment.minutes() / options.stepping) * options.stepping) % 60).seconds(0);
                }

                if (isValid(targetMoment)) {
                    date = targetMoment;
                    viewDate = date.clone();
                    input.val(date.format(actualFormat));
                    element.data('date', date.format(actualFormat));
                    unset = false;
                    update();
                    notifyEvent({
                        type: 'dp.change',
                        date: date.clone(),
                        oldDate: oldDate
                    });
                } else {
                    if (!options.keepInvalid) {
                        input.val(unset ? '' : date.format(actualFormat));
                    }
                    notifyEvent({
                        type: 'dp.error',
                        date: targetMoment
                    });
                }
            },

            hide = function () {
                ///<summary>Hides the widget. Possibly will emit dp.hide</summary>
                var transitioning = false;
                if (!widget) {
                    return picker;
                }
                // Ignore event if in the middle of a picker transition
                widget.find('.collapse').each(function () {
                    var collapseData = $(this).data('collapse');
                    if (collapseData && collapseData.transitioning) {
                        transitioning = true;
                        return false;
                    }
                    return true;
                });
                if (transitioning) {
                    return picker;
                }
                if (component && component.hasClass('btn')) {
                    component.toggleClass('active');
                }
                widget.hide();

                $(window).off('resize', place);
                widget.off('click', '[data-action]');
                widget.off('mousedown', false);

                widget.remove();
                widget = false;

                notifyEvent({
                    type: 'dp.hide',
                    date: date.clone()
                });

                input.blur();

                return picker;
            },

            clear = function () {
                setValue(null);
            },

            /********************************************************************************
             *
             * Widget UI interaction functions
             *
             ********************************************************************************/
            actions = {
                next: function () {
                    var navFnc = datePickerModes[currentViewMode].navFnc;
                    viewDate.add(datePickerModes[currentViewMode].navStep, navFnc);
                    fillDate();
                    viewUpdate(navFnc);
                },

                previous: function () {
                    var navFnc = datePickerModes[currentViewMode].navFnc;
                    viewDate.subtract(datePickerModes[currentViewMode].navStep, navFnc);
                    fillDate();
                    viewUpdate(navFnc);
                },

                pickerSwitch: function () {
                    showMode(1);
                },

                selectMonth: function (e) {
                    var month = $(e.target).closest('tbody').find('span').index($(e.target));
                    viewDate.month(month);
                    if (currentViewMode === minViewModeNumber) {
                        setValue(date.clone().year(viewDate.year()).month(viewDate.month()));
                        if (!options.inline) {
                            hide();
                        }
                    } else {
                        showMode(-1);
                        fillDate();
                    }
                    viewUpdate('M');
                },

                selectYear: function (e) {
                    var year = parseInt($(e.target).text(), 10) || 0;
                    viewDate.year(year);
                    if (currentViewMode === minViewModeNumber) {
                        setValue(date.clone().year(viewDate.year()));
                        if (!options.inline) {
                            hide();
                        }
                    } else {
                        showMode(-1);
                        fillDate();
                    }
                    viewUpdate('YYYY');
                },

                selectDecade: function (e) {
                    var year = parseInt($(e.target).data('selection'), 10) || 0;
                    viewDate.year(year);
                    if (currentViewMode === minViewModeNumber) {
                        setValue(date.clone().year(viewDate.year()));
                        if (!options.inline) {
                            hide();
                        }
                    } else {
                        showMode(-1);
                        fillDate();
                    }
                    viewUpdate('YYYY');
                },

                selectDay: function (e) {
                    var day = viewDate.clone();
                    if ($(e.target).is('.old')) {
                        day.subtract(1, 'M');
                    }
                    if ($(e.target).is('.new')) {
                        day.add(1, 'M');
                    }
                    setValue(day.date(parseInt($(e.target).text(), 10)));
                    if (!hasTime() && !options.keepOpen && !options.inline) {
                        hide();
                    }
                },

                incrementHours: function () {
                    var newDate = date.clone().add(1, 'h');
                    if (isValid(newDate, 'h')) {
                        setValue(newDate);
                    }
                },

                incrementMinutes: function () {
                    var newDate = date.clone().add(options.stepping, 'm');
                    if (isValid(newDate, 'm')) {
                        setValue(newDate);
                    }
                },

                incrementSeconds: function () {
                    var newDate = date.clone().add(1, 's');
                    if (isValid(newDate, 's')) {
                        setValue(newDate);
                    }
                },

                decrementHours: function () {
                    var newDate = date.clone().subtract(1, 'h');
                    if (isValid(newDate, 'h')) {
                        setValue(newDate);
                    }
                },

                decrementMinutes: function () {
                    var newDate = date.clone().subtract(options.stepping, 'm');
                    if (isValid(newDate, 'm')) {
                        setValue(newDate);
                    }
                },

                decrementSeconds: function () {
                    var newDate = date.clone().subtract(1, 's');
                    if (isValid(newDate, 's')) {
                        setValue(newDate);
                    }
                },

                togglePeriod: function () {
                    setValue(date.clone().add((date.hours() >= 12) ? -12 : 12, 'h'));
                },

                togglePicker: function (e) {
                    var $this = $(e.target),
                        $parent = $this.closest('ul'),
                        expanded = $parent.find('.in'),
                        closed = $parent.find('.collapse:not(.in)'),
                        collapseData;

                    if (expanded && expanded.length) {
                        collapseData = expanded.data('collapse');
                        if (collapseData && collapseData.transitioning) {
                            return;
                        }
                        if (expanded.collapse) { // if collapse plugin is available through bootstrap.js then use it
                            expanded.collapse('hide');
                            closed.collapse('show');
                        } else { // otherwise just toggle in class on the two views
                            expanded.removeClass('in');
                            closed.addClass('in');
                        }
                        if ($this.is('span')) {
                            $this.toggleClass(options.icons.time + ' ' + options.icons.date);
                        } else {
                            $this.find('span').toggleClass(options.icons.time + ' ' + options.icons.date);
                        }

                        // NOTE: uncomment if toggled state will be restored in show()
                        //if (component) {
                        //    component.find('span').toggleClass(options.icons.time + ' ' + options.icons.date);
                        //}
                    }
                },

                showPicker: function () {
                    widget.find('.timepicker > div:not(.timepicker-picker)').hide();
                    widget.find('.timepicker .timepicker-picker').show();
                },

                showHours: function () {
                    widget.find('.timepicker .timepicker-picker').hide();
                    widget.find('.timepicker .timepicker-hours').show();
                },

                showMinutes: function () {
                    widget.find('.timepicker .timepicker-picker').hide();
                    widget.find('.timepicker .timepicker-minutes').show();
                },

                showSeconds: function () {
                    widget.find('.timepicker .timepicker-picker').hide();
                    widget.find('.timepicker .timepicker-seconds').show();
                },

                selectHour: function (e) {
                    var hour = parseInt($(e.target).text(), 10);

                    if (!use24Hours) {
                        if (date.hours() >= 12) {
                            if (hour !== 12) {
                                hour += 12;
                            }
                        } else {
                            if (hour === 12) {
                                hour = 0;
                            }
                        }
                    }
                    setValue(date.clone().hours(hour));
                    actions.showPicker.call(picker);
                },

                selectMinute: function (e) {
                    setValue(date.clone().minutes(parseInt($(e.target).text(), 10)));
                    actions.showPicker.call(picker);
                },

                selectSecond: function (e) {
                    setValue(date.clone().seconds(parseInt($(e.target).text(), 10)));
                    actions.showPicker.call(picker);
                },

                clear: clear,

                today: function () {
                    if (isValid(moment(), 'd')) {
                        setValue(moment());
                    }
                },

                close: hide
            },

            doAction = function (e) {
                if ($(e.currentTarget).is('.disabled')) {
                    return false;
                }
                actions[$(e.currentTarget).data('action')].apply(picker, arguments);
                return false;
            },

            show = function () {
                ///<summary>Shows the widget. Possibly will emit dp.show and dp.change</summary>
                var currentMoment,
                    useCurrentGranularity = {
                        'year': function (m) {
                            return m.month(0).date(1).hours(0).seconds(0).minutes(0);
                        },
                        'month': function (m) {
                            return m.date(1).hours(0).seconds(0).minutes(0);
                        },
                        'day': function (m) {
                            return m.hours(0).seconds(0).minutes(0);
                        },
                        'hour': function (m) {
                            return m.seconds(0).minutes(0);
                        },
                        'minute': function (m) {
                            return m.seconds(0);
                        }
                    };

                if (input.prop('disabled') || (!options.ignoreReadonly && input.prop('readonly')) || widget) {
                    return picker;
                }
                if (input.val() !== undefined && input.val().trim().length !== 0) {
                    setValue(parseInputDate(input.val().trim()));
                } else if (options.useCurrent && unset && ((input.is('input') && input.val().trim().length === 0) || options.inline)) {
                    currentMoment = moment();
                    if (typeof options.useCurrent === 'string') {
                        currentMoment = useCurrentGranularity[options.useCurrent](currentMoment);
                    }
                    setValue(currentMoment);
                }

                widget = getTemplate();

                fillDow();
                fillMonths();

                widget.find('.timepicker-hours').hide();
                widget.find('.timepicker-minutes').hide();
                widget.find('.timepicker-seconds').hide();

                update();
                showMode();

                $(window).on('resize', place);
                widget.on('click', '[data-action]', doAction); // this handles clicks on the widget
                widget.on('mousedown', false);

                if (component && component.hasClass('btn')) {
                    component.toggleClass('active');
                }
                widget.show();
                place();

                if (options.focusOnShow && !input.is(':focus')) {
                    input.focus();
                }

                notifyEvent({
                    type: 'dp.show'
                });
                return picker;
            },

            toggle = function () {
                /// <summary>Shows or hides the widget</summary>
                return (widget ? hide() : show());
            },

            parseInputDate = function (inputDate) {
                if (options.parseInputDate === undefined) {
                    if (moment.isMoment(inputDate) || inputDate instanceof Date) {
                        inputDate = moment(inputDate);
                    } else {
                        inputDate = moment(inputDate, parseFormats, options.useStrict);
                    }
                } else {
                    inputDate = options.parseInputDate(inputDate);
                }
                inputDate.locale(options.locale);
                return inputDate;
            },

            keydown = function (e) {
                var handler = null,
                    index,
                    index2,
                    pressedKeys = [],
                    pressedModifiers = {},
                    currentKey = e.which,
                    keyBindKeys,
                    allModifiersPressed,
                    pressed = 'p';

                keyState[currentKey] = pressed;

                for (index in keyState) {
                    if (keyState.hasOwnProperty(index) && keyState[index] === pressed) {
                        pressedKeys.push(index);
                        if (parseInt(index, 10) !== currentKey) {
                            pressedModifiers[index] = true;
                        }
                    }
                }

                for (index in options.keyBinds) {
                    if (options.keyBinds.hasOwnProperty(index) && typeof (options.keyBinds[index]) === 'function') {
                        keyBindKeys = index.split(' ');
                        if (keyBindKeys.length === pressedKeys.length && keyMap[currentKey] === keyBindKeys[keyBindKeys.length - 1]) {
                            allModifiersPressed = true;
                            for (index2 = keyBindKeys.length - 2; index2 >= 0; index2--) {
                                if (!(keyMap[keyBindKeys[index2]] in pressedModifiers)) {
                                    allModifiersPressed = false;
                                    break;
                                }
                            }
                            if (allModifiersPressed) {
                                handler = options.keyBinds[index];
                                break;
                            }
                        }
                    }
                }

                if (handler) {
                    handler.call(picker, widget);
                    e.stopPropagation();
                    e.preventDefault();
                }
            },

            keyup = function (e) {
                keyState[e.which] = 'r';
                e.stopPropagation();
                e.preventDefault();
            },

            change = function (e) {
                var val = $(e.target).val().trim(),
                    parsedDate = val ? parseInputDate(val) : null;
                setValue(parsedDate);
                e.stopImmediatePropagation();
                return false;
            },

            attachDatePickerElementEvents = function () {
                input.on({
                    'change': change,
                    'blur': options.debug ? '' : hide,
                    'keydown': keydown,
                    'keyup': keyup,
                    'focus': options.allowInputToggle ? show : ''
                });

                if (element.is('input')) {
                    input.on({
                        'focus': show
                    });
                } else if (component) {
                    component.on('click', toggle);
                    component.on('mousedown', false);
                }
            },

            detachDatePickerElementEvents = function () {
                input.off({
                    'change': change,
                    'blur': blur,
                    'keydown': keydown,
                    'keyup': keyup,
                    'focus': options.allowInputToggle ? hide : ''
                });

                if (element.is('input')) {
                    input.off({
                        'focus': show
                    });
                } else if (component) {
                    component.off('click', toggle);
                    component.off('mousedown', false);
                }
            },

            indexGivenDates = function (givenDatesArray) {
                // Store given enabledDates and disabledDates as keys.
                // This way we can check their existence in O(1) time instead of looping through whole array.
                // (for example: options.enabledDates['2014-02-27'] === true)
                var givenDatesIndexed = {};
                $.each(givenDatesArray, function () {
                    var dDate = parseInputDate(this);
                    if (dDate.isValid()) {
                        givenDatesIndexed[dDate.format('YYYY-MM-DD')] = true;
                    }
                });
                return (Object.keys(givenDatesIndexed).length) ? givenDatesIndexed : false;
            },

            indexGivenHours = function (givenHoursArray) {
                // Store given enabledHours and disabledHours as keys.
                // This way we can check their existence in O(1) time instead of looping through whole array.
                // (for example: options.enabledHours['2014-02-27'] === true)
                var givenHoursIndexed = {};
                $.each(givenHoursArray, function () {
                    givenHoursIndexed[this] = true;
                });
                return (Object.keys(givenHoursIndexed).length) ? givenHoursIndexed : false;
            },

            initFormatting = function () {
                var format = options.format || 'L LT';

                actualFormat = format.replace(/(\[[^\[]*\])|(\\)?(LTS|LT|LL?L?L?|l{1,4})/g, function (formatInput) {
                    var newinput = date.localeData().longDateFormat(formatInput) || formatInput;
                    return newinput.replace(/(\[[^\[]*\])|(\\)?(LTS|LT|LL?L?L?|l{1,4})/g, function (formatInput2) { //temp fix for #740
                        return date.localeData().longDateFormat(formatInput2) || formatInput2;
                    });
                });


                parseFormats = options.extraFormats ? options.extraFormats.slice() : [];
                if (parseFormats.indexOf(format) < 0 && parseFormats.indexOf(actualFormat) < 0) {
                    parseFormats.push(actualFormat);
                }

                use24Hours = (actualFormat.toLowerCase().indexOf('a') < 1 && actualFormat.replace(/\[.*?\]/g, '').indexOf('h') < 1);

                if (isEnabled('y')) {
                    minViewModeNumber = 2;
                }
                if (isEnabled('M')) {
                    minViewModeNumber = 1;
                }
                if (isEnabled('d')) {
                    minViewModeNumber = 0;
                }

                currentViewMode = Math.max(minViewModeNumber, currentViewMode);

                if (!unset) {
                    setValue(date);
                }
            };

        /********************************************************************************
         *
         * Public API functions
         * =====================
         *
         * Important: Do not expose direct references to private objects or the options
         * object to the outer world. Always return a clone when returning values or make
         * a clone when setting a private variable.
         *
         ********************************************************************************/
        picker.destroy = function () {
            ///<summary>Destroys the widget and removes all attached event listeners</summary>
            hide();
            detachDatePickerElementEvents();
            element.removeData('DateTimePicker');
            element.removeData('date');
        };

        picker.toggle = toggle;

        picker.show = show;

        picker.hide = hide;

        picker.disable = function () {
            ///<summary>Disables the input element, the component is attached to, by adding a disabled="true" attribute to it.
            ///If the widget was visible before that call it is hidden. Possibly emits dp.hide</summary>
            hide();
            if (component && component.hasClass('btn')) {
                component.addClass('disabled');
            }
            input.prop('disabled', true);
            return picker;
        };

        picker.enable = function () {
            ///<summary>Enables the input element, the component is attached to, by removing disabled attribute from it.</summary>
            if (component && component.hasClass('btn')) {
                component.removeClass('disabled');
            }
            input.prop('disabled', false);
            return picker;
        };

        picker.ignoreReadonly = function (ignoreReadonly) {
            if (arguments.length === 0) {
                return options.ignoreReadonly;
            }
            if (typeof ignoreReadonly !== 'boolean') {
                throw new TypeError('ignoreReadonly () expects a boolean parameter');
            }
            options.ignoreReadonly = ignoreReadonly;
            return picker;
        };

        picker.options = function (newOptions) {
            if (arguments.length === 0) {
                return $.extend(true, {}, options);
            }

            if (!(newOptions instanceof Object)) {
                throw new TypeError('options() options parameter should be an object');
            }
            $.extend(true, options, newOptions);
            $.each(options, function (key, value) {
                if (picker[key] !== undefined) {
                    picker[key](value);
                } else {
                    throw new TypeError('option ' + key + ' is not recognized!');
                }
            });
            return picker;
        };

        picker.date = function (newDate) {
            ///<signature helpKeyword="$.fn.datetimepicker.date">
            ///<summary>Returns the component's model current date, a moment object or null if not set.</summary>
            ///<returns type="Moment">date.clone()</returns>
            ///</signature>
            ///<signature>
            ///<summary>Sets the components model current moment to it. Passing a null value unsets the components model current moment. Parsing of the newDate parameter is made using moment library with the options.format and options.useStrict components configuration.</summary>
            ///<param name="newDate" locid="$.fn.datetimepicker.date_p:newDate">Takes string, Date, moment, null parameter.</param>
            ///</signature>
            if (arguments.length === 0) {
                if (unset) {
                    return null;
                }
                return date.clone();
            }

            if (newDate !== null && typeof newDate !== 'string' && !moment.isMoment(newDate) && !(newDate instanceof Date)) {
                throw new TypeError('date() parameter must be one of [null, string, moment or Date]');
            }

            setValue(newDate === null ? null : parseInputDate(newDate));
            return picker;
        };

        picker.format = function (newFormat) {
            ///<summary>test su</summary>
            ///<param name="newFormat">info about para</param>
            ///<returns type="string|boolean">returns foo</returns>
            if (arguments.length === 0) {
                return options.format;
            }

            if ((typeof newFormat !== 'string') && ((typeof newFormat !== 'boolean') || (newFormat !== false))) {
                throw new TypeError('format() expects a sting or boolean:false parameter ' + newFormat);
            }

            options.format = newFormat;
            if (actualFormat) {
                initFormatting(); // reinit formatting
            }
            return picker;
        };

        picker.dayViewHeaderFormat = function (newFormat) {
            if (arguments.length === 0) {
                return options.dayViewHeaderFormat;
            }

            if (typeof newFormat !== 'string') {
                throw new TypeError('dayViewHeaderFormat() expects a string parameter');
            }

            options.dayViewHeaderFormat = newFormat;
            return picker;
        };

        picker.extraFormats = function (formats) {
            if (arguments.length === 0) {
                return options.extraFormats;
            }

            if (formats !== false && !(formats instanceof Array)) {
                throw new TypeError('extraFormats() expects an array or false parameter');
            }

            options.extraFormats = formats;
            if (parseFormats) {
                initFormatting(); // reinit formatting
            }
            return picker;
        };

        picker.disabledDates = function (dates) {
            ///<signature helpKeyword="$.fn.datetimepicker.disabledDates">
            ///<summary>Returns an array with the currently set disabled dates on the component.</summary>
            ///<returns type="array">options.disabledDates</returns>
            ///</signature>
            ///<signature>
            ///<summary>Setting this takes precedence over options.minDate, options.maxDate configuration. Also calling this function removes the configuration of
            ///options.enabledDates if such exist.</summary>
            ///<param name="dates" locid="$.fn.datetimepicker.disabledDates_p:dates">Takes an [ string or Date or moment ] of values and allows the user to select only from those days.</param>
            ///</signature>
            if (arguments.length === 0) {
                return (options.disabledDates ? $.extend({}, options.disabledDates) : options.disabledDates);
            }

            if (!dates) {
                options.disabledDates = false;
                update();
                return picker;
            }
            if (!(dates instanceof Array)) {
                throw new TypeError('disabledDates() expects an array parameter');
            }
            options.disabledDates = indexGivenDates(dates);
            options.enabledDates = false;
            update();
            return picker;
        };

        picker.enabledDates = function (dates) {
            ///<signature helpKeyword="$.fn.datetimepicker.enabledDates">
            ///<summary>Returns an array with the currently set enabled dates on the component.</summary>
            ///<returns type="array">options.enabledDates</returns>
            ///</signature>
            ///<signature>
            ///<summary>Setting this takes precedence over options.minDate, options.maxDate configuration. Also calling this function removes the configuration of options.disabledDates if such exist.</summary>
            ///<param name="dates" locid="$.fn.datetimepicker.enabledDates_p:dates">Takes an [ string or Date or moment ] of values and allows the user to select only from those days.</param>
            ///</signature>
            if (arguments.length === 0) {
                return (options.enabledDates ? $.extend({}, options.enabledDates) : options.enabledDates);
            }

            if (!dates) {
                options.enabledDates = false;
                update();
                return picker;
            }
            if (!(dates instanceof Array)) {
                throw new TypeError('enabledDates() expects an array parameter');
            }
            options.enabledDates = indexGivenDates(dates);
            options.disabledDates = false;
            update();
            return picker;
        };

        picker.daysOfWeekDisabled = function (daysOfWeekDisabled) {
            if (arguments.length === 0) {
                return options.daysOfWeekDisabled.splice(0);
            }

            if ((typeof daysOfWeekDisabled === 'boolean') && !daysOfWeekDisabled) {
                options.daysOfWeekDisabled = false;
                update();
                return picker;
            }

            if (!(daysOfWeekDisabled instanceof Array)) {
                throw new TypeError('daysOfWeekDisabled() expects an array parameter');
            }
            options.daysOfWeekDisabled = daysOfWeekDisabled.reduce(function (previousValue, currentValue) {
                currentValue = parseInt(currentValue, 10);
                if (currentValue > 6 || currentValue < 0 || isNaN(currentValue)) {
                    return previousValue;
                }
                if (previousValue.indexOf(currentValue) === -1) {
                    previousValue.push(currentValue);
                }
                return previousValue;
            }, []).sort();
            if (options.useCurrent && !options.keepInvalid) {
                var tries = 0;
                while (!isValid(date, 'd')) {
                    date.add(1, 'd');
                    if (tries === 7) {
                        throw 'Tried 7 times to find a valid date';
                    }
                    tries++;
                }
                setValue(date);
            }
            update();
            return picker;
        };

        picker.maxDate = function (maxDate) {
            if (arguments.length === 0) {
                return options.maxDate ? options.maxDate.clone() : options.maxDate;
            }

            if ((typeof maxDate === 'boolean') && maxDate === false) {
                options.maxDate = false;
                update();
                return picker;
            }

            if (typeof maxDate === 'string') {
                if (maxDate === 'now' || maxDate === 'moment') {
                    maxDate = moment();
                }
            }

            var parsedDate = parseInputDate(maxDate);

            if (!parsedDate.isValid()) {
                throw new TypeError('maxDate() Could not parse date parameter: ' + maxDate);
            }
            if (options.minDate && parsedDate.isBefore(options.minDate)) {
                throw new TypeError('maxDate() date parameter is before options.minDate: ' + parsedDate.format(actualFormat));
            }
            options.maxDate = parsedDate;
            if (options.useCurrent && !options.keepInvalid && date.isAfter(maxDate)) {
                setValue(options.maxDate);
            }
            if (viewDate.isAfter(parsedDate)) {
                viewDate = parsedDate.clone().subtract(options.stepping, 'm');
            }
            update();
            return picker;
        };

        picker.minDate = function (minDate) {
            if (arguments.length === 0) {
                return options.minDate ? options.minDate.clone() : options.minDate;
            }

            if ((typeof minDate === 'boolean') && minDate === false) {
                options.minDate = false;
                update();
                return picker;
            }

            if (typeof minDate === 'string') {
                if (minDate === 'now' || minDate === 'moment') {
                    minDate = moment();
                }
            }

            var parsedDate = parseInputDate(minDate);

            if (!parsedDate.isValid()) {
                throw new TypeError('minDate() Could not parse date parameter: ' + minDate);
            }
            if (options.maxDate && parsedDate.isAfter(options.maxDate)) {
                throw new TypeError('minDate() date parameter is after options.maxDate: ' + parsedDate.format(actualFormat));
            }
            options.minDate = parsedDate;
            if (options.useCurrent && !options.keepInvalid && date.isBefore(minDate)) {
                setValue(options.minDate);
            }
            if (viewDate.isBefore(parsedDate)) {
                viewDate = parsedDate.clone().add(options.stepping, 'm');
            }
            update();
            return picker;
        };

        picker.defaultDate = function (defaultDate) {
            ///<signature helpKeyword="$.fn.datetimepicker.defaultDate">
            ///<summary>Returns a moment with the options.defaultDate option configuration or false if not set</summary>
            ///<returns type="Moment">date.clone()</returns>
            ///</signature>
            ///<signature>
            ///<summary>Will set the picker's inital date. If a boolean:false value is passed the options.defaultDate parameter is cleared.</summary>
            ///<param name="defaultDate" locid="$.fn.datetimepicker.defaultDate_p:defaultDate">Takes a string, Date, moment, boolean:false</param>
            ///</signature>
            if (arguments.length === 0) {
                return options.defaultDate ? options.defaultDate.clone() : options.defaultDate;
            }
            if (!defaultDate) {
                options.defaultDate = false;
                return picker;
            }

            if (typeof defaultDate === 'string') {
                if (defaultDate === 'now' || defaultDate === 'moment') {
                    defaultDate = moment();
                }
            }

            var parsedDate = parseInputDate(defaultDate);
            if (!parsedDate.isValid()) {
                throw new TypeError('defaultDate() Could not parse date parameter: ' + defaultDate);
            }
            if (!isValid(parsedDate)) {
                throw new TypeError('defaultDate() date passed is invalid according to component setup validations');
            }

            options.defaultDate = parsedDate;

            if (options.defaultDate && options.inline || (input.val().trim() === '' && input.attr('placeholder') === undefined)) {
                setValue(options.defaultDate);
            }
            return picker;
        };

        picker.locale = function (locale) {
            if (arguments.length === 0) {
                return options.locale;
            }

            if (!moment.localeData(locale)) {
                throw new TypeError('locale() locale ' + locale + ' is not loaded from moment locales!');
            }

            options.locale = locale;
            date.locale(options.locale);
            viewDate.locale(options.locale);

            if (actualFormat) {
                initFormatting(); // reinit formatting
            }
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.stepping = function (stepping) {
            if (arguments.length === 0) {
                return options.stepping;
            }

            stepping = parseInt(stepping, 10);
            if (isNaN(stepping) || stepping < 1) {
                stepping = 1;
            }
            options.stepping = stepping;
            return picker;
        };

        picker.useCurrent = function (useCurrent) {
            var useCurrentOptions = ['year', 'month', 'day', 'hour', 'minute'];
            if (arguments.length === 0) {
                return options.useCurrent;
            }

            if ((typeof useCurrent !== 'boolean') && (typeof useCurrent !== 'string')) {
                throw new TypeError('useCurrent() expects a boolean or string parameter');
            }
            if (typeof useCurrent === 'string' && useCurrentOptions.indexOf(useCurrent.toLowerCase()) === -1) {
                throw new TypeError('useCurrent() expects a string parameter of ' + useCurrentOptions.join(', '));
            }
            options.useCurrent = useCurrent;
            return picker;
        };

        picker.collapse = function (collapse) {
            if (arguments.length === 0) {
                return options.collapse;
            }

            if (typeof collapse !== 'boolean') {
                throw new TypeError('collapse() expects a boolean parameter');
            }
            if (options.collapse === collapse) {
                return picker;
            }
            options.collapse = collapse;
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.icons = function (icons) {
            if (arguments.length === 0) {
                return $.extend({}, options.icons);
            }

            if (!(icons instanceof Object)) {
                throw new TypeError('icons() expects parameter to be an Object');
            }
            $.extend(options.icons, icons);
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.tooltips = function (tooltips) {
            if (arguments.length === 0) {
                return $.extend({}, options.tooltips);
            }

            if (!(tooltips instanceof Object)) {
                throw new TypeError('tooltips() expects parameter to be an Object');
            }
            $.extend(options.tooltips, tooltips);
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.useStrict = function (useStrict) {
            if (arguments.length === 0) {
                return options.useStrict;
            }

            if (typeof useStrict !== 'boolean') {
                throw new TypeError('useStrict() expects a boolean parameter');
            }
            options.useStrict = useStrict;
            return picker;
        };

        picker.sideBySide = function (sideBySide) {
            if (arguments.length === 0) {
                return options.sideBySide;
            }

            if (typeof sideBySide !== 'boolean') {
                throw new TypeError('sideBySide() expects a boolean parameter');
            }
            options.sideBySide = sideBySide;
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.viewMode = function (viewMode) {
            if (arguments.length === 0) {
                return options.viewMode;
            }

            if (typeof viewMode !== 'string') {
                throw new TypeError('viewMode() expects a string parameter');
            }

            if (viewModes.indexOf(viewMode) === -1) {
                throw new TypeError('viewMode() parameter must be one of (' + viewModes.join(', ') + ') value');
            }

            options.viewMode = viewMode;
            currentViewMode = Math.max(viewModes.indexOf(viewMode), minViewModeNumber);

            showMode();
            return picker;
        };

        picker.toolbarPlacement = function (toolbarPlacement) {
            if (arguments.length === 0) {
                return options.toolbarPlacement;
            }

            if (typeof toolbarPlacement !== 'string') {
                throw new TypeError('toolbarPlacement() expects a string parameter');
            }
            if (toolbarPlacements.indexOf(toolbarPlacement) === -1) {
                throw new TypeError('toolbarPlacement() parameter must be one of (' + toolbarPlacements.join(', ') + ') value');
            }
            options.toolbarPlacement = toolbarPlacement;

            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.widgetPositioning = function (widgetPositioning) {
            if (arguments.length === 0) {
                return $.extend({}, options.widgetPositioning);
            }

            if (({}).toString.call(widgetPositioning) !== '[object Object]') {
                throw new TypeError('widgetPositioning() expects an object variable');
            }
            if (widgetPositioning.horizontal) {
                if (typeof widgetPositioning.horizontal !== 'string') {
                    throw new TypeError('widgetPositioning() horizontal variable must be a string');
                }
                widgetPositioning.horizontal = widgetPositioning.horizontal.toLowerCase();
                if (horizontalModes.indexOf(widgetPositioning.horizontal) === -1) {
                    throw new TypeError('widgetPositioning() expects horizontal parameter to be one of (' + horizontalModes.join(', ') + ')');
                }
                options.widgetPositioning.horizontal = widgetPositioning.horizontal;
            }
            if (widgetPositioning.vertical) {
                if (typeof widgetPositioning.vertical !== 'string') {
                    throw new TypeError('widgetPositioning() vertical variable must be a string');
                }
                widgetPositioning.vertical = widgetPositioning.vertical.toLowerCase();
                if (verticalModes.indexOf(widgetPositioning.vertical) === -1) {
                    throw new TypeError('widgetPositioning() expects vertical parameter to be one of (' + verticalModes.join(', ') + ')');
                }
                options.widgetPositioning.vertical = widgetPositioning.vertical;
            }
            update();
            return picker;
        };

        picker.calendarWeeks = function (calendarWeeks) {
            if (arguments.length === 0) {
                return options.calendarWeeks;
            }

            if (typeof calendarWeeks !== 'boolean') {
                throw new TypeError('calendarWeeks() expects parameter to be a boolean value');
            }

            options.calendarWeeks = calendarWeeks;
            update();
            return picker;
        };

        picker.showTodayButton = function (showTodayButton) {
            if (arguments.length === 0) {
                return options.showTodayButton;
            }

            if (typeof showTodayButton !== 'boolean') {
                throw new TypeError('showTodayButton() expects a boolean parameter');
            }

            options.showTodayButton = showTodayButton;
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.showClear = function (showClear) {
            if (arguments.length === 0) {
                return options.showClear;
            }

            if (typeof showClear !== 'boolean') {
                throw new TypeError('showClear() expects a boolean parameter');
            }

            options.showClear = showClear;
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.widgetParent = function (widgetParent) {
            if (arguments.length === 0) {
                return options.widgetParent;
            }

            if (typeof widgetParent === 'string') {
                widgetParent = $(widgetParent);
            }

            if (widgetParent !== null && (typeof widgetParent !== 'string' && !(widgetParent instanceof $))) {
                throw new TypeError('widgetParent() expects a string or a jQuery object parameter');
            }

            options.widgetParent = widgetParent;
            if (widget) {
                hide();
                show();
            }
            return picker;
        };

        picker.keepOpen = function (keepOpen) {
            if (arguments.length === 0) {
                return options.keepOpen;
            }

            if (typeof keepOpen !== 'boolean') {
                throw new TypeError('keepOpen() expects a boolean parameter');
            }

            options.keepOpen = keepOpen;
            return picker;
        };

        picker.focusOnShow = function (focusOnShow) {
            if (arguments.length === 0) {
                return options.focusOnShow;
            }

            if (typeof focusOnShow !== 'boolean') {
                throw new TypeError('focusOnShow() expects a boolean parameter');
            }

            options.focusOnShow = focusOnShow;
            return picker;
        };

        picker.inline = function (inline) {
            if (arguments.length === 0) {
                return options.inline;
            }

            if (typeof inline !== 'boolean') {
                throw new TypeError('inline() expects a boolean parameter');
            }

            options.inline = inline;
            return picker;
        };

        picker.clear = function () {
            clear();
            return picker;
        };

        picker.keyBinds = function (keyBinds) {
            options.keyBinds = keyBinds;
            return picker;
        };

        picker.debug = function (debug) {
            if (typeof debug !== 'boolean') {
                throw new TypeError('debug() expects a boolean parameter');
            }

            options.debug = debug;
            return picker;
        };

        picker.allowInputToggle = function (allowInputToggle) {
            if (arguments.length === 0) {
                return options.allowInputToggle;
            }

            if (typeof allowInputToggle !== 'boolean') {
                throw new TypeError('allowInputToggle() expects a boolean parameter');
            }

            options.allowInputToggle = allowInputToggle;
            return picker;
        };

        picker.showClose = function (showClose) {
            if (arguments.length === 0) {
                return options.showClose;
            }

            if (typeof showClose !== 'boolean') {
                throw new TypeError('showClose() expects a boolean parameter');
            }

            options.showClose = showClose;
            return picker;
        };

        picker.keepInvalid = function (keepInvalid) {
            if (arguments.length === 0) {
                return options.keepInvalid;
            }

            if (typeof keepInvalid !== 'boolean') {
                throw new TypeError('keepInvalid() expects a boolean parameter');
            }
            options.keepInvalid = keepInvalid;
            return picker;
        };

        picker.datepickerInput = function (datepickerInput) {
            if (arguments.length === 0) {
                return options.datepickerInput;
            }

            if (typeof datepickerInput !== 'string') {
                throw new TypeError('datepickerInput() expects a string parameter');
            }

            options.datepickerInput = datepickerInput;
            return picker;
        };

        picker.parseInputDate = function (parseInputDate) {
            if (arguments.length === 0) {
                return options.parseInputDate;
            }

            if (typeof parseInputDate !== 'function') {
                throw new TypeError('parseInputDate() sholud be as function');
            }

            options.parseInputDate = parseInputDate;

            return picker;
        };

        picker.disabledTimeIntervals = function (disabledTimeIntervals) {
            ///<signature helpKeyword="$.fn.datetimepicker.disabledTimeIntervals">
            ///<summary>Returns an array with the currently set disabled dates on the component.</summary>
            ///<returns type="array">options.disabledTimeIntervals</returns>
            ///</signature>
            ///<signature>
            ///<summary>Setting this takes precedence over options.minDate, options.maxDate configuration. Also calling this function removes the configuration of
            ///options.enabledDates if such exist.</summary>
            ///<param name="dates" locid="$.fn.datetimepicker.disabledTimeIntervals_p:dates">Takes an [ string or Date or moment ] of values and allows the user to select only from those days.</param>
            ///</signature>
            if (arguments.length === 0) {
                return (options.disabledTimeIntervals ? $.extend({}, options.disabledTimeIntervals) : options.disabledTimeIntervals);
            }

            if (!disabledTimeIntervals) {
                options.disabledTimeIntervals = false;
                update();
                return picker;
            }
            if (!(disabledTimeIntervals instanceof Array)) {
                throw new TypeError('disabledTimeIntervals() expects an array parameter');
            }
            options.disabledTimeIntervals = disabledTimeIntervals;
            update();
            return picker;
        };

        picker.disabledHours = function (hours) {
            ///<signature helpKeyword="$.fn.datetimepicker.disabledHours">
            ///<summary>Returns an array with the currently set disabled hours on the component.</summary>
            ///<returns type="array">options.disabledHours</returns>
            ///</signature>
            ///<signature>
            ///<summary>Setting this takes precedence over options.minDate, options.maxDate configuration. Also calling this function removes the configuration of
            ///options.enabledHours if such exist.</summary>
            ///<param name="hours" locid="$.fn.datetimepicker.disabledHours_p:hours">Takes an [ int ] of values and disallows the user to select only from those hours.</param>
            ///</signature>
            if (arguments.length === 0) {
                return (options.disabledHours ? $.extend({}, options.disabledHours) : options.disabledHours);
            }

            if (!hours) {
                options.disabledHours = false;
                update();
                return picker;
            }
            if (!(hours instanceof Array)) {
                throw new TypeError('disabledHours() expects an array parameter');
            }
            options.disabledHours = indexGivenHours(hours);
            options.enabledHours = false;
            if (options.useCurrent && !options.keepInvalid) {
                var tries = 0;
                while (!isValid(date, 'h')) {
                    date.add(1, 'h');
                    if (tries === 24) {
                        throw 'Tried 24 times to find a valid date';
                    }
                    tries++;
                }
                setValue(date);
            }
            update();
            return picker;
        };

        picker.enabledHours = function (hours) {
            ///<signature helpKeyword="$.fn.datetimepicker.enabledHours">
            ///<summary>Returns an array with the currently set enabled hours on the component.</summary>
            ///<returns type="array">options.enabledHours</returns>
            ///</signature>
            ///<signature>
            ///<summary>Setting this takes precedence over options.minDate, options.maxDate configuration. Also calling this function removes the configuration of options.disabledHours if such exist.</summary>
            ///<param name="hours" locid="$.fn.datetimepicker.enabledHours_p:hours">Takes an [ int ] of values and allows the user to select only from those hours.</param>
            ///</signature>
            if (arguments.length === 0) {
                return (options.enabledHours ? $.extend({}, options.enabledHours) : options.enabledHours);
            }

            if (!hours) {
                options.enabledHours = false;
                update();
                return picker;
            }
            if (!(hours instanceof Array)) {
                throw new TypeError('enabledHours() expects an array parameter');
            }
            options.enabledHours = indexGivenHours(hours);
            options.disabledHours = false;
            if (options.useCurrent && !options.keepInvalid) {
                var tries = 0;
                while (!isValid(date, 'h')) {
                    date.add(1, 'h');
                    if (tries === 24) {
                        throw 'Tried 24 times to find a valid date';
                    }
                    tries++;
                }
                setValue(date);
            }
            update();
            return picker;
        };

        picker.viewDate = function (newDate) {
            ///<signature helpKeyword="$.fn.datetimepicker.viewDate">
            ///<summary>Returns the component's model current viewDate, a moment object or null if not set.</summary>
            ///<returns type="Moment">viewDate.clone()</returns>
            ///</signature>
            ///<signature>
            ///<summary>Sets the components model current moment to it. Passing a null value unsets the components model current moment. Parsing of the newDate parameter is made using moment library with the options.format and options.useStrict components configuration.</summary>
            ///<param name="newDate" locid="$.fn.datetimepicker.date_p:newDate">Takes string, viewDate, moment, null parameter.</param>
            ///</signature>
            if (arguments.length === 0) {
                return viewDate.clone();
            }

            if (!newDate) {
                viewDate = date.clone();
                return picker;
            }

            if (typeof newDate !== 'string' && !moment.isMoment(newDate) && !(newDate instanceof Date)) {
                throw new TypeError('viewDate() parameter must be one of [string, moment or Date]');
            }

            viewDate = parseInputDate(newDate);
            viewUpdate();
            return picker;
        };

        // initializing element and component attributes
        if (element.is('input')) {
            input = element;
        } else {
            input = element.find(options.datepickerInput);
            if (input.size() === 0) {
                input = element.find('input');
            } else if (!input.is('input')) {
                throw new Error('CSS class "' + options.datepickerInput + '" cannot be applied to non input element');
            }
        }

        if (element.hasClass('input-group')) {
            // in case there is more then one 'input-group-addon' Issue #48
            if (element.find('.datepickerbutton').size() === 0) {
                component = element.find('.input-group-addon');
            } else {
                component = element.find('.datepickerbutton');
            }
        }

        if (!options.inline && !input.is('input')) {
            throw new Error('Could not initialize DateTimePicker without an input element');
        }

        $.extend(true, options, dataToOptions());

        picker.options(options);

        initFormatting();

        attachDatePickerElementEvents();

        if (input.prop('disabled')) {
            picker.disable();
        }
        if (input.is('input') && input.val().trim().length !== 0) {
            setValue(parseInputDate(input.val().trim()));
        }
        else if (options.defaultDate && input.attr('placeholder') === undefined) {
            setValue(options.defaultDate);
        }
        if (options.inline) {
            show();
        }
        return picker;
    };

    /********************************************************************************
     *
     * jQuery plugin constructor and defaults object
     *
     ********************************************************************************/

    $.fn.datetimepicker = function (options) {
        return this.each(function () {
            var $this = $(this);
            if (!$this.data('DateTimePicker')) {
                // create a private copy of the defaults object
                options = $.extend(true, {}, $.fn.datetimepicker.defaults, options);
                $this.data('DateTimePicker', dateTimePicker($this, options));
            }
        });
    };

    $.fn.datetimepicker.defaults = {
        format: false,
        dayViewHeaderFormat: 'MMMM YYYY',
        extraFormats: false,
        stepping: 1,
        minDate: false,
        maxDate: false,
        useCurrent: true,
        collapse: true,
        locale: moment.locale(),
        defaultDate: false,
        disabledDates: false,
        enabledDates: false,
        icons: {
            time: 'glyphicon glyphicon-time',
            date: 'glyphicon glyphicon-calendar',
            up: 'glyphicon glyphicon-chevron-up',
            down: 'glyphicon glyphicon-chevron-down',
            previous: 'glyphicon glyphicon-chevron-left',
            next: 'glyphicon glyphicon-chevron-right',
            today: 'glyphicon glyphicon-screenshot',
            clear: 'glyphicon glyphicon-trash',
            close: 'glyphicon glyphicon-remove'
        },
        tooltips: {
            today: 'Go to today',
            clear: 'Clear selection',
            close: 'Close the picker',
            selectMonth: 'Select Month',
            prevMonth: 'Previous Month',
            nextMonth: 'Next Month',
            selectYear: 'Select Year',
            prevYear: 'Previous Year',
            nextYear: 'Next Year',
            selectDecade: 'Select Decade',
            prevDecade: 'Previous Decade',
            nextDecade: 'Next Decade',
            prevCentury: 'Previous Century',
            nextCentury: 'Next Century'
        },
        useStrict: false,
        sideBySide: false,
        daysOfWeekDisabled: false,
        calendarWeeks: false,
        viewMode: 'days',
        toolbarPlacement: 'default',
        showTodayButton: false,
        showClear: false,
        showClose: false,
        widgetPositioning: {
            horizontal: 'auto',
            vertical: 'auto'
        },
        widgetParent: null,
        ignoreReadonly: false,
        keepOpen: false,
        focusOnShow: true,
        inline: false,
        keepInvalid: false,
        datepickerInput: '.datepickerinput',
        keyBinds: {
            up: function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().subtract(7, 'd'));
                } else {
                    this.date(d.clone().add(this.stepping(), 'm'));
                }
            },
            down: function (widget) {
                if (!widget) {
                    this.show();
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().add(7, 'd'));
                } else {
                    this.date(d.clone().subtract(this.stepping(), 'm'));
                }
            },
            'control up': function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().subtract(1, 'y'));
                } else {
                    this.date(d.clone().add(1, 'h'));
                }
            },
            'control down': function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().add(1, 'y'));
                } else {
                    this.date(d.clone().subtract(1, 'h'));
                }
            },
            left: function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().subtract(1, 'd'));
                }
            },
            right: function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().add(1, 'd'));
                }
            },
            pageUp: function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().subtract(1, 'M'));
                }
            },
            pageDown: function (widget) {
                if (!widget) {
                    return;
                }
                var d = this.date() || moment();
                if (widget.find('.datepicker').is(':visible')) {
                    this.date(d.clone().add(1, 'M'));
                }
            },
            enter: function () {
                this.hide();
            },
            escape: function () {
                this.hide();
            },
            //tab: function (widget) { //this break the flow of the form. disabling for now
            //    var toggle = widget.find('.picker-switch a[data-action="togglePicker"]');
            //    if(toggle.length > 0) toggle.click();
            //},
            'control space': function (widget) {
                if (widget.find('.timepicker').is(':visible')) {
                    widget.find('.btn[data-action="togglePeriod"]').click();
                }
            },
            t: function () {
                this.date(moment());
            },
            'delete': function () {
                this.clear();
            }
        },
        debug: false,
        allowInputToggle: false,
        disabledTimeIntervals: false,
        disabledHours: false,
        enabledHours: false,
        viewDate: false
    };
}));


/*! Select2 4.0.0 | https://github.com/select2/select2/blob/master/LICENSE.md */!function (a) { "function" == typeof define && define.amd ? define(["jquery"], a) : a("object" == typeof exports ? require("jquery") : jQuery) }(function (a) {
    var b = function () {
        if (a && a.fn && a.fn.select2 && a.fn.select2.amd) var b = a.fn.select2.amd; var b; return function () { if (!b || !b.requirejs) { b ? c = b : b = {}; var a, c, d; !function (b) { function e(a, b) { return u.call(a, b) } function f(a, b) { var c, d, e, f, g, h, i, j, k, l, m, n = b && b.split("/"), o = s.map, p = o && o["*"] || {}; if (a && "." === a.charAt(0)) if (b) { for (n = n.slice(0, n.length - 1), a = a.split("/"), g = a.length - 1, s.nodeIdCompat && w.test(a[g]) && (a[g] = a[g].replace(w, "")), a = n.concat(a), k = 0; k < a.length; k += 1) if (m = a[k], "." === m) a.splice(k, 1), k -= 1; else if (".." === m) { if (1 === k && (".." === a[2] || ".." === a[0])) break; k > 0 && (a.splice(k - 1, 2), k -= 2) } a = a.join("/") } else 0 === a.indexOf("./") && (a = a.substring(2)); if ((n || p) && o) { for (c = a.split("/"), k = c.length; k > 0; k -= 1) { if (d = c.slice(0, k).join("/"), n) for (l = n.length; l > 0; l -= 1) if (e = o[n.slice(0, l).join("/")], e && (e = e[d])) { f = e, h = k; break } if (f) break; !i && p && p[d] && (i = p[d], j = k) } !f && i && (f = i, h = j), f && (c.splice(0, h, f), a = c.join("/")) } return a } function g(a, c) { return function () { return n.apply(b, v.call(arguments, 0).concat([a, c])) } } function h(a) { return function (b) { return f(b, a) } } function i(a) { return function (b) { q[a] = b } } function j(a) { if (e(r, a)) { var c = r[a]; delete r[a], t[a] = !0, m.apply(b, c) } if (!e(q, a) && !e(t, a)) throw new Error("No " + a); return q[a] } function k(a) { var b, c = a ? a.indexOf("!") : -1; return c > -1 && (b = a.substring(0, c), a = a.substring(c + 1, a.length)), [b, a] } function l(a) { return function () { return s && s.config && s.config[a] || {} } } var m, n, o, p, q = {}, r = {}, s = {}, t = {}, u = Object.prototype.hasOwnProperty, v = [].slice, w = /\.js$/; o = function (a, b) { var c, d = k(a), e = d[0]; return a = d[1], e && (e = f(e, b), c = j(e)), e ? a = c && c.normalize ? c.normalize(a, h(b)) : f(a, b) : (a = f(a, b), d = k(a), e = d[0], a = d[1], e && (c = j(e))), { f: e ? e + "!" + a : a, n: a, pr: e, p: c } }, p = { require: function (a) { return g(a) }, exports: function (a) { var b = q[a]; return "undefined" != typeof b ? b : q[a] = {} }, module: function (a) { return { id: a, uri: "", exports: q[a], config: l(a) } } }, m = function (a, c, d, f) { var h, k, l, m, n, s, u = [], v = typeof d; if (f = f || a, "undefined" === v || "function" === v) { for (c = !c.length && d.length ? ["require", "exports", "module"] : c, n = 0; n < c.length; n += 1) if (m = o(c[n], f), k = m.f, "require" === k) u[n] = p.require(a); else if ("exports" === k) u[n] = p.exports(a), s = !0; else if ("module" === k) h = u[n] = p.module(a); else if (e(q, k) || e(r, k) || e(t, k)) u[n] = j(k); else { if (!m.p) throw new Error(a + " missing " + k); m.p.load(m.n, g(f, !0), i(k), {}), u[n] = q[k] } l = d ? d.apply(q[a], u) : void 0, a && (h && h.exports !== b && h.exports !== q[a] ? q[a] = h.exports : l === b && s || (q[a] = l)) } else a && (q[a] = d) }, a = c = n = function (a, c, d, e, f) { if ("string" == typeof a) return p[a] ? p[a](c) : j(o(a, c).f); if (!a.splice) { if (s = a, s.deps && n(s.deps, s.callback), !c) return; c.splice ? (a = c, c = d, d = null) : a = b } return c = c || function () { }, "function" == typeof d && (d = e, e = f), e ? m(b, a, c, d) : setTimeout(function () { m(b, a, c, d) }, 4), n }, n.config = function (a) { return n(a) }, a._defined = q, d = function (a, b, c) { b.splice || (c = b, b = []), e(q, a) || e(r, a) || (r[a] = [a, b, c]) }, d.amd = { jQuery: !0 } }(), b.requirejs = a, b.require = c, b.define = d } }(), b.define("almond", function () { }), b.define("jquery", [], function () { var b = a || $; return null == b && console && console.error && console.error("Select2: An instance of jQuery or a jQuery-compatible library was not found. Make sure that you are including jQuery before Select2 on your web page."), b }), b.define("select2/utils", ["jquery"], function (a) { function b(a) { var b = a.prototype, c = []; for (var d in b) { var e = b[d]; "function" == typeof e && "constructor" !== d && c.push(d) } return c } var c = {}; c.Extend = function (a, b) { function c() { this.constructor = a } var d = {}.hasOwnProperty; for (var e in b) d.call(b, e) && (a[e] = b[e]); return c.prototype = b.prototype, a.prototype = new c, a.__super__ = b.prototype, a }, c.Decorate = function (a, c) { function d() { var b = Array.prototype.unshift, d = c.prototype.constructor.length, e = a.prototype.constructor; d > 0 && (b.call(arguments, a.prototype.constructor), e = c.prototype.constructor), e.apply(this, arguments) } function e() { this.constructor = d } var f = b(c), g = b(a); c.displayName = a.displayName, d.prototype = new e; for (var h = 0; h < g.length; h++) { var i = g[h]; d.prototype[i] = a.prototype[i] } for (var j = (function (a) { var b = function () { }; a in d.prototype && (b = d.prototype[a]); var e = c.prototype[a]; return function () { var a = Array.prototype.unshift; return a.call(arguments, b), e.apply(this, arguments) } }), k = 0; k < f.length; k++) { var l = f[k]; d.prototype[l] = j(l) } return d }; var d = function () { this.listeners = {} }; return d.prototype.on = function (a, b) { this.listeners = this.listeners || {}, a in this.listeners ? this.listeners[a].push(b) : this.listeners[a] = [b] }, d.prototype.trigger = function (a) { var b = Array.prototype.slice; this.listeners = this.listeners || {}, a in this.listeners && this.invoke(this.listeners[a], b.call(arguments, 1)), "*" in this.listeners && this.invoke(this.listeners["*"], arguments) }, d.prototype.invoke = function (a, b) { for (var c = 0, d = a.length; d > c; c++) a[c].apply(this, b) }, c.Observable = d, c.generateChars = function (a) { for (var b = "", c = 0; a > c; c++) { var d = Math.floor(36 * Math.random()); b += d.toString(36) } return b }, c.bind = function (a, b) { return function () { a.apply(b, arguments) } }, c._convertData = function (a) { for (var b in a) { var c = b.split("-"), d = a; if (1 !== c.length) { for (var e = 0; e < c.length; e++) { var f = c[e]; f = f.substring(0, 1).toLowerCase() + f.substring(1), f in d || (d[f] = {}), e == c.length - 1 && (d[f] = a[b]), d = d[f] } delete a[b] } } return a }, c.hasScroll = function (b, c) { var d = a(c), e = c.style.overflowX, f = c.style.overflowY; return e !== f || "hidden" !== f && "visible" !== f ? "scroll" === e || "scroll" === f ? !0 : d.innerHeight() < c.scrollHeight || d.innerWidth() < c.scrollWidth : !1 }, c.escapeMarkup = function (a) { var b = { "\\": "&#92;", "&": "&amp;", "<": "&lt;", ">": "&gt;", '"': "&quot;", "'": "&#39;", "/": "&#47;" }; return "string" != typeof a ? a : String(a).replace(/[&<>"'\/\\]/g, function (a) { return b[a] }) }, c.appendMany = function (b, c) { if ("1.7" === a.fn.jquery.substr(0, 3)) { var d = a(); a.map(c, function (a) { d = d.add(a) }), c = d } b.append(c) }, c }), b.define("select2/results", ["jquery", "./utils"], function (a, b) { function c(a, b, d) { this.$element = a, this.data = d, this.options = b, c.__super__.constructor.call(this) } return b.Extend(c, b.Observable), c.prototype.render = function () { var b = a('<ul class="select2-results__options" role="tree"></ul>'); return this.options.get("multiple") && b.attr("aria-multiselectable", "true"), this.$results = b, b }, c.prototype.clear = function () { this.$results.empty() }, c.prototype.displayMessage = function (b) { var c = this.options.get("escapeMarkup"); this.clear(), this.hideLoading(); var d = a('<li role="treeitem" class="select2-results__option"></li>'), e = this.options.get("translations").get(b.message); d.append(c(e(b.args))), this.$results.append(d) }, c.prototype.append = function (a) { this.hideLoading(); var b = []; if (null == a.results || 0 === a.results.length) return void (0 === this.$results.children().length && this.trigger("results:message", { message: "noResults" })); a.results = this.sort(a.results); for (var c = 0; c < a.results.length; c++) { var d = a.results[c], e = this.option(d); b.push(e) } this.$results.append(b) }, c.prototype.position = function (a, b) { var c = b.find(".select2-results"); c.append(a) }, c.prototype.sort = function (a) { var b = this.options.get("sorter"); return b(a) }, c.prototype.setClasses = function () { var b = this; this.data.current(function (c) { var d = a.map(c, function (a) { return a.id.toString() }), e = b.$results.find(".select2-results__option[aria-selected]"); e.each(function () { var b = a(this), c = a.data(this, "data"), e = "" + c.id; null != c.element && c.element.selected || null == c.element && a.inArray(e, d) > -1 ? b.attr("aria-selected", "true") : b.attr("aria-selected", "false") }); var f = e.filter("[aria-selected=true]"); f.length > 0 ? f.first().trigger("mouseenter") : e.first().trigger("mouseenter") }) }, c.prototype.showLoading = function (a) { this.hideLoading(); var b = this.options.get("translations").get("searching"), c = { disabled: !0, loading: !0, text: b(a) }, d = this.option(c); d.className += " loading-results", this.$results.prepend(d) }, c.prototype.hideLoading = function () { this.$results.find(".loading-results").remove() }, c.prototype.option = function (b) { var c = document.createElement("li"); c.className = "select2-results__option"; var d = { role: "treeitem", "aria-selected": "false" }; b.disabled && (delete d["aria-selected"], d["aria-disabled"] = "true"), null == b.id && delete d["aria-selected"], null != b._resultId && (c.id = b._resultId), b.title && (c.title = b.title), b.children && (d.role = "group", d["aria-label"] = b.text, delete d["aria-selected"]); for (var e in d) { var f = d[e]; c.setAttribute(e, f) } if (b.children) { var g = a(c), h = document.createElement("strong"); h.className = "select2-results__group"; { a(h) } this.template(b, h); for (var i = [], j = 0; j < b.children.length; j++) { var k = b.children[j], l = this.option(k); i.push(l) } var m = a("<ul></ul>", { "class": "select2-results__options select2-results__options--nested" }); m.append(i), g.append(h), g.append(m) } else this.template(b, c); return a.data(c, "data", b), c }, c.prototype.bind = function (b) { var c = this, d = b.id + "-results"; this.$results.attr("id", d), b.on("results:all", function (a) { c.clear(), c.append(a.data), b.isOpen() && c.setClasses() }), b.on("results:append", function (a) { c.append(a.data), b.isOpen() && c.setClasses() }), b.on("query", function (a) { c.showLoading(a) }), b.on("select", function () { b.isOpen() && c.setClasses() }), b.on("unselect", function () { b.isOpen() && c.setClasses() }), b.on("open", function () { c.$results.attr("aria-expanded", "true"), c.$results.attr("aria-hidden", "false"), c.setClasses(), c.ensureHighlightVisible() }), b.on("close", function () { c.$results.attr("aria-expanded", "false"), c.$results.attr("aria-hidden", "true"), c.$results.removeAttr("aria-activedescendant") }), b.on("results:toggle", function () { var a = c.getHighlightedResults(); 0 !== a.length && a.trigger("mouseup") }), b.on("results:select", function () { var a = c.getHighlightedResults(); if (0 !== a.length) { var b = a.data("data"); "true" == a.attr("aria-selected") ? c.trigger("close") : c.trigger("select", { data: b }) } }), b.on("results:previous", function () { var a = c.getHighlightedResults(), b = c.$results.find("[aria-selected]"), d = b.index(a); if (0 !== d) { var e = d - 1; 0 === a.length && (e = 0); var f = b.eq(e); f.trigger("mouseenter"); var g = c.$results.offset().top, h = f.offset().top, i = c.$results.scrollTop() + (h - g); 0 === e ? c.$results.scrollTop(0) : 0 > h - g && c.$results.scrollTop(i) } }), b.on("results:next", function () { var a = c.getHighlightedResults(), b = c.$results.find("[aria-selected]"), d = b.index(a), e = d + 1; if (!(e >= b.length)) { var f = b.eq(e); f.trigger("mouseenter"); var g = c.$results.offset().top + c.$results.outerHeight(!1), h = f.offset().top + f.outerHeight(!1), i = c.$results.scrollTop() + h - g; 0 === e ? c.$results.scrollTop(0) : h > g && c.$results.scrollTop(i) } }), b.on("results:focus", function (a) { a.element.addClass("select2-results__option--highlighted") }), b.on("results:message", function (a) { c.displayMessage(a) }), a.fn.mousewheel && this.$results.on("mousewheel", function (a) { var b = c.$results.scrollTop(), d = c.$results.get(0).scrollHeight - c.$results.scrollTop() + a.deltaY, e = a.deltaY > 0 && b - a.deltaY <= 0, f = a.deltaY < 0 && d <= c.$results.height(); e ? (c.$results.scrollTop(0), a.preventDefault(), a.stopPropagation()) : f && (c.$results.scrollTop(c.$results.get(0).scrollHeight - c.$results.height()), a.preventDefault(), a.stopPropagation()) }), this.$results.on("mouseup", ".select2-results__option[aria-selected]", function (b) { var d = a(this), e = d.data("data"); return "true" === d.attr("aria-selected") ? void (c.options.get("multiple") ? c.trigger("unselect", { originalEvent: b, data: e }) : c.trigger("close")) : void c.trigger("select", { originalEvent: b, data: e }) }), this.$results.on("mouseenter", ".select2-results__option[aria-selected]", function () { var b = a(this).data("data"); c.getHighlightedResults().removeClass("select2-results__option--highlighted"), c.trigger("results:focus", { data: b, element: a(this) }) }) }, c.prototype.getHighlightedResults = function () { var a = this.$results.find(".select2-results__option--highlighted"); return a }, c.prototype.destroy = function () { this.$results.remove() }, c.prototype.ensureHighlightVisible = function () { var a = this.getHighlightedResults(); if (0 !== a.length) { var b = this.$results.find("[aria-selected]"), c = b.index(a), d = this.$results.offset().top, e = a.offset().top, f = this.$results.scrollTop() + (e - d), g = e - d; f -= 2 * a.outerHeight(!1), 2 >= c ? this.$results.scrollTop(0) : (g > this.$results.outerHeight() || 0 > g) && this.$results.scrollTop(f) } }, c.prototype.template = function (b, c) { var d = this.options.get("templateResult"), e = this.options.get("escapeMarkup"), f = d(b); null == f ? c.style.display = "none" : "string" == typeof f ? c.innerHTML = e(f) : a(c).append(f) }, c }), b.define("select2/keys", [], function () { var a = { BACKSPACE: 8, TAB: 9, ENTER: 13, SHIFT: 16, CTRL: 17, ALT: 18, ESC: 27, SPACE: 32, PAGE_UP: 33, PAGE_DOWN: 34, END: 35, HOME: 36, LEFT: 37, UP: 38, RIGHT: 39, DOWN: 40, DELETE: 46 }; return a }), b.define("select2/selection/base", ["jquery", "../utils", "../keys"], function (a, b, c) { function d(a, b) { this.$element = a, this.options = b, d.__super__.constructor.call(this) } return b.Extend(d, b.Observable), d.prototype.render = function () { var b = a('<span class="select2-selection" role="combobox" aria-autocomplete="list" aria-haspopup="true" aria-expanded="false"></span>'); return this._tabindex = 0, null != this.$element.data("old-tabindex") ? this._tabindex = this.$element.data("old-tabindex") : null != this.$element.attr("tabindex") && (this._tabindex = this.$element.attr("tabindex")), b.attr("title", this.$element.attr("title")), b.attr("tabindex", this._tabindex), this.$selection = b, b }, d.prototype.bind = function (a) { var b = this, d = (a.id + "-container", a.id + "-results"); this.container = a, this.$selection.on("focus", function (a) { b.trigger("focus", a) }), this.$selection.on("blur", function (a) { b.trigger("blur", a) }), this.$selection.on("keydown", function (a) { b.trigger("keypress", a), a.which === c.SPACE && a.preventDefault() }), a.on("results:focus", function (a) { b.$selection.attr("aria-activedescendant", a.data._resultId) }), a.on("selection:update", function (a) { b.update(a.data) }), a.on("open", function () { b.$selection.attr("aria-expanded", "true"), b.$selection.attr("aria-owns", d), b._attachCloseHandler(a) }), a.on("close", function () { b.$selection.attr("aria-expanded", "false"), b.$selection.removeAttr("aria-activedescendant"), b.$selection.removeAttr("aria-owns"), b.$selection.focus(), b._detachCloseHandler(a) }), a.on("enable", function () { b.$selection.attr("tabindex", b._tabindex) }), a.on("disable", function () { b.$selection.attr("tabindex", "-1") }) }, d.prototype._attachCloseHandler = function (b) { a(document.body).on("mousedown.select2." + b.id, function (b) { var c = a(b.target), d = c.closest(".select2"), e = a(".select2.select2-container--open"); e.each(function () { var b = a(this); if (this != d[0]) { var c = b.data("element"); c.select2("close") } }) }) }, d.prototype._detachCloseHandler = function (b) { a(document.body).off("mousedown.select2." + b.id) }, d.prototype.position = function (a, b) { var c = b.find(".selection"); c.append(a) }, d.prototype.destroy = function () { this._detachCloseHandler(this.container) }, d.prototype.update = function () { throw new Error("The `update` method must be defined in child classes.") }, d }), b.define("select2/selection/single", ["jquery", "./base", "../utils", "../keys"], function (a, b, c) { function d() { d.__super__.constructor.apply(this, arguments) } return c.Extend(d, b), d.prototype.render = function () { var a = d.__super__.render.call(this); return a.addClass("select2-selection--single"), a.html('<span class="select2-selection__rendered"></span><span class="select2-selection__arrow" role="presentation"><b role="presentation"></b></span>'), a }, d.prototype.bind = function (a) { var b = this; d.__super__.bind.apply(this, arguments); var c = a.id + "-container"; this.$selection.find(".select2-selection__rendered").attr("id", c), this.$selection.attr("aria-labelledby", c), this.$selection.on("mousedown", function (a) { 1 === a.which && b.trigger("toggle", { originalEvent: a }) }), this.$selection.on("focus", function () { }), this.$selection.on("blur", function () { }), a.on("selection:update", function (a) { b.update(a.data) }) }, d.prototype.clear = function () { this.$selection.find(".select2-selection__rendered").empty() }, d.prototype.display = function (a) { var b = this.options.get("templateSelection"), c = this.options.get("escapeMarkup"); return c(b(a)) }, d.prototype.selectionContainer = function () { return a("<span></span>") }, d.prototype.update = function (a) { if (0 === a.length) return void this.clear(); var b = a[0], c = this.display(b), d = this.$selection.find(".select2-selection__rendered"); d.empty().append(c), d.prop("title", b.title || b.text) }, d }), b.define("select2/selection/multiple", ["jquery", "./base", "../utils"], function (a, b, c) { function d() { d.__super__.constructor.apply(this, arguments) } return c.Extend(d, b), d.prototype.render = function () { var a = d.__super__.render.call(this); return a.addClass("select2-selection--multiple"), a.html('<ul class="select2-selection__rendered"></ul>'), a }, d.prototype.bind = function () { var b = this; d.__super__.bind.apply(this, arguments), this.$selection.on("click", function (a) { b.trigger("toggle", { originalEvent: a }) }), this.$selection.on("click", ".select2-selection__choice__remove", function (c) { var d = a(this), e = d.parent(), f = e.data("data"); b.trigger("unselect", { originalEvent: c, data: f }) }) }, d.prototype.clear = function () { this.$selection.find(".select2-selection__rendered").empty() }, d.prototype.display = function (a) { var b = this.options.get("templateSelection"), c = this.options.get("escapeMarkup"); return c(b(a)) }, d.prototype.selectionContainer = function () { var b = a('<li class="select2-selection__choice"><span class="select2-selection__choice__remove" role="presentation">&times;</span></li>'); return b }, d.prototype.update = function (a) { if (this.clear(), 0 !== a.length) { for (var b = [], d = 0; d < a.length; d++) { var e = a[d], f = this.display(e), g = this.selectionContainer(); g.append(f), g.prop("title", e.title || e.text), g.data("data", e), b.push(g) } var h = this.$selection.find(".select2-selection__rendered"); c.appendMany(h, b) } }, d }), b.define("select2/selection/placeholder", ["../utils"], function () { function a(a, b, c) { this.placeholder = this.normalizePlaceholder(c.get("placeholder")), a.call(this, b, c) } return a.prototype.normalizePlaceholder = function (a, b) { return "string" == typeof b && (b = { id: "", text: b }), b }, a.prototype.createPlaceholder = function (a, b) { var c = this.selectionContainer(); return c.html(this.display(b)), c.addClass("select2-selection__placeholder").removeClass("select2-selection__choice"), c }, a.prototype.update = function (a, b) { var c = 1 == b.length && b[0].id != this.placeholder.id, d = b.length > 1; if (d || c) return a.call(this, b); this.clear(); var e = this.createPlaceholder(this.placeholder); this.$selection.find(".select2-selection__rendered").append(e) }, a }), b.define("select2/selection/allowClear", ["jquery", "../keys"], function (a, b) { function c() { } return c.prototype.bind = function (a, b, c) { var d = this; a.call(this, b, c), null == this.placeholder && this.options.get("debug") && window.console && console.error && console.error("Select2: The `allowClear` option should be used in combination with the `placeholder` option."), this.$selection.on("mousedown", ".select2-selection__clear", function (a) { d._handleClear(a) }), b.on("keypress", function (a) { d._handleKeyboardClear(a, b) }) }, c.prototype._handleClear = function (a, b) { if (!this.options.get("disabled")) { var c = this.$selection.find(".select2-selection__clear"); if (0 !== c.length) { b.stopPropagation(); for (var d = c.data("data"), e = 0; e < d.length; e++) { var f = { data: d[e] }; if (this.trigger("unselect", f), f.prevented) return } this.$element.val(this.placeholder.id).trigger("change"), this.trigger("toggle") } } }, c.prototype._handleKeyboardClear = function (a, c, d) { d.isOpen() || (c.which == b.DELETE || c.which == b.BACKSPACE) && this._handleClear(c) }, c.prototype.update = function (b, c) { if (b.call(this, c), !(this.$selection.find(".select2-selection__placeholder").length > 0 || 0 === c.length)) { var d = a('<span class="select2-selection__clear">&times;</span>'); d.data("data", c), this.$selection.find(".select2-selection__rendered").prepend(d) } }, c }), b.define("select2/selection/search", ["jquery", "../utils", "../keys"], function (a, b, c) { function d(a, b, c) { a.call(this, b, c) } return d.prototype.render = function (b) { var c = a('<li class="select2-search select2-search--inline"><input class="select2-search__field" type="search" tabindex="-1" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" role="textbox" /></li>'); this.$searchContainer = c, this.$search = c.find("input"); var d = b.call(this); return d }, d.prototype.bind = function (a, b, d) { var e = this; a.call(this, b, d), b.on("open", function () { e.$search.attr("tabindex", 0), e.$search.focus() }), b.on("close", function () { e.$search.attr("tabindex", -1), e.$search.val(""), e.$search.focus() }), b.on("enable", function () { e.$search.prop("disabled", !1) }), b.on("disable", function () { e.$search.prop("disabled", !0) }), this.$selection.on("focusin", ".select2-search--inline", function (a) { e.trigger("focus", a) }), this.$selection.on("focusout", ".select2-search--inline", function (a) { e.trigger("blur", a) }), this.$selection.on("keydown", ".select2-search--inline", function (a) { a.stopPropagation(), e.trigger("keypress", a), e._keyUpPrevented = a.isDefaultPrevented(); var b = a.which; if (b === c.BACKSPACE && "" === e.$search.val()) { var d = e.$searchContainer.prev(".select2-selection__choice"); if (d.length > 0) { var f = d.data("data"); e.searchRemoveChoice(f), a.preventDefault() } } }), this.$selection.on("input", ".select2-search--inline", function () { e.$selection.off("keyup.search") }), this.$selection.on("keyup.search input", ".select2-search--inline", function (a) { e.handleSearch(a) }) }, d.prototype.createPlaceholder = function (a, b) { this.$search.attr("placeholder", b.text) }, d.prototype.update = function (a, b) { this.$search.attr("placeholder", ""), a.call(this, b), this.$selection.find(".select2-selection__rendered").append(this.$searchContainer), this.resizeSearch() }, d.prototype.handleSearch = function () { if (this.resizeSearch(), !this._keyUpPrevented) { var a = this.$search.val(); this.trigger("query", { term: a }) } this._keyUpPrevented = !1 }, d.prototype.searchRemoveChoice = function (a, b) { this.trigger("unselect", { data: b }), this.trigger("open"), this.$search.val(b.text + " ") }, d.prototype.resizeSearch = function () { this.$search.css("width", "25px"); var a = ""; if ("" !== this.$search.attr("placeholder")) a = this.$selection.find(".select2-selection__rendered").innerWidth(); else { var b = this.$search.val().length + 1; a = .75 * b + "em" } this.$search.css("width", a) }, d }), b.define("select2/selection/eventRelay", ["jquery"], function (a) { function b() { } return b.prototype.bind = function (b, c, d) { var e = this, f = ["open", "opening", "close", "closing", "select", "selecting", "unselect", "unselecting"], g = ["opening", "closing", "selecting", "unselecting"]; b.call(this, c, d), c.on("*", function (b, c) { if (-1 !== a.inArray(b, f)) { c = c || {}; var d = a.Event("select2:" + b, { params: c }); e.$element.trigger(d), -1 !== a.inArray(b, g) && (c.prevented = d.isDefaultPrevented()) } }) }, b }), b.define("select2/translation", ["jquery", "require"], function (a, b) { function c(a) { this.dict = a || {} } return c.prototype.all = function () { return this.dict }, c.prototype.get = function (a) { return this.dict[a] }, c.prototype.extend = function (b) { this.dict = a.extend({}, b.all(), this.dict) }, c._cache = {}, c.loadPath = function (a) { if (!(a in c._cache)) { var d = b(a); c._cache[a] = d } return new c(c._cache[a]) }, c }), b.define("select2/diacritics", [], function () { var a = { "Ⓐ": "A", "Ａ": "A", "À": "A", "Á": "A", "Â": "A", "Ầ": "A", "Ấ": "A", "Ẫ": "A", "Ẩ": "A", "Ã": "A", "Ā": "A", "Ă": "A", "Ằ": "A", "Ắ": "A", "Ẵ": "A", "Ẳ": "A", "Ȧ": "A", "Ǡ": "A", "Ä": "A", "Ǟ": "A", "Ả": "A", "Å": "A", "Ǻ": "A", "Ǎ": "A", "Ȁ": "A", "Ȃ": "A", "Ạ": "A", "Ậ": "A", "Ặ": "A", "Ḁ": "A", "Ą": "A", "Ⱥ": "A", "Ɐ": "A", "Ꜳ": "AA", "Æ": "AE", "Ǽ": "AE", "Ǣ": "AE", "Ꜵ": "AO", "Ꜷ": "AU", "Ꜹ": "AV", "Ꜻ": "AV", "Ꜽ": "AY", "Ⓑ": "B", "Ｂ": "B", "Ḃ": "B", "Ḅ": "B", "Ḇ": "B", "Ƀ": "B", "Ƃ": "B", "Ɓ": "B", "Ⓒ": "C", "Ｃ": "C", "Ć": "C", "Ĉ": "C", "Ċ": "C", "Č": "C", "Ç": "C", "Ḉ": "C", "Ƈ": "C", "Ȼ": "C", "Ꜿ": "C", "Ⓓ": "D", "Ｄ": "D", "Ḋ": "D", "Ď": "D", "Ḍ": "D", "Ḑ": "D", "Ḓ": "D", "Ḏ": "D", "Đ": "D", "Ƌ": "D", "Ɗ": "D", "Ɖ": "D", "Ꝺ": "D", "Ǳ": "DZ", "Ǆ": "DZ", "ǲ": "Dz", "ǅ": "Dz", "Ⓔ": "E", "Ｅ": "E", "È": "E", "É": "E", "Ê": "E", "Ề": "E", "Ế": "E", "Ễ": "E", "Ể": "E", "Ẽ": "E", "Ē": "E", "Ḕ": "E", "Ḗ": "E", "Ĕ": "E", "Ė": "E", "Ë": "E", "Ẻ": "E", "Ě": "E", "Ȅ": "E", "Ȇ": "E", "Ẹ": "E", "Ệ": "E", "Ȩ": "E", "Ḝ": "E", "Ę": "E", "Ḙ": "E", "Ḛ": "E", "Ɛ": "E", "Ǝ": "E", "Ⓕ": "F", "Ｆ": "F", "Ḟ": "F", "Ƒ": "F", "Ꝼ": "F", "Ⓖ": "G", "Ｇ": "G", "Ǵ": "G", "Ĝ": "G", "Ḡ": "G", "Ğ": "G", "Ġ": "G", "Ǧ": "G", "Ģ": "G", "Ǥ": "G", "Ɠ": "G", "Ꞡ": "G", "Ᵹ": "G", "Ꝿ": "G", "Ⓗ": "H", "Ｈ": "H", "Ĥ": "H", "Ḣ": "H", "Ḧ": "H", "Ȟ": "H", "Ḥ": "H", "Ḩ": "H", "Ḫ": "H", "Ħ": "H", "Ⱨ": "H", "Ⱶ": "H", "Ɥ": "H", "Ⓘ": "I", "Ｉ": "I", "Ì": "I", "Í": "I", "Î": "I", "Ĩ": "I", "Ī": "I", "Ĭ": "I", "İ": "I", "Ï": "I", "Ḯ": "I", "Ỉ": "I", "Ǐ": "I", "Ȉ": "I", "Ȋ": "I", "Ị": "I", "Į": "I", "Ḭ": "I", "Ɨ": "I", "Ⓙ": "J", "Ｊ": "J", "Ĵ": "J", "Ɉ": "J", "Ⓚ": "K", "Ｋ": "K", "Ḱ": "K", "Ǩ": "K", "Ḳ": "K", "Ķ": "K", "Ḵ": "K", "Ƙ": "K", "Ⱪ": "K", "Ꝁ": "K", "Ꝃ": "K", "Ꝅ": "K", "Ꞣ": "K", "Ⓛ": "L", "Ｌ": "L", "Ŀ": "L", "Ĺ": "L", "Ľ": "L", "Ḷ": "L", "Ḹ": "L", "Ļ": "L", "Ḽ": "L", "Ḻ": "L", "Ł": "L", "Ƚ": "L", "Ɫ": "L", "Ⱡ": "L", "Ꝉ": "L", "Ꝇ": "L", "Ꞁ": "L", "Ǉ": "LJ", "ǈ": "Lj", "Ⓜ": "M", "Ｍ": "M", "Ḿ": "M", "Ṁ": "M", "Ṃ": "M", "Ɱ": "M", "Ɯ": "M", "Ⓝ": "N", "Ｎ": "N", "Ǹ": "N", "Ń": "N", "Ñ": "N", "Ṅ": "N", "Ň": "N", "Ṇ": "N", "Ņ": "N", "Ṋ": "N", "Ṉ": "N", "Ƞ": "N", "Ɲ": "N", "Ꞑ": "N", "Ꞥ": "N", "Ǌ": "NJ", "ǋ": "Nj", "Ⓞ": "O", "Ｏ": "O", "Ò": "O", "Ó": "O", "Ô": "O", "Ồ": "O", "Ố": "O", "Ỗ": "O", "Ổ": "O", "Õ": "O", "Ṍ": "O", "Ȭ": "O", "Ṏ": "O", "Ō": "O", "Ṑ": "O", "Ṓ": "O", "Ŏ": "O", "Ȯ": "O", "Ȱ": "O", "Ö": "O", "Ȫ": "O", "Ỏ": "O", "Ő": "O", "Ǒ": "O", "Ȍ": "O", "Ȏ": "O", "Ơ": "O", "Ờ": "O", "Ớ": "O", "Ỡ": "O", "Ở": "O", "Ợ": "O", "Ọ": "O", "Ộ": "O", "Ǫ": "O", "Ǭ": "O", "Ø": "O", "Ǿ": "O", "Ɔ": "O", "Ɵ": "O", "Ꝋ": "O", "Ꝍ": "O", "Ƣ": "OI", "Ꝏ": "OO", "Ȣ": "OU", "Ⓟ": "P", "Ｐ": "P", "Ṕ": "P", "Ṗ": "P", "Ƥ": "P", "Ᵽ": "P", "Ꝑ": "P", "Ꝓ": "P", "Ꝕ": "P", "Ⓠ": "Q", "Ｑ": "Q", "Ꝗ": "Q", "Ꝙ": "Q", "Ɋ": "Q", "Ⓡ": "R", "Ｒ": "R", "Ŕ": "R", "Ṙ": "R", "Ř": "R", "Ȑ": "R", "Ȓ": "R", "Ṛ": "R", "Ṝ": "R", "Ŗ": "R", "Ṟ": "R", "Ɍ": "R", "Ɽ": "R", "Ꝛ": "R", "Ꞧ": "R", "Ꞃ": "R", "Ⓢ": "S", "Ｓ": "S", "ẞ": "S", "Ś": "S", "Ṥ": "S", "Ŝ": "S", "Ṡ": "S", "Š": "S", "Ṧ": "S", "Ṣ": "S", "Ṩ": "S", "Ș": "S", "Ş": "S", "Ȿ": "S", "Ꞩ": "S", "Ꞅ": "S", "Ⓣ": "T", "Ｔ": "T", "Ṫ": "T", "Ť": "T", "Ṭ": "T", "Ț": "T", "Ţ": "T", "Ṱ": "T", "Ṯ": "T", "Ŧ": "T", "Ƭ": "T", "Ʈ": "T", "Ⱦ": "T", "Ꞇ": "T", "Ꜩ": "TZ", "Ⓤ": "U", "Ｕ": "U", "Ù": "U", "Ú": "U", "Û": "U", "Ũ": "U", "Ṹ": "U", "Ū": "U", "Ṻ": "U", "Ŭ": "U", "Ü": "U", "Ǜ": "U", "Ǘ": "U", "Ǖ": "U", "Ǚ": "U", "Ủ": "U", "Ů": "U", "Ű": "U", "Ǔ": "U", "Ȕ": "U", "Ȗ": "U", "Ư": "U", "Ừ": "U", "Ứ": "U", "Ữ": "U", "Ử": "U", "Ự": "U", "Ụ": "U", "Ṳ": "U", "Ų": "U", "Ṷ": "U", "Ṵ": "U", "Ʉ": "U", "Ⓥ": "V", "Ｖ": "V", "Ṽ": "V", "Ṿ": "V", "Ʋ": "V", "Ꝟ": "V", "Ʌ": "V", "Ꝡ": "VY", "Ⓦ": "W", "Ｗ": "W", "Ẁ": "W", "Ẃ": "W", "Ŵ": "W", "Ẇ": "W", "Ẅ": "W", "Ẉ": "W", "Ⱳ": "W", "Ⓧ": "X", "Ｘ": "X", "Ẋ": "X", "Ẍ": "X", "Ⓨ": "Y", "Ｙ": "Y", "Ỳ": "Y", "Ý": "Y", "Ŷ": "Y", "Ỹ": "Y", "Ȳ": "Y", "Ẏ": "Y", "Ÿ": "Y", "Ỷ": "Y", "Ỵ": "Y", "Ƴ": "Y", "Ɏ": "Y", "Ỿ": "Y", "Ⓩ": "Z", "Ｚ": "Z", "Ź": "Z", "Ẑ": "Z", "Ż": "Z", "Ž": "Z", "Ẓ": "Z", "Ẕ": "Z", "Ƶ": "Z", "Ȥ": "Z", "Ɀ": "Z", "Ⱬ": "Z", "Ꝣ": "Z", "ⓐ": "a", "ａ": "a", "ẚ": "a", "à": "a", "á": "a", "â": "a", "ầ": "a", "ấ": "a", "ẫ": "a", "ẩ": "a", "ã": "a", "ā": "a", "ă": "a", "ằ": "a", "ắ": "a", "ẵ": "a", "ẳ": "a", "ȧ": "a", "ǡ": "a", "ä": "a", "ǟ": "a", "ả": "a", "å": "a", "ǻ": "a", "ǎ": "a", "ȁ": "a", "ȃ": "a", "ạ": "a", "ậ": "a", "ặ": "a", "ḁ": "a", "ą": "a", "ⱥ": "a", "ɐ": "a", "ꜳ": "aa", "æ": "ae", "ǽ": "ae", "ǣ": "ae", "ꜵ": "ao", "ꜷ": "au", "ꜹ": "av", "ꜻ": "av", "ꜽ": "ay", "ⓑ": "b", "ｂ": "b", "ḃ": "b", "ḅ": "b", "ḇ": "b", "ƀ": "b", "ƃ": "b", "ɓ": "b", "ⓒ": "c", "ｃ": "c", "ć": "c", "ĉ": "c", "ċ": "c", "č": "c", "ç": "c", "ḉ": "c", "ƈ": "c", "ȼ": "c", "ꜿ": "c", "ↄ": "c", "ⓓ": "d", "ｄ": "d", "ḋ": "d", "ď": "d", "ḍ": "d", "ḑ": "d", "ḓ": "d", "ḏ": "d", "đ": "d", "ƌ": "d", "ɖ": "d", "ɗ": "d", "ꝺ": "d", "ǳ": "dz", "ǆ": "dz", "ⓔ": "e", "ｅ": "e", "è": "e", "é": "e", "ê": "e", "ề": "e", "ế": "e", "ễ": "e", "ể": "e", "ẽ": "e", "ē": "e", "ḕ": "e", "ḗ": "e", "ĕ": "e", "ė": "e", "ë": "e", "ẻ": "e", "ě": "e", "ȅ": "e", "ȇ": "e", "ẹ": "e", "ệ": "e", "ȩ": "e", "ḝ": "e", "ę": "e", "ḙ": "e", "ḛ": "e", "ɇ": "e", "ɛ": "e", "ǝ": "e", "ⓕ": "f", "ｆ": "f", "ḟ": "f", "ƒ": "f", "ꝼ": "f", "ⓖ": "g", "ｇ": "g", "ǵ": "g", "ĝ": "g", "ḡ": "g", "ğ": "g", "ġ": "g", "ǧ": "g", "ģ": "g", "ǥ": "g", "ɠ": "g", "ꞡ": "g", "ᵹ": "g", "ꝿ": "g", "ⓗ": "h", "ｈ": "h", "ĥ": "h", "ḣ": "h", "ḧ": "h", "ȟ": "h", "ḥ": "h", "ḩ": "h", "ḫ": "h", "ẖ": "h", "ħ": "h", "ⱨ": "h", "ⱶ": "h", "ɥ": "h", "ƕ": "hv", "ⓘ": "i", "ｉ": "i", "ì": "i", "í": "i", "î": "i", "ĩ": "i", "ī": "i", "ĭ": "i", "ï": "i", "ḯ": "i", "ỉ": "i", "ǐ": "i", "ȉ": "i", "ȋ": "i", "ị": "i", "į": "i", "ḭ": "i", "ɨ": "i", "ı": "i", "ⓙ": "j", "ｊ": "j", "ĵ": "j", "ǰ": "j", "ɉ": "j", "ⓚ": "k", "ｋ": "k", "ḱ": "k", "ǩ": "k", "ḳ": "k", "ķ": "k", "ḵ": "k", "ƙ": "k", "ⱪ": "k", "ꝁ": "k", "ꝃ": "k", "ꝅ": "k", "ꞣ": "k", "ⓛ": "l", "ｌ": "l", "ŀ": "l", "ĺ": "l", "ľ": "l", "ḷ": "l", "ḹ": "l", "ļ": "l", "ḽ": "l", "ḻ": "l", "ſ": "l", "ł": "l", "ƚ": "l", "ɫ": "l", "ⱡ": "l", "ꝉ": "l", "ꞁ": "l", "ꝇ": "l", "ǉ": "lj", "ⓜ": "m", "ｍ": "m", "ḿ": "m", "ṁ": "m", "ṃ": "m", "ɱ": "m", "ɯ": "m", "ⓝ": "n", "ｎ": "n", "ǹ": "n", "ń": "n", "ñ": "n", "ṅ": "n", "ň": "n", "ṇ": "n", "ņ": "n", "ṋ": "n", "ṉ": "n", "ƞ": "n", "ɲ": "n", "ŉ": "n", "ꞑ": "n", "ꞥ": "n", "ǌ": "nj", "ⓞ": "o", "ｏ": "o", "ò": "o", "ó": "o", "ô": "o", "ồ": "o", "ố": "o", "ỗ": "o", "ổ": "o", "õ": "o", "ṍ": "o", "ȭ": "o", "ṏ": "o", "ō": "o", "ṑ": "o", "ṓ": "o", "ŏ": "o", "ȯ": "o", "ȱ": "o", "ö": "o", "ȫ": "o", "ỏ": "o", "ő": "o", "ǒ": "o", "ȍ": "o", "ȏ": "o", "ơ": "o", "ờ": "o", "ớ": "o", "ỡ": "o", "ở": "o", "ợ": "o", "ọ": "o", "ộ": "o", "ǫ": "o", "ǭ": "o", "ø": "o", "ǿ": "o", "ɔ": "o", "ꝋ": "o", "ꝍ": "o", "ɵ": "o", "ƣ": "oi", "ȣ": "ou", "ꝏ": "oo", "ⓟ": "p", "ｐ": "p", "ṕ": "p", "ṗ": "p", "ƥ": "p", "ᵽ": "p", "ꝑ": "p", "ꝓ": "p", "ꝕ": "p", "ⓠ": "q", "ｑ": "q", "ɋ": "q", "ꝗ": "q", "ꝙ": "q", "ⓡ": "r", "ｒ": "r", "ŕ": "r", "ṙ": "r", "ř": "r", "ȑ": "r", "ȓ": "r", "ṛ": "r", "ṝ": "r", "ŗ": "r", "ṟ": "r", "ɍ": "r", "ɽ": "r", "ꝛ": "r", "ꞧ": "r", "ꞃ": "r", "ⓢ": "s", "ｓ": "s", "ß": "s", "ś": "s", "ṥ": "s", "ŝ": "s", "ṡ": "s", "š": "s", "ṧ": "s", "ṣ": "s", "ṩ": "s", "ș": "s", "ş": "s", "ȿ": "s", "ꞩ": "s", "ꞅ": "s", "ẛ": "s", "ⓣ": "t", "ｔ": "t", "ṫ": "t", "ẗ": "t", "ť": "t", "ṭ": "t", "ț": "t", "ţ": "t", "ṱ": "t", "ṯ": "t", "ŧ": "t", "ƭ": "t", "ʈ": "t", "ⱦ": "t", "ꞇ": "t", "ꜩ": "tz", "ⓤ": "u", "ｕ": "u", "ù": "u", "ú": "u", "û": "u", "ũ": "u", "ṹ": "u", "ū": "u", "ṻ": "u", "ŭ": "u", "ü": "u", "ǜ": "u", "ǘ": "u", "ǖ": "u", "ǚ": "u", "ủ": "u", "ů": "u", "ű": "u", "ǔ": "u", "ȕ": "u", "ȗ": "u", "ư": "u", "ừ": "u", "ứ": "u", "ữ": "u", "ử": "u", "ự": "u", "ụ": "u", "ṳ": "u", "ų": "u", "ṷ": "u", "ṵ": "u", "ʉ": "u", "ⓥ": "v", "ｖ": "v", "ṽ": "v", "ṿ": "v", "ʋ": "v", "ꝟ": "v", "ʌ": "v", "ꝡ": "vy", "ⓦ": "w", "ｗ": "w", "ẁ": "w", "ẃ": "w", "ŵ": "w", "ẇ": "w", "ẅ": "w", "ẘ": "w", "ẉ": "w", "ⱳ": "w", "ⓧ": "x", "ｘ": "x", "ẋ": "x", "ẍ": "x", "ⓨ": "y", "ｙ": "y", "ỳ": "y", "ý": "y", "ŷ": "y", "ỹ": "y", "ȳ": "y", "ẏ": "y", "ÿ": "y", "ỷ": "y", "ẙ": "y", "ỵ": "y", "ƴ": "y", "ɏ": "y", "ỿ": "y", "ⓩ": "z", "ｚ": "z", "ź": "z", "ẑ": "z", "ż": "z", "ž": "z", "ẓ": "z", "ẕ": "z", "ƶ": "z", "ȥ": "z", "ɀ": "z", "ⱬ": "z", "ꝣ": "z", "Ά": "Α", "Έ": "Ε", "Ή": "Η", "Ί": "Ι", "Ϊ": "Ι", "Ό": "Ο", "Ύ": "Υ", "Ϋ": "Υ", "Ώ": "Ω", "ά": "α", "έ": "ε", "ή": "η", "ί": "ι", "ϊ": "ι", "ΐ": "ι", "ό": "ο", "ύ": "υ", "ϋ": "υ", "ΰ": "υ", "ω": "ω", "ς": "σ" }; return a }), b.define("select2/data/base", ["../utils"], function (a) { function b() { b.__super__.constructor.call(this) } return a.Extend(b, a.Observable), b.prototype.current = function () { throw new Error("The `current` method must be defined in child classes.") }, b.prototype.query = function () { throw new Error("The `query` method must be defined in child classes.") }, b.prototype.bind = function () { }, b.prototype.destroy = function () { }, b.prototype.generateResultId = function (b, c) { var d = b.id + "-result-"; return d += a.generateChars(4), d += null != c.id ? "-" + c.id.toString() : "-" + a.generateChars(4) }, b }), b.define("select2/data/select", ["./base", "../utils", "jquery"], function (a, b, c) {
            function d(a, b) { this.$element = a, this.options = b, d.__super__.constructor.call(this) } return b.Extend(d, a), d.prototype.current = function (a) { var b = [], d = this; this.$element.find(":selected").each(function () { var a = c(this), e = d.item(a); b.push(e) }), a(b) }, d.prototype.select = function (a) { var b = this; if (a.selected = !0, c(a.element).is("option")) return a.element.selected = !0, void this.$element.trigger("change"); if (this.$element.prop("multiple")) this.current(function (d) { var e = []; a = [a], a.push.apply(a, d); for (var f = 0; f < a.length; f++) { var g = a[f].id; -1 === c.inArray(g, e) && e.push(g) } b.$element.val(e), b.$element.trigger("change") }); else { var d = a.id; this.$element.val(d), this.$element.trigger("change") } }, d.prototype.unselect = function (a) { var b = this; if (this.$element.prop("multiple")) return a.selected = !1, c(a.element).is("option") ? (a.element.selected = !1, void this.$element.trigger("change")) : void this.current(function (d) { for (var e = [], f = 0; f < d.length; f++) { var g = d[f].id; g !== a.id && -1 === c.inArray(g, e) && e.push(g) } b.$element.val(e), b.$element.trigger("change") }) }, d.prototype.bind = function (a) { var b = this; this.container = a, a.on("select", function (a) { b.select(a.data) }), a.on("unselect", function (a) { b.unselect(a.data) }) }, d.prototype.destroy = function () { this.$element.find("*").each(function () { c.removeData(this, "data") }) }, d.prototype.query = function (a, b) { var d = [], e = this, f = this.$element.children(); f.each(function () { var b = c(this); if (b.is("option") || b.is("optgroup")) { var f = e.item(b), g = e.matches(a, f); null !== g && d.push(g) } }), b({ results: d }) }, d.prototype.addOptions = function (a) { b.appendMany(this.$element, a) }, d.prototype.option = function (a) { var b; a.children ? (b = document.createElement("optgroup"), b.label = a.text) : (b = document.createElement("option"), void 0 !== b.textContent ? b.textContent = a.text : b.innerText = a.text), a.id && (b.value = a.id), a.disabled && (b.disabled = !0), a.selected && (b.selected = !0), a.title && (b.title = a.title); var d = c(b), e = this._normalizeItem(a); return e.element = b, c.data(b, "data", e), d }, d.prototype.item = function (a) {
                var b = {};
                if (b = c.data(a[0], "data"), null != b) return b; if (a.is("option")) b = { id: a.val(), text: a.text(), disabled: a.prop("disabled"), selected: a.prop("selected"), title: a.prop("title") }; else if (a.is("optgroup")) { b = { text: a.prop("label"), children: [], title: a.prop("title") }; for (var d = a.children("option"), e = [], f = 0; f < d.length; f++) { var g = c(d[f]), h = this.item(g); e.push(h) } b.children = e } return b = this._normalizeItem(b), b.element = a[0], c.data(a[0], "data", b), b
            }, d.prototype._normalizeItem = function (a) { c.isPlainObject(a) || (a = { id: a, text: a }), a = c.extend({}, { text: "" }, a); var b = { selected: !1, disabled: !1 }; return null != a.id && (a.id = a.id.toString()), null != a.text && (a.text = a.text.toString()), null == a._resultId && a.id && null != this.container && (a._resultId = this.generateResultId(this.container, a)), c.extend({}, b, a) }, d.prototype.matches = function (a, b) { var c = this.options.get("matcher"); return c(a, b) }, d
        }), b.define("select2/data/array", ["./select", "../utils", "jquery"], function (a, b, c) { function d(a, b) { var c = b.get("data") || []; d.__super__.constructor.call(this, a, b), this.addOptions(this.convertToOptions(c)) } return b.Extend(d, a), d.prototype.select = function (a) { var b = this.$element.find("option").filter(function (b, c) { return c.value == a.id.toString() }); 0 === b.length && (b = this.option(a), this.addOptions(b)), d.__super__.select.call(this, a) }, d.prototype.convertToOptions = function (a) { function d(a) { return function () { return c(this).val() == a.id } } for (var e = this, f = this.$element.find("option"), g = f.map(function () { return e.item(c(this)).id }).get(), h = [], i = 0; i < a.length; i++) { var j = this._normalizeItem(a[i]); if (c.inArray(j.id, g) >= 0) { var k = f.filter(d(j)), l = this.item(k), m = (c.extend(!0, {}, l, j), this.option(l)); k.replaceWith(m) } else { var n = this.option(j); if (j.children) { var o = this.convertToOptions(j.children); b.appendMany(n, o) } h.push(n) } } return h }, d }), b.define("select2/data/ajax", ["./array", "../utils", "jquery"], function (a, b, c) { function d(b, c) { this.ajaxOptions = this._applyDefaults(c.get("ajax")), null != this.ajaxOptions.processResults && (this.processResults = this.ajaxOptions.processResults), a.__super__.constructor.call(this, b, c) } return b.Extend(d, a), d.prototype._applyDefaults = function (a) { var b = { data: function (a) { return { q: a.term } }, transport: function (a, b, d) { var e = c.ajax(a); return e.then(b), e.fail(d), e } }; return c.extend({}, b, a, !0) }, d.prototype.processResults = function (a) { return a }, d.prototype.query = function (a, b) { function d() { var d = f.transport(f, function (d) { var f = e.processResults(d, a); e.options.get("debug") && window.console && console.error && (f && f.results && c.isArray(f.results) || console.error("Select2: The AJAX results did not return an array in the `results` key of the response.")), b(f) }, function () { }); e._request = d } var e = this; null != this._request && (c.isFunction(this._request.abort) && this._request.abort(), this._request = null); var f = c.extend({ type: "GET" }, this.ajaxOptions); "function" == typeof f.url && (f.url = f.url(a)), "function" == typeof f.data && (f.data = f.data(a)), this.ajaxOptions.delay && "" !== a.term ? (this._queryTimeout && window.clearTimeout(this._queryTimeout), this._queryTimeout = window.setTimeout(d, this.ajaxOptions.delay)) : d() }, d }), b.define("select2/data/tags", ["jquery"], function (a) { function b(b, c, d) { var e = d.get("tags"), f = d.get("createTag"); if (void 0 !== f && (this.createTag = f), b.call(this, c, d), a.isArray(e)) for (var g = 0; g < e.length; g++) { var h = e[g], i = this._normalizeItem(h), j = this.option(i); this.$element.append(j) } } return b.prototype.query = function (a, b, c) { function d(a, f) { for (var g = a.results, h = 0; h < g.length; h++) { var i = g[h], j = null != i.children && !d({ results: i.children }, !0), k = i.text === b.term; if (k || j) return f ? !1 : (a.data = g, void c(a)) } if (f) return !0; var l = e.createTag(b); if (null != l) { var m = e.option(l); m.attr("data-select2-tag", !0), e.addOptions([m]), e.insertTag(g, l) } a.results = g, c(a) } var e = this; return this._removeOldTags(), null == b.term || null != b.page ? void a.call(this, b, c) : void a.call(this, b, d) }, b.prototype.createTag = function (b, c) { var d = a.trim(c.term); return "" === d ? null : { id: d, text: d } }, b.prototype.insertTag = function (a, b, c) { b.unshift(c) }, b.prototype._removeOldTags = function () { var b = (this._lastTag, this.$element.find("option[data-select2-tag]")); b.each(function () { this.selected || a(this).remove() }) }, b }), b.define("select2/data/tokenizer", ["jquery"], function (a) { function b(a, b, c) { var d = c.get("tokenizer"); void 0 !== d && (this.tokenizer = d), a.call(this, b, c) } return b.prototype.bind = function (a, b, c) { a.call(this, b, c), this.$search = b.dropdown.$search || b.selection.$search || c.find(".select2-search__field") }, b.prototype.query = function (a, b, c) { function d(a) { e.select(a) } var e = this; b.term = b.term || ""; var f = this.tokenizer(b, this.options, d); f.term !== b.term && (this.$search.length && (this.$search.val(f.term), this.$search.focus()), b.term = f.term), a.call(this, b, c) }, b.prototype.tokenizer = function (b, c, d, e) { for (var f = d.get("tokenSeparators") || [], g = c.term, h = 0, i = this.createTag || function (a) { return { id: a.term, text: a.term } }; h < g.length;) { var j = g[h]; if (-1 !== a.inArray(j, f)) { var k = g.substr(0, h), l = a.extend({}, c, { term: k }), m = i(l); e(m), g = g.substr(h + 1) || "", h = 0 } else h++ } return { term: g } }, b }), b.define("select2/data/minimumInputLength", [], function () { function a(a, b, c) { this.minimumInputLength = c.get("minimumInputLength"), a.call(this, b, c) } return a.prototype.query = function (a, b, c) { return b.term = b.term || "", b.term.length < this.minimumInputLength ? void this.trigger("results:message", { message: "inputTooShort", args: { minimum: this.minimumInputLength, input: b.term, params: b } }) : void a.call(this, b, c) }, a }), b.define("select2/data/maximumInputLength", [], function () { function a(a, b, c) { this.maximumInputLength = c.get("maximumInputLength"), a.call(this, b, c) } return a.prototype.query = function (a, b, c) { return b.term = b.term || "", this.maximumInputLength > 0 && b.term.length > this.maximumInputLength ? void this.trigger("results:message", { message: "inputTooLong", args: { maximum: this.maximumInputLength, input: b.term, params: b } }) : void a.call(this, b, c) }, a }), b.define("select2/data/maximumSelectionLength", [], function () { function a(a, b, c) { this.maximumSelectionLength = c.get("maximumSelectionLength"), a.call(this, b, c) } return a.prototype.query = function (a, b, c) { var d = this; this.current(function (e) { var f = null != e ? e.length : 0; return d.maximumSelectionLength > 0 && f >= d.maximumSelectionLength ? void d.trigger("results:message", { message: "maximumSelected", args: { maximum: d.maximumSelectionLength } }) : void a.call(d, b, c) }) }, a }), b.define("select2/dropdown", ["jquery", "./utils"], function (a, b) { function c(a, b) { this.$element = a, this.options = b, c.__super__.constructor.call(this) } return b.Extend(c, b.Observable), c.prototype.render = function () { var b = a('<span class="select2-dropdown"><span class="select2-results"></span></span>'); return b.attr("dir", this.options.get("dir")), this.$dropdown = b, b }, c.prototype.position = function () { }, c.prototype.destroy = function () { this.$dropdown.remove() }, c }), b.define("select2/dropdown/search", ["jquery", "../utils"], function (a) { function b() { } return b.prototype.render = function (b) { var c = b.call(this), d = a('<span class="select2-search select2-search--dropdown"><input class="select2-search__field" type="search" tabindex="-1" autocomplete="off" autocorrect="off" autocapitalize="off" spellcheck="false" role="textbox" /></span>'); return this.$searchContainer = d, this.$search = d.find("input"), c.prepend(d), c }, b.prototype.bind = function (b, c, d) { var e = this; b.call(this, c, d), this.$search.on("keydown", function (a) { e.trigger("keypress", a), e._keyUpPrevented = a.isDefaultPrevented() }), this.$search.on("input", function () { a(this).off("keyup") }), this.$search.on("keyup input", function (a) { e.handleSearch(a) }), c.on("open", function () { e.$search.attr("tabindex", 0), e.$search.focus(), window.setTimeout(function () { e.$search.focus() }, 0) }), c.on("close", function () { e.$search.attr("tabindex", -1), e.$search.val("") }), c.on("results:all", function (a) { if (null == a.query.term || "" === a.query.term) { var b = e.showSearch(a); b ? e.$searchContainer.removeClass("select2-search--hide") : e.$searchContainer.addClass("select2-search--hide") } }) }, b.prototype.handleSearch = function () { if (!this._keyUpPrevented) { var a = this.$search.val(); this.trigger("query", { term: a }) } this._keyUpPrevented = !1 }, b.prototype.showSearch = function () { return !0 }, b }), b.define("select2/dropdown/hidePlaceholder", [], function () { function a(a, b, c, d) { this.placeholder = this.normalizePlaceholder(c.get("placeholder")), a.call(this, b, c, d) } return a.prototype.append = function (a, b) { b.results = this.removePlaceholder(b.results), a.call(this, b) }, a.prototype.normalizePlaceholder = function (a, b) { return "string" == typeof b && (b = { id: "", text: b }), b }, a.prototype.removePlaceholder = function (a, b) { for (var c = b.slice(0), d = b.length - 1; d >= 0; d--) { var e = b[d]; this.placeholder.id === e.id && c.splice(d, 1) } return c }, a }), b.define("select2/dropdown/infiniteScroll", ["jquery"], function (a) { function b(a, b, c, d) { this.lastParams = {}, a.call(this, b, c, d), this.$loadingMore = this.createLoadingMore(), this.loading = !1 } return b.prototype.append = function (a, b) { this.$loadingMore.remove(), this.loading = !1, a.call(this, b), this.showLoadingMore(b) && this.$results.append(this.$loadingMore) }, b.prototype.bind = function (b, c, d) { var e = this; b.call(this, c, d), c.on("query", function (a) { e.lastParams = a, e.loading = !0 }), c.on("query:append", function (a) { e.lastParams = a, e.loading = !0 }), this.$results.on("scroll", function () { var b = a.contains(document.documentElement, e.$loadingMore[0]); if (!e.loading && b) { var c = e.$results.offset().top + e.$results.outerHeight(!1), d = e.$loadingMore.offset().top + e.$loadingMore.outerHeight(!1); c + 50 >= d && e.loadMore() } }) }, b.prototype.loadMore = function () { this.loading = !0; var b = a.extend({}, { page: 1 }, this.lastParams); b.page++, this.trigger("query:append", b) }, b.prototype.showLoadingMore = function (a, b) { return b.pagination && b.pagination.more }, b.prototype.createLoadingMore = function () { var b = a('<li class="option load-more" role="treeitem"></li>'), c = this.options.get("translations").get("loadingMore"); return b.html(c(this.lastParams)), b }, b }), b.define("select2/dropdown/attachBody", ["jquery", "../utils"], function (a, b) { function c(a, b, c) { this.$dropdownParent = c.get("dropdownParent") || document.body, a.call(this, b, c) } return c.prototype.bind = function (a, b, c) { var d = this, e = !1; a.call(this, b, c), b.on("open", function () { d._showDropdown(), d._attachPositioningHandler(b), e || (e = !0, b.on("results:all", function () { d._positionDropdown(), d._resizeDropdown() }), b.on("results:append", function () { d._positionDropdown(), d._resizeDropdown() })) }), b.on("close", function () { d._hideDropdown(), d._detachPositioningHandler(b) }), this.$dropdownContainer.on("mousedown", function (a) { a.stopPropagation() }) }, c.prototype.position = function (a, b, c) { b.attr("class", c.attr("class")), b.removeClass("select2"), b.addClass("select2-container--open"), b.css({ position: "absolute", top: -999999 }), this.$container = c }, c.prototype.render = function (b) { var c = a("<span></span>"), d = b.call(this); return c.append(d), this.$dropdownContainer = c, c }, c.prototype._hideDropdown = function () { this.$dropdownContainer.detach() }, c.prototype._attachPositioningHandler = function (c) { var d = this, e = "scroll.select2." + c.id, f = "resize.select2." + c.id, g = "orientationchange.select2." + c.id, h = this.$container.parents().filter(b.hasScroll); h.each(function () { a(this).data("select2-scroll-position", { x: a(this).scrollLeft(), y: a(this).scrollTop() }) }), h.on(e, function () { var b = a(this).data("select2-scroll-position"); a(this).scrollTop(b.y) }), a(window).on(e + " " + f + " " + g, function () { d._positionDropdown(), d._resizeDropdown() }) }, c.prototype._detachPositioningHandler = function (c) { var d = "scroll.select2." + c.id, e = "resize.select2." + c.id, f = "orientationchange.select2." + c.id, g = this.$container.parents().filter(b.hasScroll); g.off(d), a(window).off(d + " " + e + " " + f) }, c.prototype._positionDropdown = function () { var b = a(window), c = this.$dropdown.hasClass("select2-dropdown--above"), d = this.$dropdown.hasClass("select2-dropdown--below"), e = null, f = (this.$container.position(), this.$container.offset()); f.bottom = f.top + this.$container.outerHeight(!1); var g = { height: this.$container.outerHeight(!1) }; g.top = f.top, g.bottom = f.top + g.height; var h = { height: this.$dropdown.outerHeight(!1) }, i = { top: b.scrollTop(), bottom: b.scrollTop() + b.height() }, j = i.top < f.top - h.height, k = i.bottom > f.bottom + h.height, l = { left: f.left, top: g.bottom }; c || d || (e = "below"), k || !j || c ? !j && k && c && (e = "below") : e = "above", ("above" == e || c && "below" !== e) && (l.top = g.top - h.height), null != e && (this.$dropdown.removeClass("select2-dropdown--below select2-dropdown--above").addClass("select2-dropdown--" + e), this.$container.removeClass("select2-container--below select2-container--above").addClass("select2-container--" + e)), this.$dropdownContainer.css(l) }, c.prototype._resizeDropdown = function () { this.$dropdownContainer.width(); var a = { width: this.$container.outerWidth(!1) + "px" }; this.options.get("dropdownAutoWidth") && (a.minWidth = a.width, a.width = "auto"), this.$dropdown.css(a) }, c.prototype._showDropdown = function () { this.$dropdownContainer.appendTo(this.$dropdownParent), this._positionDropdown(), this._resizeDropdown() }, c }), b.define("select2/dropdown/minimumResultsForSearch", [], function () { function a(b) { for (var c = 0, d = 0; d < b.length; d++) { var e = b[d]; e.children ? c += a(e.children) : c++ } return c } function b(a, b, c, d) { this.minimumResultsForSearch = c.get("minimumResultsForSearch"), this.minimumResultsForSearch < 0 && (this.minimumResultsForSearch = 1 / 0), a.call(this, b, c, d) } return b.prototype.showSearch = function (b, c) { return a(c.data.results) < this.minimumResultsForSearch ? !1 : b.call(this, c) }, b }), b.define("select2/dropdown/selectOnClose", [], function () { function a() { } return a.prototype.bind = function (a, b, c) { var d = this; a.call(this, b, c), b.on("close", function () { d._handleSelectOnClose() }) }, a.prototype._handleSelectOnClose = function () { var a = this.getHighlightedResults(); a.length < 1 || this.trigger("select", { data: a.data("data") }) }, a }), b.define("select2/dropdown/closeOnSelect", [], function () { function a() { } return a.prototype.bind = function (a, b, c) { var d = this; a.call(this, b, c), b.on("select", function (a) { d._selectTriggered(a) }), b.on("unselect", function (a) { d._selectTriggered(a) }) }, a.prototype._selectTriggered = function (a, b) { var c = b.originalEvent; c && c.ctrlKey || this.trigger("close") }, a }), b.define("select2/i18n/en", [], function () { return { errorLoading: function () { return "The results could not be loaded." }, inputTooLong: function (a) { var b = a.input.length - a.maximum, c = "Please delete " + b + " character"; return 1 != b && (c += "s"), c }, inputTooShort: function (a) { var b = a.minimum - a.input.length, c = "Please enter " + b + " or more characters"; return c }, loadingMore: function () { return "Loading more results…" }, maximumSelected: function (a) { var b = "You can only select " + a.maximum + " item"; return 1 != a.maximum && (b += "s"), b }, noResults: function () { return "No results found" }, searching: function () { return "Searching…" } } }), b.define("select2/defaults", ["jquery", "require", "./results", "./selection/single", "./selection/multiple", "./selection/placeholder", "./selection/allowClear", "./selection/search", "./selection/eventRelay", "./utils", "./translation", "./diacritics", "./data/select", "./data/array", "./data/ajax", "./data/tags", "./data/tokenizer", "./data/minimumInputLength", "./data/maximumInputLength", "./data/maximumSelectionLength", "./dropdown", "./dropdown/search", "./dropdown/hidePlaceholder", "./dropdown/infiniteScroll", "./dropdown/attachBody", "./dropdown/minimumResultsForSearch", "./dropdown/selectOnClose", "./dropdown/closeOnSelect", "./i18n/en"], function (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C) { function D() { this.reset() } D.prototype.apply = function (l) { if (l = a.extend({}, this.defaults, l), null == l.dataAdapter) { if (l.dataAdapter = null != l.ajax ? o : null != l.data ? n : m, l.minimumInputLength > 0 && (l.dataAdapter = j.Decorate(l.dataAdapter, r)), l.maximumInputLength > 0 && (l.dataAdapter = j.Decorate(l.dataAdapter, s)), l.maximumSelectionLength > 0 && (l.dataAdapter = j.Decorate(l.dataAdapter, t)), l.tags && (l.dataAdapter = j.Decorate(l.dataAdapter, p)), (null != l.tokenSeparators || null != l.tokenizer) && (l.dataAdapter = j.Decorate(l.dataAdapter, q)), null != l.query) { var C = b(l.amdBase + "compat/query"); l.dataAdapter = j.Decorate(l.dataAdapter, C) } if (null != l.initSelection) { var D = b(l.amdBase + "compat/initSelection"); l.dataAdapter = j.Decorate(l.dataAdapter, D) } } if (null == l.resultsAdapter && (l.resultsAdapter = c, null != l.ajax && (l.resultsAdapter = j.Decorate(l.resultsAdapter, x)), null != l.placeholder && (l.resultsAdapter = j.Decorate(l.resultsAdapter, w)), l.selectOnClose && (l.resultsAdapter = j.Decorate(l.resultsAdapter, A))), null == l.dropdownAdapter) { if (l.multiple) l.dropdownAdapter = u; else { var E = j.Decorate(u, v); l.dropdownAdapter = E } if (0 !== l.minimumResultsForSearch && (l.dropdownAdapter = j.Decorate(l.dropdownAdapter, z)), l.closeOnSelect && (l.dropdownAdapter = j.Decorate(l.dropdownAdapter, B)), null != l.dropdownCssClass || null != l.dropdownCss || null != l.adaptDropdownCssClass) { var F = b(l.amdBase + "compat/dropdownCss"); l.dropdownAdapter = j.Decorate(l.dropdownAdapter, F) } l.dropdownAdapter = j.Decorate(l.dropdownAdapter, y) } if (null == l.selectionAdapter) { if (l.selectionAdapter = l.multiple ? e : d, null != l.placeholder && (l.selectionAdapter = j.Decorate(l.selectionAdapter, f)), l.allowClear && (l.selectionAdapter = j.Decorate(l.selectionAdapter, g)), l.multiple && (l.selectionAdapter = j.Decorate(l.selectionAdapter, h)), null != l.containerCssClass || null != l.containerCss || null != l.adaptContainerCssClass) { var G = b(l.amdBase + "compat/containerCss"); l.selectionAdapter = j.Decorate(l.selectionAdapter, G) } l.selectionAdapter = j.Decorate(l.selectionAdapter, i) } if ("string" == typeof l.language) if (l.language.indexOf("-") > 0) { var H = l.language.split("-"), I = H[0]; l.language = [l.language, I] } else l.language = [l.language]; if (a.isArray(l.language)) { var J = new k; l.language.push("en"); for (var K = l.language, L = 0; L < K.length; L++) { var M = K[L], N = {}; try { N = k.loadPath(M) } catch (O) { try { M = this.defaults.amdLanguageBase + M, N = k.loadPath(M) } catch (P) { l.debug && window.console && console.warn && console.warn('Select2: The language file for "' + M + '" could not be automatically loaded. A fallback will be used instead.'); continue } } J.extend(N) } l.translations = J } else { var Q = k.loadPath(this.defaults.amdLanguageBase + "en"), R = new k(l.language); R.extend(Q), l.translations = R } return l }, D.prototype.reset = function () { function b(a) { function b(a) { return l[a] || a } return a.replace(/[^\u0000-\u007E]/g, b) } function c(d, e) { if ("" === a.trim(d.term)) return e; if (e.children && e.children.length > 0) { for (var f = a.extend(!0, {}, e), g = e.children.length - 1; g >= 0; g--) { var h = e.children[g], i = c(d, h); null == i && f.children.splice(g, 1) } return f.children.length > 0 ? f : c(d, f) } var j = b(e.text).toUpperCase(), k = b(d.term).toUpperCase(); return j.indexOf(k) > -1 ? e : null } this.defaults = { amdBase: "./", amdLanguageBase: "./i18n/", closeOnSelect: !0, debug: !1, dropdownAutoWidth: !1, escapeMarkup: j.escapeMarkup, language: C, matcher: c, minimumInputLength: 0, maximumInputLength: 0, maximumSelectionLength: 0, minimumResultsForSearch: 0, selectOnClose: !1, sorter: function (a) { return a }, templateResult: function (a) { return a.text }, templateSelection: function (a) { return a.text }, theme: "default", width: "resolve" } }, D.prototype.set = function (b, c) { var d = a.camelCase(b), e = {}; e[d] = c; var f = j._convertData(e); a.extend(this.defaults, f) }; var E = new D; return E }), b.define("select2/options", ["require", "jquery", "./defaults", "./utils"], function (a, b, c, d) { function e(b, e) { if (this.options = b, null != e && this.fromElement(e), this.options = c.apply(this.options), e && e.is("input")) { var f = a(this.get("amdBase") + "compat/inputData"); this.options.dataAdapter = d.Decorate(this.options.dataAdapter, f) } } return e.prototype.fromElement = function (a) { var c = ["select2"]; null == this.options.multiple && (this.options.multiple = a.prop("multiple")), null == this.options.disabled && (this.options.disabled = a.prop("disabled")), null == this.options.language && (a.prop("lang") ? this.options.language = a.prop("lang").toLowerCase() : a.closest("[lang]").prop("lang") && (this.options.language = a.closest("[lang]").prop("lang"))), null == this.options.dir && (this.options.dir = a.prop("dir") ? a.prop("dir") : a.closest("[dir]").prop("dir") ? a.closest("[dir]").prop("dir") : "ltr"), a.prop("disabled", this.options.disabled), a.prop("multiple", this.options.multiple), a.data("select2Tags") && (this.options.debug && window.console && console.warn && console.warn('Select2: The `data-select2-tags` attribute has been changed to use the `data-data` and `data-tags="true"` attributes and will be removed in future versions of Select2.'), a.data("data", a.data("select2Tags")), a.data("tags", !0)), a.data("ajaxUrl") && (this.options.debug && window.console && console.warn && console.warn("Select2: The `data-ajax-url` attribute has been changed to `data-ajax--url` and support for the old attribute will be removed in future versions of Select2."), a.attr("ajax--url", a.data("ajaxUrl")), a.data("ajax--url", a.data("ajaxUrl"))); var e = {}; e = b.fn.jquery && "1." == b.fn.jquery.substr(0, 2) && a[0].dataset ? b.extend(!0, {}, a[0].dataset, a.data()) : a.data(); var f = b.extend(!0, {}, e); f = d._convertData(f); for (var g in f) b.inArray(g, c) > -1 || (b.isPlainObject(this.options[g]) ? b.extend(this.options[g], f[g]) : this.options[g] = f[g]); return this }, e.prototype.get = function (a) { return this.options[a] }, e.prototype.set = function (a, b) { this.options[a] = b }, e }), b.define("select2/core", ["jquery", "./options", "./utils", "./keys"], function (a, b, c, d) { var e = function (a, c) { null != a.data("select2") && a.data("select2").destroy(), this.$element = a, this.id = this._generateId(a), c = c || {}, this.options = new b(c, a), e.__super__.constructor.call(this); var d = a.attr("tabindex") || 0; a.data("old-tabindex", d), a.attr("tabindex", "-1"); var f = this.options.get("dataAdapter"); this.dataAdapter = new f(a, this.options); var g = this.render(); this._placeContainer(g); var h = this.options.get("selectionAdapter"); this.selection = new h(a, this.options), this.$selection = this.selection.render(), this.selection.position(this.$selection, g); var i = this.options.get("dropdownAdapter"); this.dropdown = new i(a, this.options), this.$dropdown = this.dropdown.render(), this.dropdown.position(this.$dropdown, g); var j = this.options.get("resultsAdapter"); this.results = new j(a, this.options, this.dataAdapter), this.$results = this.results.render(), this.results.position(this.$results, this.$dropdown); var k = this; this._bindAdapters(), this._registerDomEvents(), this._registerDataEvents(), this._registerSelectionEvents(), this._registerDropdownEvents(), this._registerResultsEvents(), this._registerEvents(), this.dataAdapter.current(function (a) { k.trigger("selection:update", { data: a }) }), a.addClass("select2-hidden-accessible"), a.attr("aria-hidden", "true"), this._syncAttributes(), a.data("select2", this) }; return c.Extend(e, c.Observable), e.prototype._generateId = function (a) { var b = ""; return b = null != a.attr("id") ? a.attr("id") : null != a.attr("name") ? a.attr("name") + "-" + c.generateChars(2) : c.generateChars(4), b = "select2-" + b }, e.prototype._placeContainer = function (a) { a.insertAfter(this.$element); var b = this._resolveWidth(this.$element, this.options.get("width")); null != b && a.css("width", b) }, e.prototype._resolveWidth = function (a, b) { var c = /^width:(([-+]?([0-9]*\.)?[0-9]+)(px|em|ex|%|in|cm|mm|pt|pc))/i; if ("resolve" == b) { var d = this._resolveWidth(a, "style"); return null != d ? d : this._resolveWidth(a, "element") } if ("element" == b) { var e = a.outerWidth(!1); return 0 >= e ? "auto" : e + "px" } if ("style" == b) { var f = a.attr("style"); if ("string" != typeof f) return null; for (var g = f.split(";"), h = 0, i = g.length; i > h; h += 1) { var j = g[h].replace(/\s/g, ""), k = j.match(c); if (null !== k && k.length >= 1) return k[1] } return null } return b }, e.prototype._bindAdapters = function () { this.dataAdapter.bind(this, this.$container), this.selection.bind(this, this.$container), this.dropdown.bind(this, this.$container), this.results.bind(this, this.$container) }, e.prototype._registerDomEvents = function () { var b = this; this.$element.on("change.select2", function () { b.dataAdapter.current(function (a) { b.trigger("selection:update", { data: a }) }) }), this._sync = c.bind(this._syncAttributes, this), this.$element[0].attachEvent && this.$element[0].attachEvent("onpropertychange", this._sync); var d = window.MutationObserver || window.WebKitMutationObserver || window.MozMutationObserver; null != d ? (this._observer = new d(function (c) { a.each(c, b._sync) }), this._observer.observe(this.$element[0], { attributes: !0, subtree: !1 })) : this.$element[0].addEventListener && this.$element[0].addEventListener("DOMAttrModified", b._sync, !1) }, e.prototype._registerDataEvents = function () { var a = this; this.dataAdapter.on("*", function (b, c) { a.trigger(b, c) }) }, e.prototype._registerSelectionEvents = function () { var b = this, c = ["toggle"]; this.selection.on("toggle", function () { b.toggleDropdown() }), this.selection.on("*", function (d, e) { -1 === a.inArray(d, c) && b.trigger(d, e) }) }, e.prototype._registerDropdownEvents = function () { var a = this; this.dropdown.on("*", function (b, c) { a.trigger(b, c) }) }, e.prototype._registerResultsEvents = function () { var a = this; this.results.on("*", function (b, c) { a.trigger(b, c) }) }, e.prototype._registerEvents = function () { var a = this; this.on("open", function () { a.$container.addClass("select2-container--open") }), this.on("close", function () { a.$container.removeClass("select2-container--open") }), this.on("enable", function () { a.$container.removeClass("select2-container--disabled") }), this.on("disable", function () { a.$container.addClass("select2-container--disabled") }), this.on("focus", function () { a.$container.addClass("select2-container--focus") }), this.on("blur", function () { a.$container.removeClass("select2-container--focus") }), this.on("query", function (b) { a.isOpen() || a.trigger("open"), this.dataAdapter.query(b, function (c) { a.trigger("results:all", { data: c, query: b }) }) }), this.on("query:append", function (b) { this.dataAdapter.query(b, function (c) { a.trigger("results:append", { data: c, query: b }) }) }), this.on("keypress", function (b) { var c = b.which; a.isOpen() ? c === d.ENTER ? (a.trigger("results:select"), b.preventDefault()) : c === d.SPACE && b.ctrlKey ? (a.trigger("results:toggle"), b.preventDefault()) : c === d.UP ? (a.trigger("results:previous"), b.preventDefault()) : c === d.DOWN ? (a.trigger("results:next"), b.preventDefault()) : (c === d.ESC || c === d.TAB) && (a.close(), b.preventDefault()) : (c === d.ENTER || c === d.SPACE || (c === d.DOWN || c === d.UP) && b.altKey) && (a.open(), b.preventDefault()) }) }, e.prototype._syncAttributes = function () { this.options.set("disabled", this.$element.prop("disabled")), this.options.get("disabled") ? (this.isOpen() && this.close(), this.trigger("disable")) : this.trigger("enable") }, e.prototype.trigger = function (a, b) { var c = e.__super__.trigger, d = { open: "opening", close: "closing", select: "selecting", unselect: "unselecting" }; if (a in d) { var f = d[a], g = { prevented: !1, name: a, args: b }; if (c.call(this, f, g), g.prevented) return void (b.prevented = !0) } c.call(this, a, b) }, e.prototype.toggleDropdown = function () { this.options.get("disabled") || (this.isOpen() ? this.close() : this.open()) }, e.prototype.open = function () { this.isOpen() || (this.trigger("query", {}), this.trigger("open")) }, e.prototype.close = function () { this.isOpen() && this.trigger("close") }, e.prototype.isOpen = function () { return this.$container.hasClass("select2-container--open") }, e.prototype.enable = function (a) { this.options.get("debug") && window.console && console.warn && console.warn('Select2: The `select2("enable")` method has been deprecated and will be removed in later Select2 versions. Use $element.prop("disabled") instead.'), (null == a || 0 === a.length) && (a = [!0]); var b = !a[0]; this.$element.prop("disabled", b) }, e.prototype.data = function () { this.options.get("debug") && arguments.length > 0 && window.console && console.warn && console.warn('Select2: Data can no longer be set using `select2("data")`. You should consider setting the value instead using `$element.val()`.'); var a = []; return this.dataAdapter.current(function (b) { a = b }), a }, e.prototype.val = function (b) { if (this.options.get("debug") && window.console && console.warn && console.warn('Select2: The `select2("val")` method has been deprecated and will be removed in later Select2 versions. Use $element.val() instead.'), null == b || 0 === b.length) return this.$element.val(); var c = b[0]; a.isArray(c) && (c = a.map(c, function (a) { return a.toString() })), this.$element.val(c).trigger("change") }, e.prototype.destroy = function () { this.$container.remove(), this.$element[0].detachEvent && this.$element[0].detachEvent("onpropertychange", this._sync), null != this._observer ? (this._observer.disconnect(), this._observer = null) : this.$element[0].removeEventListener && this.$element[0].removeEventListener("DOMAttrModified", this._sync, !1), this._sync = null, this.$element.off(".select2"), this.$element.attr("tabindex", this.$element.data("old-tabindex")), this.$element.removeClass("select2-hidden-accessible"), this.$element.attr("aria-hidden", "false"), this.$element.removeData("select2"), this.dataAdapter.destroy(), this.selection.destroy(), this.dropdown.destroy(), this.results.destroy(), this.dataAdapter = null, this.selection = null, this.dropdown = null, this.results = null }, e.prototype.render = function () { var b = a('<span class="select2 select2-container"><span class="selection"></span><span class="dropdown-wrapper" aria-hidden="true"></span></span>'); return b.attr("dir", this.options.get("dir")), this.$container = b, this.$container.addClass("select2-container--" + this.options.get("theme")), b.data("element", this.$element), b }, e }), b.define("select2/compat/utils", ["jquery"], function (a) { function b(b, c, d) { var e, f, g = []; e = a.trim(b.attr("class")), e && (e = "" + e, a(e.split(/\s+/)).each(function () { 0 === this.indexOf("select2-") && g.push(this) })), e = a.trim(c.attr("class")), e && (e = "" + e, a(e.split(/\s+/)).each(function () { 0 !== this.indexOf("select2-") && (f = d(this), null != f && g.push(f)) })), b.attr("class", g.join(" ")) } return { syncCssClasses: b } }), b.define("select2/compat/containerCss", ["jquery", "./utils"], function (a, b) { function c() { return null } function d() { } return d.prototype.render = function (d) { var e = d.call(this), f = this.options.get("containerCssClass") || ""; a.isFunction(f) && (f = f(this.$element)); var g = this.options.get("adaptContainerCssClass"); if (g = g || c, -1 !== f.indexOf(":all:")) { f = f.replace(":all", ""); var h = g; g = function (a) { var b = h(a); return null != b ? b + " " + a : a } } var i = this.options.get("containerCss") || {}; return a.isFunction(i) && (i = i(this.$element)), b.syncCssClasses(e, this.$element, g), e.css(i), e.addClass(f), e }, d }), b.define("select2/compat/dropdownCss", ["jquery", "./utils"], function (a, b) { function c() { return null } function d() { } return d.prototype.render = function (d) { var e = d.call(this), f = this.options.get("dropdownCssClass") || ""; a.isFunction(f) && (f = f(this.$element)); var g = this.options.get("adaptDropdownCssClass"); if (g = g || c, -1 !== f.indexOf(":all:")) { f = f.replace(":all", ""); var h = g; g = function (a) { var b = h(a); return null != b ? b + " " + a : a } } var i = this.options.get("dropdownCss") || {}; return a.isFunction(i) && (i = i(this.$element)), b.syncCssClasses(e, this.$element, g), e.css(i), e.addClass(f), e }, d }), b.define("select2/compat/initSelection", ["jquery"], function (a) { function b(a, b, c) { c.get("debug") && window.console && console.warn && console.warn("Select2: The `initSelection` option has been deprecated in favor of a custom data adapter that overrides the `current` method. This method is now called multiple times instead of a single time when the instance is initialized. Support will be removed for the `initSelection` option in future versions of Select2"), this.initSelection = c.get("initSelection"), this._isInitialized = !1, a.call(this, b, c) } return b.prototype.current = function (b, c) { var d = this; return this._isInitialized ? void b.call(this, c) : void this.initSelection.call(null, this.$element, function (b) { d._isInitialized = !0, a.isArray(b) || (b = [b]), c(b) }) }, b }), b.define("select2/compat/inputData", ["jquery"], function (a) {
            function b(a, b, c) { this._currentData = [], this._valueSeparator = c.get("valueSeparator") || ",", "hidden" === b.prop("type") && c.get("debug") && console && console.warn && console.warn("Select2: Using a hidden input with Select2 is no longer supported and may stop working in the future. It is recommended to use a `<select>` element instead."), a.call(this, b, c) } return b.prototype.current = function (b, c) { function d(b, c) { var e = []; return b.selected || -1 !== a.inArray(b.id, c) ? (b.selected = !0, e.push(b)) : b.selected = !1, b.children && e.push.apply(e, d(b.children, c)), e } for (var e = [], f = 0; f < this._currentData.length; f++) { var g = this._currentData[f]; e.push.apply(e, d(g, this.$element.val().split(this._valueSeparator))) } c(e) }, b.prototype.select = function (b, c) { if (this.options.get("multiple")) { var d = this.$element.val(); d += this._valueSeparator + c.id, this.$element.val(d), this.$element.trigger("change") } else this.current(function (b) { a.map(b, function (a) { a.selected = !1 }) }), this.$element.val(c.id), this.$element.trigger("change") }, b.prototype.unselect = function (a, b) {
                var c = this; b.selected = !1, this.current(function (a) {
                    for (var d = [], e = 0; e < a.length; e++) {
                        var f = a[e];
                        b.id != f.id && d.push(f.id)
                    } c.$element.val(d.join(c._valueSeparator)), c.$element.trigger("change")
                })
            }, b.prototype.query = function (a, b, c) { for (var d = [], e = 0; e < this._currentData.length; e++) { var f = this._currentData[e], g = this.matches(b, f); null !== g && d.push(g) } c({ results: d }) }, b.prototype.addOptions = function (b, c) { var d = a.map(c, function (b) { return a.data(b[0], "data") }); this._currentData.push.apply(this._currentData, d) }, b
        }), b.define("select2/compat/matcher", ["jquery"], function (a) { function b(b) { function c(c, d) { var e = a.extend(!0, {}, d); if (null == c.term || "" === a.trim(c.term)) return e; if (d.children) { for (var f = d.children.length - 1; f >= 0; f--) { var g = d.children[f], h = b(c.term, g.text, g); h || e.children.splice(f, 1) } if (e.children.length > 0) return e } return b(c.term, d.text, d) ? e : null } return c } return b }), b.define("select2/compat/query", [], function () { function a(a, b, c) { c.get("debug") && window.console && console.warn && console.warn("Select2: The `query` option has been deprecated in favor of a custom data adapter that overrides the `query` method. Support will be removed for the `query` option in future versions of Select2."), a.call(this, b, c) } return a.prototype.query = function (a, b, c) { b.callback = c; var d = this.options.get("query"); d.call(null, b) }, a }), b.define("select2/dropdown/attachContainer", [], function () { function a(a, b, c) { a.call(this, b, c) } return a.prototype.position = function (a, b, c) { var d = c.find(".dropdown-wrapper"); d.append(b), b.addClass("select2-dropdown--below"), c.addClass("select2-container--below") }, a }), b.define("select2/dropdown/stopPropagation", [], function () { function a() { } return a.prototype.bind = function (a, b, c) { a.call(this, b, c); var d = ["blur", "change", "click", "dblclick", "focus", "focusin", "focusout", "input", "keydown", "keyup", "keypress", "mousedown", "mouseenter", "mouseleave", "mousemove", "mouseover", "mouseup", "search", "touchend", "touchstart"]; this.$dropdown.on(d.join(" "), function (a) { a.stopPropagation() }) }, a }), b.define("select2/selection/stopPropagation", [], function () { function a() { } return a.prototype.bind = function (a, b, c) { a.call(this, b, c); var d = ["blur", "change", "click", "dblclick", "focus", "focusin", "focusout", "input", "keydown", "keyup", "keypress", "mousedown", "mouseenter", "mouseleave", "mousemove", "mouseover", "mouseup", "search", "touchend", "touchstart"]; this.$selection.on(d.join(" "), function (a) { a.stopPropagation() }) }, a }), b.define("jquery.select2", ["jquery", "require", "./select2/core", "./select2/defaults"], function (a, b, c, d) { if (b("jquery.mousewheel"), null == a.fn.select2) { var e = ["open", "close", "destroy"]; a.fn.select2 = function (b) { if (b = b || {}, "object" == typeof b) return this.each(function () { { var d = a.extend({}, b, !0); new c(a(this), d) } }), this; if ("string" == typeof b) { var d = this.data("select2"); null == d && window.console && console.error && console.error("The select2('" + b + "') method was called on an element that is not using Select2."); var f = Array.prototype.slice.call(arguments, 1), g = d[b](f); return a.inArray(b, e) > -1 ? this : g } throw new Error("Invalid arguments for Select2: " + b) } } return null == a.fn.select2.defaults && (a.fn.select2.defaults = d), c }), function (c) { "function" == typeof b.define && b.define.amd ? b.define("jquery.mousewheel", ["jquery"], c) : "object" == typeof exports ? module.exports = c : c(a) }(function (a) { function b(b) { var g = b || window.event, h = i.call(arguments, 1), j = 0, l = 0, m = 0, n = 0, o = 0, p = 0; if (b = a.event.fix(g), b.type = "mousewheel", "detail" in g && (m = -1 * g.detail), "wheelDelta" in g && (m = g.wheelDelta), "wheelDeltaY" in g && (m = g.wheelDeltaY), "wheelDeltaX" in g && (l = -1 * g.wheelDeltaX), "axis" in g && g.axis === g.HORIZONTAL_AXIS && (l = -1 * m, m = 0), j = 0 === m ? l : m, "deltaY" in g && (m = -1 * g.deltaY, j = m), "deltaX" in g && (l = g.deltaX, 0 === m && (j = -1 * l)), 0 !== m || 0 !== l) { if (1 === g.deltaMode) { var q = a.data(this, "mousewheel-line-height"); j *= q, m *= q, l *= q } else if (2 === g.deltaMode) { var r = a.data(this, "mousewheel-page-height"); j *= r, m *= r, l *= r } if (n = Math.max(Math.abs(m), Math.abs(l)), (!f || f > n) && (f = n, d(g, n) && (f /= 40)), d(g, n) && (j /= 40, l /= 40, m /= 40), j = Math[j >= 1 ? "floor" : "ceil"](j / f), l = Math[l >= 1 ? "floor" : "ceil"](l / f), m = Math[m >= 1 ? "floor" : "ceil"](m / f), k.settings.normalizeOffset && this.getBoundingClientRect) { var s = this.getBoundingClientRect(); o = b.clientX - s.left, p = b.clientY - s.top } return b.deltaX = l, b.deltaY = m, b.deltaFactor = f, b.offsetX = o, b.offsetY = p, b.deltaMode = 0, h.unshift(b, j, l, m), e && clearTimeout(e), e = setTimeout(c, 200), (a.event.dispatch || a.event.handle).apply(this, h) } } function c() { f = null } function d(a, b) { return k.settings.adjustOldDeltas && "mousewheel" === a.type && b % 120 === 0 } var e, f, g = ["wheel", "mousewheel", "DOMMouseScroll", "MozMousePixelScroll"], h = "onwheel" in document || document.documentMode >= 9 ? ["wheel"] : ["mousewheel", "DomMouseScroll", "MozMousePixelScroll"], i = Array.prototype.slice; if (a.event.fixHooks) for (var j = g.length; j;) a.event.fixHooks[g[--j]] = a.event.mouseHooks; var k = a.event.special.mousewheel = { version: "3.1.12", setup: function () { if (this.addEventListener) for (var c = h.length; c;) this.addEventListener(h[--c], b, !1); else this.onmousewheel = b; a.data(this, "mousewheel-line-height", k.getLineHeight(this)), a.data(this, "mousewheel-page-height", k.getPageHeight(this)) }, teardown: function () { if (this.removeEventListener) for (var c = h.length; c;) this.removeEventListener(h[--c], b, !1); else this.onmousewheel = null; a.removeData(this, "mousewheel-line-height"), a.removeData(this, "mousewheel-page-height") }, getLineHeight: function (b) { var c = a(b), d = c["offsetParent" in a.fn ? "offsetParent" : "parent"](); return d.length || (d = a("body")), parseInt(d.css("fontSize"), 10) || parseInt(c.css("fontSize"), 10) || 16 }, getPageHeight: function (b) { return a(b).height() }, settings: { adjustOldDeltas: !0, normalizeOffset: !0 } }; a.fn.extend({ mousewheel: function (a) { return a ? this.bind("mousewheel", a) : this.trigger("mousewheel") }, unmousewheel: function (a) { return this.unbind("mousewheel", a) } }) }), { define: b.define, require: b.require }
    }(), c = b.require("jquery.select2"); return a.fn.select2.amd = b, c
});

/*! Summernote v0.6.16 | (c) 2013-2015 Alan Hong and other contributors | MIT license */
!function (a) { "function" == typeof define && define.amd ? define(["jquery"], a) : a(window.jQuery) }(function (a) {
    Array.prototype.reduce || (Array.prototype.reduce = function (a) { var b, c = Object(this), d = c.length >>> 0, e = 0; if (2 === arguments.length) b = arguments[1]; else { for (; d > e && !(e in c) ;) e++; if (e >= d) throw new TypeError("Reduce of empty array with no initial value"); b = c[e++] } for (; d > e; e++) e in c && (b = a(b, c[e], e, c)); return b }), "function" != typeof Array.prototype.filter && (Array.prototype.filter = function (a) { for (var b = Object(this), c = b.length >>> 0, d = [], e = arguments.length >= 2 ? arguments[1] : void 0, f = 0; c > f; f++) if (f in b) { var g = b[f]; a.call(e, g, f, b) && d.push(g) } return d }), Array.prototype.map || (Array.prototype.map = function (a, b) { var c, d, e; if (null === this) throw new TypeError(" this is null or not defined"); var f = Object(this), g = f.length >>> 0; if ("function" != typeof a) throw new TypeError(a + " is not a function"); for (arguments.length > 1 && (c = b), d = new Array(g), e = 0; g > e;) { var h, i; e in f && (h = f[e], i = a.call(c, h, e, f), d[e] = i), e++ } return d }); var b, c = "function" == typeof define && define.amd, d = function (b) { var c = "Comic Sans MS" === b ? "Courier New" : "Comic Sans MS", d = a("<div>").css({ position: "absolute", left: "-9999px", top: "-9999px", fontSize: "200px" }).text("mmmmmmmmmwwwwwww").appendTo(document.body), e = d.css("fontFamily", c).width(), f = d.css("fontFamily", b + "," + c).width(); return d.remove(), e !== f }, e = navigator.userAgent, f = /MSIE|Trident/i.test(e); if (f) { var g = /MSIE (\d+[.]\d+)/.exec(e); g && (b = parseFloat(g[1])), g = /Trident\/.*rv:([0-9]{1,}[\.0-9]{0,})/.exec(e), g && (b = parseFloat(g[1])) } var h, i = { isMac: navigator.appVersion.indexOf("Mac") > -1, isMSIE: f, isFF: /firefox/i.test(e), isWebkit: /webkit/i.test(e), isSafari: /safari/i.test(e), browserVersion: b, jqueryVersion: parseFloat(a.fn.jquery), isSupportAmd: c, hasCodeMirror: c ? require.specified("CodeMirror") : !!window.CodeMirror, isFontInstalled: d, isW3CRangeSupport: !!document.createRange }, j = function () { var b = function (a) { return function (b) { return a === b } }, c = function (a, b) { return a === b }, d = function (a) { return function (b, c) { return b[a] === c[a] } }, e = function () { return !0 }, f = function () { return !1 }, g = function (a) { return function () { return !a.apply(a, arguments) } }, h = function (a, b) { return function (c) { return a(c) && b(c) } }, i = function (a) { return a }, j = 0, k = function (a) { var b = ++j + ""; return a ? a + b : b }, l = function (b) { var c = a(document); return { top: b.top + c.scrollTop(), left: b.left + c.scrollLeft(), width: b.right - b.left, height: b.bottom - b.top } }, m = function (a) { var b = {}; for (var c in a) a.hasOwnProperty(c) && (b[a[c]] = c); return b }, n = function (a, b) { return b = b || "", b + a.split(".").map(function (a) { return a.substring(0, 1).toUpperCase() + a.substring(1) }).join("") }; return { eq: b, eq2: c, peq2: d, ok: e, fail: f, self: i, not: g, and: h, uniqueId: k, rect2bnd: l, invertObject: m, namespaceToCamel: n } }(), k = function () { var b = function (a) { return a[0] }, c = function (a) { return a[a.length - 1] }, d = function (a) { return a.slice(0, a.length - 1) }, e = function (a) { return a.slice(1) }, f = function (a, b) { for (var c = 0, d = a.length; d > c; c++) { var e = a[c]; if (b(e)) return e } }, g = function (a, b) { for (var c = 0, d = a.length; d > c; c++) if (!b(a[c])) return !1; return !0 }, h = function (b, c) { return a.inArray(c, b) }, i = function (a, b) { return -1 !== h(a, b) }, k = function (a, b) { return b = b || j.self, a.reduce(function (a, c) { return a + b(c) }, 0) }, l = function (a) { for (var b = [], c = -1, d = a.length; ++c < d;) b[c] = a[c]; return b }, m = function (a, d) { if (!a.length) return []; var f = e(a); return f.reduce(function (a, b) { var e = c(a); return d(c(e), b) ? e[e.length] = b : a[a.length] = [b], a }, [[b(a)]]) }, n = function (a) { for (var b = [], c = 0, d = a.length; d > c; c++) a[c] && b.push(a[c]); return b }, o = function (a) { for (var b = [], c = 0, d = a.length; d > c; c++) i(b, a[c]) || b.push(a[c]); return b }, p = function (a, b) { var c = h(a, b); return -1 === c ? null : a[c + 1] }, q = function (a, b) { var c = h(a, b); return -1 === c ? null : a[c - 1] }; return { head: b, last: c, initial: d, tail: e, prev: q, next: p, find: f, contains: i, all: g, sum: k, from: l, clusterBy: m, compact: n, unique: o } }(), l = String.fromCharCode(160), m = "\ufeff", n = function () { var b = function (b) { return b && a(b).hasClass("note-editable") }, c = function (b) { return b && a(b).hasClass("note-control-sizing") }, d = function (b) { var c; if (b.hasClass("note-air-editor")) { var d = k.last(b.attr("id").split("-")); return c = function (b) { return function () { return a(b + d) } }, { editor: function () { return b }, holder: function () { return b.data("holder") }, editable: function () { return b }, popover: c("#note-popover-"), handle: c("#note-handle-"), dialog: c("#note-dialog-") } } c = function (a, c) { return c = c || b, function () { return c.find(a) } }; var e = b.data("options"), f = e && e.dialogsInBody ? a(document.body) : null; return { editor: function () { return b }, holder: function () { return b.data("holder") }, dropzone: c(".note-dropzone"), toolbar: c(".note-toolbar"), editable: c(".note-editable"), codable: c(".note-codable"), statusbar: c(".note-statusbar"), popover: c(".note-popover"), handle: c(".note-handle"), dialog: c(".note-dialog", f) } }, e = function (b) { var c = a(b).closest(".note-editor, .note-air-editor, .note-air-layout"); if (!c.length) return null; var e; return e = c.is(".note-editor, .note-air-editor") ? c : a("#note-editor-" + k.last(c.attr("id").split("-"))), d(e) }, f = function (a) { return a = a.toUpperCase(), function (b) { return b && b.nodeName.toUpperCase() === a } }, g = function (a) { return a && 3 === a.nodeType }, h = function (a) { return a && /^BR|^IMG|^HR|^IFRAME|^BUTTON/.test(a.nodeName.toUpperCase()) }, o = function (a) { return b(a) ? !1 : a && /^DIV|^P|^LI|^H[1-7]/.test(a.nodeName.toUpperCase()) }, p = f("LI"), q = function (a) { return o(a) && !p(a) }, r = f("TABLE"), s = function (a) { return !(x(a) || t(a) || u(a) || o(a) || r(a) || w(a)) }, t = function (a) { return a && /^UL|^OL/.test(a.nodeName.toUpperCase()) }, u = f("HR"), v = function (a) { return a && /^TD|^TH/.test(a.nodeName.toUpperCase()) }, w = f("BLOCKQUOTE"), x = function (a) { return v(a) || w(a) || b(a) }, y = f("A"), z = function (a) { return s(a) && !!I(a, o) }, A = function (a) { return s(a) && !I(a, o) }, B = f("BODY"), C = function (a, b) { return a.nextSibling === b || a.previousSibling === b }, D = function (a, b) { b = b || j.ok; var c = []; return a.previousSibling && b(a.previousSibling) && c.push(a.previousSibling), c.push(a), a.nextSibling && b(a.nextSibling) && c.push(a.nextSibling), c }, E = i.isMSIE && i.browserVersion < 11 ? "&nbsp;" : "<br>", F = function (a) { return g(a) ? a.nodeValue.length : a.childNodes.length }, G = function (a) { var b = F(a); return 0 === b ? !0 : g(a) || 1 !== b || a.innerHTML !== E ? k.all(a.childNodes, g) && "" === a.innerHTML ? !0 : !1 : !0 }, H = function (a) { h(a) || F(a) || (a.innerHTML = E) }, I = function (a, c) { for (; a;) { if (c(a)) return a; if (b(a)) break; a = a.parentNode } return null }, J = function (a, c) { for (a = a.parentNode; a && 1 === F(a) ;) { if (c(a)) return a; if (b(a)) break; a = a.parentNode } return null }, K = function (a, c) { c = c || j.fail; var d = []; return I(a, function (a) { return b(a) || d.push(a), c(a) }), d }, L = function (a, b) { var c = K(a); return k.last(c.filter(b)) }, M = function (b, c) { for (var d = K(b), e = c; e; e = e.parentNode) if (a.inArray(e, d) > -1) return e; return null }, N = function (a, b) { b = b || j.fail; for (var c = []; a && !b(a) ;) c.push(a), a = a.previousSibling; return c }, O = function (a, b) { b = b || j.fail; for (var c = []; a && !b(a) ;) c.push(a), a = a.nextSibling; return c }, P = function (a, b) { var c = []; return b = b || j.ok, function d(e) { a !== e && b(e) && c.push(e); for (var f = 0, g = e.childNodes.length; g > f; f++) d(e.childNodes[f]) }(a), c }, Q = function (b, c) { var d = b.parentNode, e = a("<" + c + ">")[0]; return d.insertBefore(e, b), e.appendChild(b), e }, R = function (a, b) { var c = b.nextSibling, d = b.parentNode; return c ? d.insertBefore(a, c) : d.appendChild(a), a }, S = function (b, c) { return a.each(c, function (a, c) { b.appendChild(c) }), b }, T = function (a) { return 0 === a.offset }, U = function (a) { return a.offset === F(a.node) }, V = function (a) { return T(a) || U(a) }, W = function (a, b) { for (; a && a !== b;) { if (0 !== $(a)) return !1; a = a.parentNode } return !0 }, X = function (a, b) { for (; a && a !== b;) { if ($(a) !== F(a.parentNode) - 1) return !1; a = a.parentNode } return !0 }, Y = function (a, b) { return T(a) && W(a.node, b) }, Z = function (a, b) { return U(a) && X(a.node, b) }, $ = function (a) { for (var b = 0; a = a.previousSibling;) b += 1; return b }, _ = function (a) { return !!(a && a.childNodes && a.childNodes.length) }, aa = function (a, c) { var d, e; if (0 === a.offset) { if (b(a.node)) return null; d = a.node.parentNode, e = $(a.node) } else _(a.node) ? (d = a.node.childNodes[a.offset - 1], e = F(d)) : (d = a.node, e = c ? 0 : a.offset - 1); return { node: d, offset: e } }, ba = function (a, c) { var d, e; if (F(a.node) === a.offset) { if (b(a.node)) return null; d = a.node.parentNode, e = $(a.node) + 1 } else _(a.node) ? (d = a.node.childNodes[a.offset], e = 0) : (d = a.node, e = c ? F(a.node) : a.offset + 1); return { node: d, offset: e } }, ca = function (a, b) { return a.node === b.node && a.offset === b.offset }, da = function (a) { if (g(a.node) || !_(a.node) || G(a.node)) return !0; var b = a.node.childNodes[a.offset - 1], c = a.node.childNodes[a.offset]; return b && !h(b) || c && !h(c) ? !1 : !0 }, ea = function (a, b) { for (; a;) { if (b(a)) return a; a = aa(a) } return null }, fa = function (a, b) { for (; a;) { if (b(a)) return a; a = ba(a) } return null }, ga = function (a) { if (!g(a.node)) return !1; var b = a.node.nodeValue.charAt(a.offset - 1); return b && " " !== b && b !== l }, ha = function (a, b, c, d) { for (var e = a; e && (c(e), !ca(e, b)) ;) { var f = d && a.node !== e.node && b.node !== e.node; e = ba(e, f) } }, ia = function (a, b) { var c = K(b, j.eq(a)); return c.map($).reverse() }, ja = function (a, b) { for (var c = a, d = 0, e = b.length; e > d; d++) c = c.childNodes.length <= b[d] ? c.childNodes[c.childNodes.length - 1] : c.childNodes[b[d]]; return c }, ka = function (a, b) { var c = b && b.isSkipPaddingBlankHTML, d = b && b.isNotSplitEdgePoint; if (V(a) && (g(a.node) || d)) { if (T(a)) return a.node; if (U(a)) return a.node.nextSibling } if (g(a.node)) return a.node.splitText(a.offset); var e = a.node.childNodes[a.offset], f = R(a.node.cloneNode(!1), a.node); return S(f, O(e)), c || (H(a.node), H(f)), f }, la = function (a, b, c) { var d = K(b.node, j.eq(a)); return d.length ? 1 === d.length ? ka(b, c) : d.reduce(function (a, d) { return a === b.node && (a = ka(b, c)), ka({ node: d, offset: a ? n.position(a) : F(d) }, c) }) : null }, ma = function (a, b) { var c, d, e = b ? o : x, f = K(a.node, e), g = k.last(f) || a.node; e(g) ? (c = f[f.length - 2], d = g) : (c = g, d = c.parentNode); var h = c && la(c, a, { isSkipPaddingBlankHTML: b, isNotSplitEdgePoint: b }); return h || d !== a.node || (h = a.node.childNodes[a.offset]), { rightNode: h, container: d } }, na = function (a) { return document.createElement(a) }, oa = function (a) { return document.createTextNode(a) }, pa = function (a, b) { if (a && a.parentNode) { if (a.removeNode) return a.removeNode(b); var c = a.parentNode; if (!b) { var d, e, f = []; for (d = 0, e = a.childNodes.length; e > d; d++) f.push(a.childNodes[d]); for (d = 0, e = f.length; e > d; d++) c.insertBefore(f[d], a) } c.removeChild(a) } }, qa = function (a, c) { for (; a && !b(a) && c(a) ;) { var d = a.parentNode; pa(a), a = d } }, ra = function (a, b) { if (a.nodeName.toUpperCase() === b.toUpperCase()) return a; var c = na(b); return a.style.cssText && (c.style.cssText = a.style.cssText), S(c, k.from(a.childNodes)), R(c, a), pa(a), c }, sa = f("TEXTAREA"), ta = function (a, b) { var c = sa(a[0]) ? a.val() : a.html(); return b ? c.replace(/[\n\r]/g, "") : c }, ua = function (b, c) { var d = ta(b); if (c) { var e = /<(\/?)(\b(?!!)[^>\s]*)(.*?)(\s*\/?>)/g; d = d.replace(e, function (a, b, c) { c = c.toUpperCase(); var d = /^DIV|^TD|^TH|^P|^LI|^H[1-7]/.test(c) && !!b, e = /^BLOCKQUOTE|^TABLE|^TBODY|^TR|^HR|^UL|^OL/.test(c); return a + (d || e ? "\n" : "") }), d = a.trim(d) } return d }; return { NBSP_CHAR: l, ZERO_WIDTH_NBSP_CHAR: m, blank: E, emptyPara: "<p>" + E + "</p>", makePredByNodeName: f, isEditable: b, isControlSizing: c, buildLayoutInfo: d, makeLayoutInfo: e, isText: g, isVoid: h, isPara: o, isPurePara: q, isInline: s, isBlock: j.not(s), isBodyInline: A, isBody: B, isParaInline: z, isList: t, isTable: r, isCell: v, isBlockquote: w, isBodyContainer: x, isAnchor: y, isDiv: f("DIV"), isLi: p, isBR: f("BR"), isSpan: f("SPAN"), isB: f("B"), isU: f("U"), isS: f("S"), isI: f("I"), isImg: f("IMG"), isTextarea: sa, isEmpty: G, isEmptyAnchor: j.and(y, G), isClosestSibling: C, withClosestSiblings: D, nodeLength: F, isLeftEdgePoint: T, isRightEdgePoint: U, isEdgePoint: V, isLeftEdgeOf: W, isRightEdgeOf: X, isLeftEdgePointOf: Y, isRightEdgePointOf: Z, prevPoint: aa, nextPoint: ba, isSamePoint: ca, isVisiblePoint: da, prevPointUntil: ea, nextPointUntil: fa, isCharPoint: ga, walkPoint: ha, ancestor: I, singleChildAncestor: J, listAncestor: K, lastAncestor: L, listNext: O, listPrev: N, listDescendant: P, commonAncestor: M, wrap: Q, insertAfter: R, appendChildNodes: S, position: $, hasChildren: _, makeOffsetPath: ia, fromOffsetPath: ja, splitTree: la, splitPoint: ma, create: na, createText: oa, remove: pa, removeWhile: qa, replace: ra, html: ua, value: ta } }(), o = function () { var b = function (a, b) { var c, d, e = a.parentElement(), f = document.body.createTextRange(), g = k.from(e.childNodes); for (c = 0; c < g.length; c++) if (!n.isText(g[c])) { if (f.moveToElementText(g[c]), f.compareEndPoints("StartToStart", a) >= 0) break; d = g[c] } if (0 !== c && n.isText(g[c - 1])) { var h = document.body.createTextRange(), i = null; h.moveToElementText(d || e), h.collapse(!d), i = d ? d.nextSibling : e.firstChild; var j = a.duplicate(); j.setEndPoint("StartToStart", h); for (var l = j.text.replace(/[\r\n]/g, "").length; l > i.nodeValue.length && i.nextSibling;) l -= i.nodeValue.length, i = i.nextSibling; i.nodeValue; b && i.nextSibling && n.isText(i.nextSibling) && l === i.nodeValue.length && (l -= i.nodeValue.length, i = i.nextSibling), e = i, c = l } return { cont: e, offset: c } }, c = function (a) { var b = function (a, c) { var d, e; if (n.isText(a)) { var f = n.listPrev(a, j.not(n.isText)), g = k.last(f).previousSibling; d = g || a.parentNode, c += k.sum(k.tail(f), n.nodeLength), e = !g } else { if (d = a.childNodes[c] || a, n.isText(d)) return b(d, 0); c = 0, e = !1 } return { node: d, collapseToStart: e, offset: c } }, c = document.body.createTextRange(), d = b(a.node, a.offset); return c.moveToElementText(d.node), c.collapse(d.collapseToStart), c.moveStart("character", d.offset), c }, d = function (b, e, f, g) { this.sc = b, this.so = e, this.ec = f, this.eo = g; var h = function () { if (i.isW3CRangeSupport) { var a = document.createRange(); return a.setStart(b, e), a.setEnd(f, g), a } var d = c({ node: b, offset: e }); return d.setEndPoint("EndToEnd", c({ node: f, offset: g })), d }; this.getPoints = function () { return { sc: b, so: e, ec: f, eo: g } }, this.getStartPoint = function () { return { node: b, offset: e } }, this.getEndPoint = function () { return { node: f, offset: g } }, this.select = function () { var a = h(); if (i.isW3CRangeSupport) { var b = document.getSelection(); b.rangeCount > 0 && b.removeAllRanges(), b.addRange(a) } else a.select(); return this }, this.normalize = function () { var a = function (a, b) { if (n.isVisiblePoint(a) && !n.isEdgePoint(a) || n.isVisiblePoint(a) && n.isRightEdgePoint(a) && !b || n.isVisiblePoint(a) && n.isLeftEdgePoint(a) && b || n.isVisiblePoint(a) && n.isBlock(a.node) && n.isEmpty(a.node)) return a; var c = n.ancestor(a.node, n.isBlock); if ((n.isLeftEdgePointOf(a, c) || n.isVoid(n.prevPoint(a).node)) && !b || (n.isRightEdgePointOf(a, c) || n.isVoid(n.nextPoint(a).node)) && b) { if (n.isVisiblePoint(a)) return a; b = !b } var d = b ? n.nextPointUntil(n.nextPoint(a), n.isVisiblePoint) : n.prevPointUntil(n.prevPoint(a), n.isVisiblePoint); return d || a }, b = a(this.getEndPoint(), !1), c = this.isCollapsed() ? b : a(this.getStartPoint(), !0); return new d(c.node, c.offset, b.node, b.offset) }, this.nodes = function (a, b) { a = a || j.ok; var c = b && b.includeAncestor, d = b && b.fullyContains, e = this.getStartPoint(), f = this.getEndPoint(), g = [], h = []; return n.walkPoint(e, f, function (b) { if (!n.isEditable(b.node)) { var e; d ? (n.isLeftEdgePoint(b) && h.push(b.node), n.isRightEdgePoint(b) && k.contains(h, b.node) && (e = b.node)) : e = c ? n.ancestor(b.node, a) : b.node, e && a(e) && g.push(e) } }, !0), k.unique(g) }, this.commonAncestor = function () { return n.commonAncestor(b, f) }, this.expand = function (a) { var c = n.ancestor(b, a), h = n.ancestor(f, a); if (!c && !h) return new d(b, e, f, g); var i = this.getPoints(); return c && (i.sc = c, i.so = 0), h && (i.ec = h, i.eo = n.nodeLength(h)), new d(i.sc, i.so, i.ec, i.eo) }, this.collapse = function (a) { return a ? new d(b, e, b, e) : new d(f, g, f, g) }, this.splitText = function () { var a = b === f, c = this.getPoints(); return n.isText(f) && !n.isEdgePoint(this.getEndPoint()) && f.splitText(g), n.isText(b) && !n.isEdgePoint(this.getStartPoint()) && (c.sc = b.splitText(e), c.so = 0, a && (c.ec = c.sc, c.eo = g - e)), new d(c.sc, c.so, c.ec, c.eo) }, this.deleteContents = function () { if (this.isCollapsed()) return this; var b = this.splitText(), c = b.nodes(null, { fullyContains: !0 }), e = n.prevPointUntil(b.getStartPoint(), function (a) { return !k.contains(c, a.node) }), f = []; return a.each(c, function (a, b) { var c = b.parentNode; e.node !== c && 1 === n.nodeLength(c) && f.push(c), n.remove(b, !1) }), a.each(f, function (a, b) { n.remove(b, !1) }), new d(e.node, e.offset, e.node, e.offset).normalize() }; var l = function (a) { return function () { var c = n.ancestor(b, a); return !!c && c === n.ancestor(f, a) } }; this.isOnEditable = l(n.isEditable), this.isOnList = l(n.isList), this.isOnAnchor = l(n.isAnchor), this.isOnCell = l(n.isCell), this.isLeftEdgeOf = function (a) { if (!n.isLeftEdgePoint(this.getStartPoint())) return !1; var b = n.ancestor(this.sc, a); return b && n.isLeftEdgeOf(this.sc, b) }, this.isCollapsed = function () { return b === f && e === g }, this.wrapBodyInlineWithPara = function () { if (n.isBodyContainer(b) && n.isEmpty(b)) return b.innerHTML = n.emptyPara, new d(b.firstChild, 0, b.firstChild, 0); var a = this.normalize(); if (n.isParaInline(b) || n.isPara(b)) return a; var c; if (n.isInline(a.sc)) { var e = n.listAncestor(a.sc, j.not(n.isInline)); c = k.last(e), n.isInline(c) || (c = e[e.length - 2] || a.sc.childNodes[a.so]) } else c = a.sc.childNodes[a.so > 0 ? a.so - 1 : 0]; var f = n.listPrev(c, n.isParaInline).reverse(); if (f = f.concat(n.listNext(c.nextSibling, n.isParaInline)), f.length) { var g = n.wrap(k.head(f), "p"); n.appendChildNodes(g, k.tail(f)) } return this.normalize() }, this.insertNode = function (a) { var b = this.wrapBodyInlineWithPara().deleteContents(), c = n.splitPoint(b.getStartPoint(), n.isInline(a)); return c.rightNode ? c.rightNode.parentNode.insertBefore(a, c.rightNode) : c.container.appendChild(a), a }, this.pasteHTML = function (b) { var c = a("<div></div>").html(b)[0], d = k.from(c.childNodes), e = this.wrapBodyInlineWithPara().deleteContents(); return d.reverse().map(function (a) { return e.insertNode(a) }).reverse() }, this.toString = function () { var a = h(); return i.isW3CRangeSupport ? a.toString() : a.text }, this.getWordRange = function (a) { var b = this.getEndPoint(); if (!n.isCharPoint(b)) return this; var c = n.prevPointUntil(b, function (a) { return !n.isCharPoint(a) }); return a && (b = n.nextPointUntil(b, function (a) { return !n.isCharPoint(a) })), new d(c.node, c.offset, b.node, b.offset) }, this.bookmark = function (a) { return { s: { path: n.makeOffsetPath(a, b), offset: e }, e: { path: n.makeOffsetPath(a, f), offset: g } } }, this.paraBookmark = function (a) { return { s: { path: k.tail(n.makeOffsetPath(k.head(a), b)), offset: e }, e: { path: k.tail(n.makeOffsetPath(k.last(a), f)), offset: g } } }, this.getClientRects = function () { var a = h(); return a.getClientRects() } }; return { create: function (a, c, e, f) { if (arguments.length) 2 === arguments.length && (e = a, f = c); else if (i.isW3CRangeSupport) { var g = document.getSelection(); if (!g || 0 === g.rangeCount) return null; if (n.isBody(g.anchorNode)) return null; var h = g.getRangeAt(0); a = h.startContainer, c = h.startOffset, e = h.endContainer, f = h.endOffset } else { var j = document.selection.createRange(), k = j.duplicate(); k.collapse(!1); var l = j; l.collapse(!0); var m = b(l, !0), o = b(k, !1); n.isText(m.node) && n.isLeftEdgePoint(m) && n.isTextNode(o.node) && n.isRightEdgePoint(o) && o.node.nextSibling === m.node && (m = o), a = m.cont, c = m.offset, e = o.cont, f = o.offset } return new d(a, c, e, f) }, createFromNode: function (a) { var b = a, c = 0, d = a, e = n.nodeLength(d); return n.isVoid(b) && (c = n.listPrev(b).length - 1, b = b.parentNode), n.isBR(d) ? (e = n.listPrev(d).length - 1, d = d.parentNode) : n.isVoid(d) && (e = n.listPrev(d).length, d = d.parentNode), this.create(b, c, d, e) }, createFromNodeBefore: function (a) { return this.createFromNode(a).collapse(!0) }, createFromNodeAfter: function (a) { return this.createFromNode(a).collapse() }, createFromBookmark: function (a, b) { var c = n.fromOffsetPath(a, b.s.path), e = b.s.offset, f = n.fromOffsetPath(a, b.e.path), g = b.e.offset; return new d(c, e, f, g) }, createFromParaBookmark: function (a, b) { var c = a.s.offset, e = a.e.offset, f = n.fromOffsetPath(k.head(b), a.s.path), g = n.fromOffsetPath(k.last(b), a.e.path); return new d(f, c, g, e) } } }(), p = { version: "0.6.16", options: { width: null, height: null, minHeight: null, maxHeight: null, focus: !1, tabsize: 4, styleWithSpan: !0, disableLinkTarget: !1, disableDragAndDrop: !1, disableResizeEditor: !1, disableResizeImage: !1, shortcuts: !0, textareaAutoSync: !0, placeholder: !1, prettifyHtml: !0, iconPrefix: "fa fa-", icons: { font: { bold: "bold", italic: "italic", underline: "underline", clear: "eraser", height: "text-height", strikethrough: "strikethrough", superscript: "superscript", subscript: "subscript" }, image: { image: "picture-o", floatLeft: "align-left", floatRight: "align-right", floatNone: "align-justify", shapeRounded: "square", shapeCircle: "circle-o", shapeThumbnail: "picture-o", shapeNone: "times", remove: "trash-o" }, link: { link: "link", unlink: "unlink", edit: "edit" }, table: { table: "table" }, hr: { insert: "minus" }, style: { style: "magic" }, lists: { unordered: "list-ul", ordered: "list-ol" }, options: { help: "question", fullscreen: "arrows-alt", codeview: "code" }, paragraph: { paragraph: "align-left", outdent: "outdent", indent: "indent", left: "align-left", center: "align-center", right: "align-right", justify: "align-justify" }, color: { recent: "font" }, history: { undo: "undo", redo: "repeat" }, misc: { check: "check" } }, dialogsInBody: !1, codemirror: { mode: "text/html", htmlMode: !0, lineNumbers: !0 }, lang: "en-US", direction: null, toolbar: [["style", ["style"]], ["font", ["bold", "italic", "underline", "clear"]], ["fontname", ["fontname"]], ["fontsize", ["fontsize"]], ["color", ["color"]], ["para", ["ul", "ol", "paragraph"]], ["height", ["height"]], ["table", ["table"]], ["insert", ["link", "picture", "hr"]], ["view", ["fullscreen", "codeview"]], ["help", ["help"]]], plugin: {}, airMode: !1, airPopover: [["color", ["color"]], ["font", ["bold", "underline", "clear"]], ["para", ["ul", "paragraph"]], ["table", ["table"]], ["insert", ["link", "picture"]]], styleTags: ["p", "blockquote", "pre", "h1", "h2", "h3", "h4", "h5", "h6"], defaultFontName: "Helvetica Neue", fontNames: ["Arial", "Arial Black", "Comic Sans MS", "Courier New", "Helvetica Neue", "Helvetica", "Impact", "Lucida Grande", "Tahoma", "Times New Roman", "Verdana"], fontNamesIgnoreCheck: [], fontSizes: ["8", "9", "10", "11", "12", "14", "18", "24", "36"], colors: [["#000000", "#424242", "#636363", "#9C9C94", "#CEC6CE", "#EFEFEF", "#F7F7F7", "#FFFFFF"], ["#FF0000", "#FF9C00", "#FFFF00", "#00FF00", "#00FFFF", "#0000FF", "#9C00FF", "#FF00FF"], ["#F7C6CE", "#FFE7CE", "#FFEFC6", "#D6EFD6", "#CEDEE7", "#CEE7F7", "#D6D6E7", "#E7D6DE"], ["#E79C9C", "#FFC69C", "#FFE79C", "#B5D6A5", "#A5C6CE", "#9CC6EF", "#B5A5D6", "#D6A5BD"], ["#E76363", "#F7AD6B", "#FFD663", "#94BD7B", "#73A5AD", "#6BADDE", "#8C7BC6", "#C67BA5"], ["#CE0000", "#E79439", "#EFC631", "#6BA54A", "#4A7B8C", "#3984C6", "#634AA5", "#A54A7B"], ["#9C0000", "#B56308", "#BD9400", "#397B21", "#104A5A", "#085294", "#311873", "#731842"], ["#630000", "#7B3900", "#846300", "#295218", "#083139", "#003163", "#21104A", "#4A1031"]], lineHeights: ["1.0", "1.2", "1.4", "1.5", "1.6", "1.8", "2.0", "3.0"], insertTableMaxSize: { col: 10, row: 10 }, maximumImageFileSize: null, oninit: null, onfocus: null, onblur: null, onenter: null, onkeyup: null, onkeydown: null, onImageUpload: null, onImageUploadError: null, onMediaDelete: null, onToolbarClick: null, onsubmit: null, onCreateLink: function (a) { return -1 !== a.indexOf("@") && -1 === a.indexOf(":") && (a = "mailto:" + a), a }, keyMap: { pc: { ENTER: "insertParagraph", "CTRL+Z": "undo", "CTRL+Y": "redo", TAB: "tab", "SHIFT+TAB": "untab", "CTRL+B": "bold", "CTRL+I": "italic", "CTRL+U": "underline", "CTRL+SHIFT+S": "strikethrough", "CTRL+BACKSLASH": "removeFormat", "CTRL+SHIFT+L": "justifyLeft", "CTRL+SHIFT+E": "justifyCenter", "CTRL+SHIFT+R": "justifyRight", "CTRL+SHIFT+J": "justifyFull", "CTRL+SHIFT+NUM7": "insertUnorderedList", "CTRL+SHIFT+NUM8": "insertOrderedList", "CTRL+LEFTBRACKET": "outdent", "CTRL+RIGHTBRACKET": "indent", "CTRL+NUM0": "formatPara", "CTRL+NUM1": "formatH1", "CTRL+NUM2": "formatH2", "CTRL+NUM3": "formatH3", "CTRL+NUM4": "formatH4", "CTRL+NUM5": "formatH5", "CTRL+NUM6": "formatH6", "CTRL+ENTER": "insertHorizontalRule", "CTRL+K": "showLinkDialog" }, mac: { ENTER: "insertParagraph", "CMD+Z": "undo", "CMD+SHIFT+Z": "redo", TAB: "tab", "SHIFT+TAB": "untab", "CMD+B": "bold", "CMD+I": "italic", "CMD+U": "underline", "CMD+SHIFT+S": "strikethrough", "CMD+BACKSLASH": "removeFormat", "CMD+SHIFT+L": "justifyLeft", "CMD+SHIFT+E": "justifyCenter", "CMD+SHIFT+R": "justifyRight", "CMD+SHIFT+J": "justifyFull", "CMD+SHIFT+NUM7": "insertUnorderedList", "CMD+SHIFT+NUM8": "insertOrderedList", "CMD+LEFTBRACKET": "outdent", "CMD+RIGHTBRACKET": "indent", "CMD+NUM0": "formatPara", "CMD+NUM1": "formatH1", "CMD+NUM2": "formatH2", "CMD+NUM3": "formatH3", "CMD+NUM4": "formatH4", "CMD+NUM5": "formatH5", "CMD+NUM6": "formatH6", "CMD+ENTER": "insertHorizontalRule", "CMD+K": "showLinkDialog" } } }, lang: { "en-US": { font: { bold: "Bold", italic: "Italic", underline: "Underline", clear: "Remove Font Style", height: "Line Height", name: "Font Family", strikethrough: "Strikethrough", subscript: "Subscript", superscript: "Superscript", size: "Font Size" }, image: { image: "Picture", insert: "Insert Image", resizeFull: "Resize Full", resizeHalf: "Resize Half", resizeQuarter: "Resize Quarter", floatLeft: "Float Left", floatRight: "Float Right", floatNone: "Float None", shapeRounded: "Shape: Rounded", shapeCircle: "Shape: Circle", shapeThumbnail: "Shape: Thumbnail", shapeNone: "Shape: None", dragImageHere: "Drag image or text here", dropImage: "Drop image or Text", selectFromFiles: "Select from files", maximumFileSize: "Maximum file size", maximumFileSizeError: "Maximum file size exceeded.", url: "Image URL", remove: "Remove Image" }, link: { link: "Link", insert: "Insert Link", unlink: "Unlink", edit: "Edit", textToDisplay: "Text to display", url: "To what URL should this link go?", openInNewWindow: "Open in new window" }, table: { table: "Table" }, hr: { insert: "Insert Horizontal Rule" }, style: { style: "Style", normal: "Normal", blockquote: "Quote", pre: "Code", h1: "Header 1", h2: "Header 2", h3: "Header 3", h4: "Header 4", h5: "Header 5", h6: "Header 6" }, lists: { unordered: "Unordered list", ordered: "Ordered list" }, options: { help: "Help", fullscreen: "Full Screen", codeview: "Code View" }, paragraph: { paragraph: "Paragraph", outdent: "Outdent", indent: "Indent", left: "Align left", center: "Align center", right: "Align right", justify: "Justify full" }, color: { recent: "Recent Color", more: "More Color", background: "Background Color", foreground: "Foreground Color", transparent: "Transparent", setTransparent: "Set transparent", reset: "Reset", resetToDefault: "Reset to default" }, shortcut: { shortcuts: "Keyboard shortcuts", close: "Close", textFormatting: "Text formatting", action: "Action", paragraphFormatting: "Paragraph formatting", documentStyle: "Document Style", extraKeys: "Extra keys" }, history: { undo: "Undo", redo: "Redo" } } } }, q = function () { var b = function (b) { return a.Deferred(function (c) { a.extend(new FileReader, { onload: function (a) { var b = a.target.result; c.resolve(b) }, onerror: function () { c.reject(this) } }).readAsDataURL(b) }).promise() }, c = function (b, c) { return a.Deferred(function (d) { var e = a("<img>"); e.one("load", function () { e.off("error abort"), d.resolve(e) }).one("error abort", function () { e.off("load").detach(), d.reject(e) }).css({ display: "none" }).appendTo(document.body).attr({ src: b, "data-filename": c }) }).promise() }; return { readFileAsDataURL: b, createImage: c } }(), r = function () { var a = { BACKSPACE: 8, TAB: 9, ENTER: 13, SPACE: 32, NUM0: 48, NUM1: 49, NUM2: 50, NUM3: 51, NUM4: 52, NUM5: 53, NUM6: 54, NUM7: 55, NUM8: 56, B: 66, E: 69, I: 73, J: 74, K: 75, L: 76, R: 82, S: 83, U: 85, V: 86, Y: 89, Z: 90, SLASH: 191, LEFTBRACKET: 219, BACKSLASH: 220, RIGHTBRACKET: 221 }; return { isEdit: function (a) { return k.contains([8, 9, 13, 32], a) }, isMove: function (a) { return k.contains([37, 38, 39, 40], a) }, nameFromCode: j.invertObject(a), code: a } }(), s = function (a) { var b = [], c = -1, d = a[0], e = function () { var b = o.create(), c = { s: { path: [], offset: 0 }, e: { path: [], offset: 0 } }; return { contents: a.html(), bookmark: b ? b.bookmark(d) : c } }, f = function (b) { null !== b.contents && a.html(b.contents), null !== b.bookmark && o.createFromBookmark(d, b.bookmark).select() }; this.undo = function () { a.html() !== b[c].contents && this.recordUndo(), c > 0 && (c--, f(b[c])) }, this.redo = function () { b.length - 1 > c && (c++, f(b[c])) }, this.recordUndo = function () { c++, b.length > c && (b = b.slice(0, c)), b.push(e()) }, this.recordUndo() }, t = function () { var b = function (b, c) { if (i.jqueryVersion < 1.9) { var d = {}; return a.each(c, function (a, c) { d[c] = b.css(c) }), d } return b.css.call(b, c) }; this.fromNode = function (a) { var c = ["font-family", "font-size", "text-align", "list-style-type", "line-height"], d = b(a, c) || {}; return d["font-size"] = parseInt(d["font-size"], 10), d }, this.stylePara = function (b, c) { a.each(b.nodes(n.isPara, { includeAncestor: !0 }), function (b, d) { a(d).css(c) }) }, this.styleNodes = function (b, c) { b = b.splitText(); var d = c && c.nodeName || "SPAN", e = !(!c || !c.expandClosestSibling), f = !(!c || !c.onlyPartialContains); if (b.isCollapsed()) return [b.insertNode(n.create(d))]; var g = n.makePredByNodeName(d), h = b.nodes(n.isText, { fullyContains: !0 }).map(function (a) { return n.singleChildAncestor(a, g) || n.wrap(a, d) }); if (e) { if (f) { var i = b.nodes(); g = j.and(g, function (a) { return k.contains(i, a) }) } return h.map(function (b) { var c = n.withClosestSiblings(b, g), d = k.head(c), e = k.tail(c); return a.each(e, function (a, b) { n.appendChildNodes(d, b.childNodes), n.remove(b) }), k.head(c) }) } return h }, this.current = function (b) { var c = a(n.isText(b.sc) ? b.sc.parentNode : b.sc), d = this.fromNode(c); if (d["font-bold"] = document.queryCommandState("bold") ? "bold" : "normal", d["font-italic"] = document.queryCommandState("italic") ? "italic" : "normal", d["font-underline"] = document.queryCommandState("underline") ? "underline" : "normal", d["font-strikethrough"] = document.queryCommandState("strikeThrough") ? "strikethrough" : "normal", d["font-superscript"] = document.queryCommandState("superscript") ? "superscript" : "normal", d["font-subscript"] = document.queryCommandState("subscript") ? "subscript" : "normal", b.isOnList()) { var e = ["circle", "disc", "disc-leading-zero", "square"], f = a.inArray(d["list-style-type"], e) > -1; d["list-style"] = f ? "unordered" : "ordered" } else d["list-style"] = "none"; var g = n.ancestor(b.sc, n.isPara); if (g && g.style["line-height"]) d["line-height"] = g.style.lineHeight; else { var h = parseInt(d["line-height"], 10) / parseInt(d["font-size"], 10); d["line-height"] = h.toFixed(1) } return d.anchor = b.isOnAnchor() && n.ancestor(b.sc, n.isAnchor), d.ancestors = n.listAncestor(b.sc, n.isEditable), d.range = b, d } }, u = function () { this.insertOrderedList = function () { this.toggleList("OL") }, this.insertUnorderedList = function () { this.toggleList("UL") }, this.indent = function () { var b = this, c = o.create().wrapBodyInlineWithPara(), d = c.nodes(n.isPara, { includeAncestor: !0 }), e = k.clusterBy(d, j.peq2("parentNode")); a.each(e, function (c, d) { var e = k.head(d); n.isLi(e) ? b.wrapList(d, e.parentNode.nodeName) : a.each(d, function (b, c) { a(c).css("marginLeft", function (a, b) { return (parseInt(b, 10) || 0) + 25 }) }) }), c.select() }, this.outdent = function () { var b = this, c = o.create().wrapBodyInlineWithPara(), d = c.nodes(n.isPara, { includeAncestor: !0 }), e = k.clusterBy(d, j.peq2("parentNode")); a.each(e, function (c, d) { var e = k.head(d); n.isLi(e) ? b.releaseList([d]) : a.each(d, function (b, c) { a(c).css("marginLeft", function (a, b) { return b = parseInt(b, 10) || 0, b > 25 ? b - 25 : "" }) }) }), c.select() }, this.toggleList = function (b) { var c = this, d = o.create().wrapBodyInlineWithPara(), e = d.nodes(n.isPara, { includeAncestor: !0 }), f = d.paraBookmark(e), g = k.clusterBy(e, j.peq2("parentNode")); if (k.find(e, n.isPurePara)) { var h = []; a.each(g, function (a, d) { h = h.concat(c.wrapList(d, b)) }), e = h } else { var i = d.nodes(n.isList, { includeAncestor: !0 }).filter(function (c) { return !a.nodeName(c, b) }); i.length ? a.each(i, function (a, c) { n.replace(c, b) }) : e = this.releaseList(g, !0) } o.createFromParaBookmark(f, e).select() }, this.wrapList = function (a, b) { var c = k.head(a), d = k.last(a), e = n.isList(c.previousSibling) && c.previousSibling, f = n.isList(d.nextSibling) && d.nextSibling, g = e || n.insertAfter(n.create(b || "UL"), d); return a = a.map(function (a) { return n.isPurePara(a) ? n.replace(a, "LI") : a }), n.appendChildNodes(g, a), f && (n.appendChildNodes(g, k.from(f.childNodes)), n.remove(f)), a }, this.releaseList = function (b, c) { var d = []; return a.each(b, function (b, e) { var f = k.head(e), g = k.last(e), h = c ? n.lastAncestor(f, n.isList) : f.parentNode, i = h.childNodes.length > 1 ? n.splitTree(h, { node: g.parentNode, offset: n.position(g) + 1 }, { isSkipPaddingBlankHTML: !0 }) : null, j = n.splitTree(h, { node: f.parentNode, offset: n.position(f) }, { isSkipPaddingBlankHTML: !0 }); e = c ? n.listDescendant(j, n.isLi) : k.from(j.childNodes).filter(n.isLi), (c || !n.isList(h.parentNode)) && (e = e.map(function (a) { return n.replace(a, "P") })), a.each(k.from(e).reverse(), function (a, b) { n.insertAfter(b, h) }); var l = k.compact([h, j, i]); a.each(l, function (b, c) { var d = [c].concat(n.listDescendant(c, n.isList)); a.each(d.reverse(), function (a, b) { n.nodeLength(b) || n.remove(b, !0) }) }), d = d.concat(e) }), d } }, v = function () { var b = new u; this.insertTab = function (a, b, c) { var d = n.createText(new Array(c + 1).join(n.NBSP_CHAR)); b = b.deleteContents(), b.insertNode(d, !0), b = o.create(d, c), b.select() }, this.insertParagraph = function () { var c = o.create(); c = c.deleteContents(), c = c.wrapBodyInlineWithPara(); var d, e = n.ancestor(c.sc, n.isPara); if (e) { if (n.isEmpty(e) && n.isLi(e)) return void b.toggleList(e.parentNode.nodeName); d = n.splitTree(e, c.getStartPoint()); var f = n.listDescendant(e, n.isEmptyAnchor); f = f.concat(n.listDescendant(d, n.isEmptyAnchor)), a.each(f, function (a, b) { n.remove(b) }) } else { var g = c.sc.childNodes[c.so]; d = a(n.emptyPara)[0], g ? c.sc.insertBefore(d, g) : c.sc.appendChild(d) } o.create(d, 0).normalize().select() } }, w = function () {
        this.tab = function (a, b) {
            var c = n.ancestor(a.commonAncestor(), n.isCell), d = n.ancestor(c, n.isTable), e = n.listDescendant(d, n.isCell), f = k[b ? "prev" : "next"](e, c);
            f && o.create(f, 0).select()
        }, this.createTable = function (b, c) { for (var d, e = [], f = 0; b > f; f++) e.push("<td>" + n.blank + "</td>"); d = e.join(""); for (var g, h = [], i = 0; c > i; i++) h.push("<tr>" + d + "</tr>"); return g = h.join(""), a('<table class="table table-bordered">' + g + "</table>")[0] }
    }, x = "bogus", y = function (b) { var c = this, d = new t, e = new w, f = new v, g = new u; this.createRange = function (a) { return this.focus(a), o.create() }, this.saveRange = function (a, b) { this.focus(a), a.data("range", o.create()), b && o.create().collapse().select() }, this.saveNode = function (a) { for (var b = [], c = 0, d = a[0].childNodes.length; d > c; c++) b.push(a[0].childNodes[c]); a.data("childNodes", b) }, this.restoreRange = function (a) { var b = a.data("range"); b && (b.select(), this.focus(a)) }, this.restoreNode = function (a) { a.html(""); for (var b = a.data("childNodes"), c = 0, d = b.length; d > c; c++) a[0].appendChild(b[c]) }, this.currentStyle = function (a) { var b = o.create(), c = b && b.isOnEditable() ? d.current(b.normalize()) : {}; return n.isImg(a) && (c.image = a), c }, this.styleFromNode = function (a) { return d.fromNode(a) }; var h = function (a) { var c = n.makeLayoutInfo(a).holder(); b.bindCustomEvent(c, a.data("callbacks"), "before.command")(a.html(), a) }, j = function (a) { var c = n.makeLayoutInfo(a).holder(); b.bindCustomEvent(c, a.data("callbacks"), "change")(a.html(), a) }; this.undo = function (a) { h(a), a.data("NoteHistory").undo(), j(a) }, this.redo = function (a) { h(a), a.data("NoteHistory").redo(), j(a) }; for (var l = this.beforeCommand = function (a) { h(a), c.focus(a) }, m = this.afterCommand = function (a, b) { a.data("NoteHistory").recordUndo(), b || j(a) }, p = ["bold", "italic", "underline", "strikethrough", "superscript", "subscript", "justifyLeft", "justifyCenter", "justifyRight", "justifyFull", "formatBlock", "removeFormat", "backColor", "foreColor", "fontName"], r = 0, s = p.length; s > r; r++) this[p[r]] = function (a) { return function (b, c) { l(b), document.execCommand(a, !1, c), m(b, !0) } }(p[r]); this.tab = function (a, b) { var c = this.createRange(a); c.isCollapsed() && c.isOnCell() ? e.tab(c) : (l(a), f.insertTab(a, c, b.tabsize), m(a)) }, this.untab = function (a) { var b = this.createRange(a); b.isCollapsed() && b.isOnCell() && e.tab(b, !0) }, this.insertParagraph = function (a) { l(a), f.insertParagraph(a), m(a) }, this.insertOrderedList = function (a) { l(a), g.insertOrderedList(a), m(a) }, this.insertUnorderedList = function (a) { l(a), g.insertUnorderedList(a), m(a) }, this.indent = function (a) { l(a), g.indent(a), m(a) }, this.outdent = function (a) { l(a), g.outdent(a), m(a) }, this.insertImage = function (a, c, d) { q.createImage(c, d).then(function (b) { l(a), b.css({ display: "", width: Math.min(a.width(), b.width()) }), o.create().insertNode(b[0]), o.createFromNodeAfter(b[0]).select(), m(a) }).fail(function () { var c = n.makeLayoutInfo(a).holder(); b.bindCustomEvent(c, a.data("callbacks"), "image.upload.error")() }) }, this.insertNode = function (a, b) { l(a), o.create().insertNode(b), o.createFromNodeAfter(b).select(), m(a) }, this.insertText = function (a, b) { l(a); var c = o.create().insertNode(n.createText(b)); o.create(c, n.nodeLength(c)).select(), m(a) }, this.pasteHTML = function (a, b) { l(a); var c = o.create().pasteHTML(b); o.createFromNodeAfter(k.last(c)).select(), m(a) }, this.formatBlock = function (a, b) { l(a), b = i.isMSIE ? "<" + b + ">" : b, document.execCommand("FormatBlock", !1, b), m(a) }, this.formatPara = function (a) { l(a), this.formatBlock(a, "P"), m(a) }; for (var r = 1; 6 >= r; r++) this["formatH" + r] = function (a) { return function (b) { this.formatBlock(b, "H" + a) } }(r); this.fontSize = function (b, c) { var e = o.create(); if (e.isCollapsed()) { var f = d.styleNodes(e), g = k.head(f); a(f).css({ "font-size": c + "px" }), g && !n.nodeLength(g) && (g.innerHTML = n.ZERO_WIDTH_NBSP_CHAR, o.createFromNodeAfter(g.firstChild).select(), b.data(x, g)) } else l(b), a(d.styleNodes(e)).css({ "font-size": c + "px" }), m(b) }, this.insertHorizontalRule = function (b) { l(b); var c = o.create(), d = c.insertNode(a("<HR/>")[0]); d.nextSibling && o.create(d.nextSibling, 0).normalize().select(), m(b) }, this.removeBogus = function (a) { var b = a.data(x); if (b) { var c = k.find(k.from(b.childNodes), n.isText), d = c.nodeValue.indexOf(n.ZERO_WIDTH_NBSP_CHAR); -1 !== d && c.deleteData(d, 1), n.isEmpty(b) && n.remove(b), a.removeData(x) } }, this.lineHeight = function (a, b) { l(a), d.stylePara(o.create(), { lineHeight: b }), m(a) }, this.unlink = function (a) { var b = this.createRange(a); if (b.isOnAnchor()) { var c = n.ancestor(b.sc, n.isAnchor); b = o.createFromNode(c), b.select(), l(a), document.execCommand("unlink"), m(a) } }, this.createLink = function (b, c, e) { var f = c.url, g = c.text, h = c.isNewWindow, i = c.range || this.createRange(b), j = i.toString() !== g; e = e || n.makeLayoutInfo(b).editor().data("options"), l(b), e.onCreateLink && (f = e.onCreateLink(f)); var p = []; if (j) { var q = i.insertNode(a("<A>" + g + "</A>")[0]); p.push(q) } else p = d.styleNodes(i, { nodeName: "A", expandClosestSibling: !0, onlyPartialContains: !0 }); a.each(p, function (b, c) { a(c).attr("href", f), h ? a(c).attr("target", "_blank") : a(c).removeAttr("target") }); var r = o.createFromNodeBefore(k.head(p)), s = r.getStartPoint(), t = o.createFromNodeAfter(k.last(p)), u = t.getEndPoint(); o.create(s.node, s.offset, u.node, u.offset).select(), m(b) }, this.getLinkInfo = function (b) { this.focus(b); var c = o.create().expand(n.isAnchor), d = a(k.head(c.nodes(n.isAnchor))); return { range: c, text: c.toString(), isNewWindow: d.length ? "_blank" === d.attr("target") : !1, url: d.length ? d.attr("href") : "" } }, this.color = function (a, b) { var c = JSON.parse(b), d = c.foreColor, e = c.backColor; l(a), d && document.execCommand("foreColor", !1, d), e && document.execCommand("backColor", !1, e), m(a) }, this.insertTable = function (a, b) { var c = b.split("x"); l(a); var d = o.create().deleteContents(); d.insertNode(e.createTable(c[0], c[1])), m(a) }, this.floatMe = function (a, b, c) { l(a), c.removeClass("pull-left pull-right"), b && "none" !== b && c.addClass("pull-" + b), c.css("float", b), m(a) }, this.imageShape = function (a, b, c) { l(a), c.removeClass("img-rounded img-circle img-thumbnail"), b && c.addClass(b), m(a) }, this.resize = function (a, b, c) { l(a), c.css({ width: 100 * b + "%", height: "" }), m(a) }, this.resizeTo = function (a, b, c) { var d; if (c) { var e = a.y / a.x, f = b.data("ratio"); d = { width: f > e ? a.x : a.y / f, height: f > e ? a.x * f : a.y } } else d = { width: a.x, height: a.y }; b.css(d) }, this.removeMedia = function (c, d, e) { l(c), e.detach(), b.bindCustomEvent(a(), c.data("callbacks"), "media.delete")(e, c), m(c) }, this.focus = function (a) { a.focus(), i.isFF && !o.create().isOnEditable() && o.createFromNode(a[0]).normalize().collapse().select() }, this.isEmpty = function (a) { return n.isEmpty(a[0]) || n.emptyPara === a.html() } }, z = function () { this.update = function (b, c) { var d = function (b, c) { b.find(".dropdown-menu li a").each(function () { var b = a(this).data("value") + "" == c + ""; this.className = b ? "checked" : "" }) }, e = function (a, c) { var d = b.find(a); d.toggleClass("active", c()) }; if (c.image) { var f = a(c.image); e('button[data-event="imageShape"][data-value="img-rounded"]', function () { return f.hasClass("img-rounded") }), e('button[data-event="imageShape"][data-value="img-circle"]', function () { return f.hasClass("img-circle") }), e('button[data-event="imageShape"][data-value="img-thumbnail"]', function () { return f.hasClass("img-thumbnail") }), e('button[data-event="imageShape"]:not([data-value])', function () { return !f.is(".img-rounded, .img-circle, .img-thumbnail") }); var g = f.css("float"); e('button[data-event="floatMe"][data-value="left"]', function () { return "left" === g }), e('button[data-event="floatMe"][data-value="right"]', function () { return "right" === g }), e('button[data-event="floatMe"][data-value="none"]', function () { return "left" !== g && "right" !== g }); var h = f.attr("style"); return e('button[data-event="resize"][data-value="1"]', function () { return !!/(^|\s)(max-)?width\s*:\s*100%/.test(h) }), e('button[data-event="resize"][data-value="0.5"]', function () { return !!/(^|\s)(max-)?width\s*:\s*50%/.test(h) }), void e('button[data-event="resize"][data-value="0.25"]', function () { return !!/(^|\s)(max-)?width\s*:\s*25%/.test(h) }) } var j = b.find(".note-fontname"); if (j.length) { var k = c["font-family"]; if (k) { for (var l = k.split(","), m = 0, n = l.length; n > m && (k = l[m].replace(/[\'\"]/g, "").replace(/\s+$/, "").replace(/^\s+/, ""), !i.isFontInstalled(k)) ; m++); j.find(".note-current-fontname").text(k), d(j, k) } } var o = b.find(".note-fontsize"); o.find(".note-current-fontsize").text(c["font-size"]), d(o, parseFloat(c["font-size"])); var p = b.find(".note-height"); d(p, parseFloat(c["line-height"])), e('button[data-event="bold"]', function () { return "bold" === c["font-bold"] }), e('button[data-event="italic"]', function () { return "italic" === c["font-italic"] }), e('button[data-event="underline"]', function () { return "underline" === c["font-underline"] }), e('button[data-event="strikethrough"]', function () { return "strikethrough" === c["font-strikethrough"] }), e('button[data-event="superscript"]', function () { return "superscript" === c["font-superscript"] }), e('button[data-event="subscript"]', function () { return "subscript" === c["font-subscript"] }), e('button[data-event="justifyLeft"]', function () { return "left" === c["text-align"] || "start" === c["text-align"] }), e('button[data-event="justifyCenter"]', function () { return "center" === c["text-align"] }), e('button[data-event="justifyRight"]', function () { return "right" === c["text-align"] }), e('button[data-event="justifyFull"]', function () { return "justify" === c["text-align"] }), e('button[data-event="insertUnorderedList"]', function () { return "unordered" === c["list-style"] }), e('button[data-event="insertOrderedList"]', function () { return "ordered" === c["list-style"] }) }, this.updateRecentColor = function (b, c, d) { var e = a(b).closest(".note-color"), f = e.find(".note-recent-color"), g = JSON.parse(f.attr("data-value")); g[c] = d, f.attr("data-value", JSON.stringify(g)); var h = "backColor" === c ? "background-color" : "color"; f.find("i").css(h, d) } }, A = function () { var a = new z; this.update = function (b, c) { a.update(b, c) }, this.updateRecentColor = function (b, c, d) { a.updateRecentColor(b, c, d) }, this.activate = function (a) { a.find("button").not('button[data-event="codeview"]').removeClass("disabled") }, this.deactivate = function (a) { a.find("button").not('button[data-event="codeview"]').addClass("disabled") }, this.updateFullscreen = function (a, b) { var c = a.find('button[data-event="fullscreen"]'); c.toggleClass("active", b) }, this.updateCodeview = function (a, b) { var c = a.find('button[data-event="codeview"]'); c.toggleClass("active", b), b ? this.deactivate(a) : this.activate(a) }, this.get = function (a, b) { var c = n.makeLayoutInfo(a).toolbar(); return c.find("[data-name=" + b + "]") }, this.setButtonState = function (a, b, c) { c = c === !1 ? !1 : !0; var d = this.get(a, b); d.toggleClass("active", c) } }, B = 24, C = function () { var b = a(document); this.attach = function (a, b) { b.disableResizeEditor || a.statusbar().on("mousedown", c) }; var c = function (a) { a.preventDefault(), a.stopPropagation(); var c = n.makeLayoutInfo(a.target).editable(), d = c.offset().top - b.scrollTop(), e = n.makeLayoutInfo(a.currentTarget || a.target), f = e.editor().data("options"); b.on("mousemove", function (a) { var b = a.clientY - (d + B); b = f.minHeight > 0 ? Math.max(b, f.minHeight) : b, b = f.maxHeight > 0 ? Math.min(b, f.maxHeight) : b, c.height(b) }).one("mouseup", function () { b.off("mousemove") }) } }, D = function () { var b = new z, c = function (b, c) { var d = c && c.isAirMode, e = c && c.isLeftTop, f = a(b), g = d ? f.offset() : f.position(), h = e ? 0 : f.outerHeight(!0); return { left: g.left, top: g.top + h } }, d = function (a, b) { a.css({ display: "block", left: b.left, top: b.top }) }, e = 20; this.update = function (f, g, h) { b.update(f, g); var i = f.find(".note-link-popover"); if (g.anchor) { var l = i.find("a"), m = a(g.anchor).attr("href"), n = a(g.anchor).attr("target"); l.attr("href", m).html(m), n ? l.attr("target", "_blank") : l.removeAttr("target"), d(i, c(g.anchor, { isAirMode: h })) } else i.hide(); var o = f.find(".note-image-popover"); g.image ? d(o, c(g.image, { isAirMode: h, isLeftTop: !0 })) : o.hide(); var p = f.find(".note-air-popover"); if (h && g.range && !g.range.isCollapsed()) { var q = k.last(g.range.getClientRects()); if (q) { var r = j.rect2bnd(q); d(p, { left: Math.max(r.left + r.width / 2 - e, 0), top: r.top + r.height }) } } else p.hide() }, this.updateRecentColor = function (a, b, c) { a.updateRecentColor(a, b, c) }, this.hide = function (a) { a.children().hide() } }, E = function (b) { var c = a(document), d = function (d) { if (n.isControlSizing(d.target)) { d.preventDefault(), d.stopPropagation(); var e = n.makeLayoutInfo(d.target), f = e.handle(), g = e.popover(), h = e.editable(), i = e.editor(), j = f.find(".note-control-selection").data("target"), k = a(j), l = k.offset(), m = c.scrollTop(), o = i.data("options").airMode; c.on("mousemove", function (a) { b.invoke("editor.resizeTo", { x: a.clientX - l.left, y: a.clientY - (l.top - m) }, k, !a.shiftKey), b.invoke("handle.update", f, { image: j }, o), b.invoke("popover.update", g, { image: j }, o) }).one("mouseup", function () { c.off("mousemove"), b.invoke("editor.afterCommand", h) }), k.data("ratio") || k.data("ratio", k.height() / k.width()) } }; this.attach = function (a) { a.handle().on("mousedown", d) }, this.update = function (b, c, d) { var e = b.find(".note-control-selection"); if (c.image) { var f = a(c.image), g = d ? f.offset() : f.position(), h = { w: f.outerWidth(!0), h: f.outerHeight(!0) }; e.css({ display: "block", left: g.left, top: g.top, width: h.w, height: h.h }).data("target", c.image); var i = h.w + "x" + h.h; e.find(".note-control-selection-info").text(i) } else e.hide() }, this.hide = function (a) { a.children().hide() } }, F = function (b) { var c = a(window), d = a("html, body"); this.toggle = function (a) { var e = a.editor(), f = a.toolbar(), g = a.editable(), h = a.codable(), i = function (a) { g.css("height", a.h), h.css("height", a.h), h.data("cmeditor") && h.data("cmeditor").setsize(null, a.h) }; e.toggleClass("fullscreen"); var j = e.hasClass("fullscreen"); j ? (g.data("orgheight", g.css("height")), c.on("resize", function () { i({ h: c.height() - f.outerHeight() }) }).trigger("resize"), d.css("overflow", "hidden")) : (c.off("resize"), i({ h: g.data("orgheight") }), d.css("overflow", "visible")), b.invoke("toolbar.updateFullscreen", f, j) } }; i.hasCodeMirror && (i.isSupportAmd ? require(["CodeMirror"], function (a) { h = a }) : h = window.CodeMirror); var G = function (a) { this.sync = function (b) { var c = a.invoke("codeview.isActivated", b); c && i.hasCodeMirror && b.codable().data("cmEditor").save() }, this.isActivated = function (a) { var b = a.editor(); return b.hasClass("codeview") }, this.toggle = function (a) { this.isActivated(a) ? this.deactivate(a) : this.activate(a) }, this.activate = function (b) { var c = b.editor(), d = b.toolbar(), e = b.editable(), f = b.codable(), g = b.popover(), j = b.handle(), k = c.data("options"); if (f.val(n.html(e, k.prettifyHtml)), f.height(e.height()), a.invoke("toolbar.updateCodeview", d, !0), a.invoke("popover.hide", g), a.invoke("handle.hide", j), c.addClass("codeview"), f.focus(), i.hasCodeMirror) { var l = h.fromTextArea(f[0], k.codemirror); if (k.codemirror.tern) { var m = new h.TernServer(k.codemirror.tern); l.ternServer = m, l.on("cursorActivity", function (a) { m.updateArgHints(a) }) } l.setSize(null, e.outerHeight()), f.data("cmEditor", l) } }, this.deactivate = function (b) { var c = b.holder(), d = b.editor(), e = b.toolbar(), f = b.editable(), g = b.codable(), h = d.data("options"); if (i.hasCodeMirror) { var j = g.data("cmEditor"); g.val(j.getValue()), j.toTextArea() } var k = n.value(g, h.prettifyHtml) || n.emptyPara, l = f.html() !== k; f.html(k), f.height(h.height ? g.height() : "auto"), d.removeClass("codeview"), l && a.bindCustomEvent(c, f.data("callbacks"), "change")(f.html(), f), f.focus(), a.invoke("toolbar.updateCodeview", e, !1) } }, H = function (b) { var c = a(document); this.attach = function (a, b) { b.airMode || b.disableDragAndDrop ? c.on("drop", function (a) { a.preventDefault() }) : this.attachDragAndDropEvent(a, b) }, this.attachDragAndDropEvent = function (d, e) { var f = a(), g = d.editor(), h = d.dropzone(), i = h.find(".note-dropzone-message"); c.on("dragenter", function (a) { var c = b.invoke("codeview.isActivated", d), j = g.width() > 0 && g.height() > 0; c || f.length || !j || (g.addClass("dragover"), h.width(g.width()), h.height(g.height()), i.text(e.langInfo.image.dragImageHere)), f = f.add(a.target) }).on("dragleave", function (a) { f = f.not(a.target), f.length || g.removeClass("dragover") }).on("drop", function () { f = a(), g.removeClass("dragover") }), h.on("dragenter", function () { h.addClass("hover"), i.text(e.langInfo.image.dropImage) }).on("dragleave", function () { h.removeClass("hover"), i.text(e.langInfo.image.dragImageHere) }), h.on("drop", function (c) { var d = c.originalEvent.dataTransfer, e = n.makeLayoutInfo(c.currentTarget || c.target); if (d && d.files && d.files.length) c.preventDefault(), e.editable().focus(), b.insertImages(e, d.files); else for (var f = function () { e.holder().summernote("insertNode", this) }, g = 0, h = d.types.length; h > g; g++) { var i = d.types[g], j = d.getData(i); i.toLowerCase().indexOf("text") > -1 ? e.holder().summernote("pasteHTML", j) : a(j).each(f) } }).on("dragover", !1) } }, I = function (b) { var c; this.attach = function (f) { i.isMSIE && i.browserVersion > 10 || i.isFF ? (c = a("<div />").attr("contenteditable", !0).css({ position: "absolute", left: -1e5, opacity: 0 }), f.editable().on("keydown", function (a) { a.ctrlKey && a.keyCode === r.code.V && (b.invoke("saveRange", f.editable()), c.focus(), setTimeout(function () { d(f) }, 0)) }), f.editable().before(c)) : f.editable().on("paste", e) }; var d = function (d) { var e = d.editable(), f = c[0].firstChild; if (n.isImg(f)) { for (var g = f.src, h = atob(g.split(",")[1]), i = new Uint8Array(h.length), j = 0; j < h.length; j++) i[j] = h.charCodeAt(j); var k = new Blob([i], { type: "image/png" }); k.name = "clipboard.png", b.invoke("restoreRange", e), b.invoke("focus", e), b.insertImages(d, [k]) } else { var l = a("<div />").html(c.html()).html(); b.invoke("restoreRange", e), b.invoke("focus", e), l && b.invoke("pasteHTML", e, l) } c.empty() }, e = function (a) { var c = a.originalEvent.clipboardData, d = n.makeLayoutInfo(a.currentTarget || a.target), e = d.editable(); if (c && c.items && c.items.length) { var f = k.head(c.items); "file" === f.kind && -1 !== f.type.indexOf("image/") && b.insertImages(d, [f.getAsFile()]), b.invoke("editor.afterCommand", e) } } }, J = function (b) { var c = function (a, b) { a.toggleClass("disabled", !b), a.attr("disabled", !b) }, d = function (a, b) { a.on("keypress", function (a) { a.keyCode === r.code.ENTER && b.trigger("click") }) }; this.showLinkDialog = function (b, e, f) { return a.Deferred(function (a) { var b = e.find(".note-link-dialog"), g = b.find(".note-link-text"), h = b.find(".note-link-url"), i = b.find(".note-link-btn"), j = b.find("input[type=checkbox]"); b.one("shown.bs.modal", function () { g.val(f.text), g.on("input", function () { c(i, g.val() && h.val()), f.text = g.val() }), f.url || (f.url = f.text || "http://", c(i, f.text)), h.on("input", function () { c(i, g.val() && h.val()), f.text || g.val(h.val()) }).val(f.url).trigger("focus").trigger("select"), d(h, i), d(g, i), j.prop("checked", f.isNewWindow), i.one("click", function (c) { c.preventDefault(), a.resolve({ range: f.range, url: h.val(), text: g.val(), isNewWindow: j.is(":checked") }), b.modal("hide") }) }).one("hidden.bs.modal", function () { g.off("input keypress"), h.off("input keypress"), i.off("click"), "pending" === a.state() && a.reject() }).modal("show") }).promise() }, this.show = function (a) { var c = a.editor(), d = a.dialog(), e = a.editable(), f = a.popover(), g = b.invoke("editor.getLinkInfo", e), h = c.data("options"); b.invoke("editor.saveRange", e), this.showLinkDialog(e, d, g).then(function (a) { b.invoke("editor.restoreRange", e), b.invoke("editor.CreateLink", e, a, h), b.invoke("popover.hide", f) }).fail(function () { b.invoke("editor.restoreRange", e) }) } }, K = function (b) { var c = function (a, b) { a.toggleClass("disabled", !b), a.attr("disabled", !b) }, d = function (a, b) { a.on("keypress", function (a) { a.keyCode === r.code.ENTER && b.trigger("click") }) }; this.show = function (a) { var c = a.dialog(), d = a.editable(); b.invoke("editor.saveRange", d), this.showImageDialog(d, c).then(function (c) { b.invoke("editor.restoreRange", d), "string" == typeof c ? b.invoke("editor.insertImage", d, c) : b.insertImages(a, c) }).fail(function () { b.invoke("editor.restoreRange", d) }) }, this.showImageDialog = function (b, e) { return a.Deferred(function (a) { var b = e.find(".note-image-dialog"), f = e.find(".note-image-input"), g = e.find(".note-image-url"), h = e.find(".note-image-btn"); b.one("shown.bs.modal", function () { f.replaceWith(f.clone().on("change", function () { a.resolve(this.files || this.value), b.modal("hide") }).val("")), h.click(function (c) { c.preventDefault(), a.resolve(g.val()), b.modal("hide") }), g.on("keyup paste", function (a) { var b; b = "paste" === a.type ? a.originalEvent.clipboardData.getData("text") : g.val(), c(h, b) }).val("").trigger("focus"), d(g, h) }).one("hidden.bs.modal", function () { f.off("change"), g.off("keyup paste keypress"), h.off("click"), "pending" === a.state() && a.reject() }).modal("show") }) } }, L = function (b) { this.showHelpDialog = function (b, c) { return a.Deferred(function (a) { var b = c.find(".note-help-dialog"); b.one("hidden.bs.modal", function () { a.resolve() }).modal("show") }).promise() }, this.show = function (a) { var c = a.dialog(), d = a.editable(); b.invoke("editor.saveRange", d, !0), this.showHelpDialog(d, c).then(function () { b.invoke("editor.restoreRange", d) }) } }, M = function () { var b = this, c = this.modules = { editor: new y(this), toolbar: new A(this), statusbar: new C(this), popover: new D(this), handle: new E(this), fullscreen: new F(this), codeview: new G(this), dragAndDrop: new H(this), clipboard: new I(this), linkDialog: new J(this), imageDialog: new K(this), helpDialog: new L(this) }; this.invoke = function () { var a = k.head(k.from(arguments)), b = k.tail(k.from(arguments)), c = a.split("."), d = c.length > 1, e = d && k.head(c), f = d ? k.last(c) : k.head(c), g = this.getModule(e), h = g[f]; return h && h.apply(g, b) }, this.getModule = function (a) { return this.modules[a] || this.modules.editor }; var d = this.bindCustomEvent = function (a, b, c) { return function () { var d = b[j.namespaceToCamel(c, "on")]; return d && d.apply(a[0], arguments), a.trigger("summernote." + c, arguments) } }; this.insertImages = function (b, e) { var f = b.editor(), g = b.editable(), h = b.holder(), i = g.data("callbacks"), j = f.data("options"); i.onImageUpload ? d(h, i, "image.upload")(e) : a.each(e, function (a, b) { var e = b.name; j.maximumImageFileSize && j.maximumImageFileSize < b.size ? d(h, i, "image.upload.error")(j.langInfo.image.maximumFileSizeError) : q.readFileAsDataURL(b).then(function (a) { c.editor.insertImage(g, a, e) }).fail(function () { d(h, i, "image.upload.error")(j.langInfo.image.maximumFileSizeError) }) }) }; var e = { showLinkDialog: function (a) { c.linkDialog.show(a) }, showImageDialog: function (a) { c.imageDialog.show(a) }, showHelpDialog: function (a) { c.helpDialog.show(a) }, fullscreen: function (a) { c.fullscreen.toggle(a) }, codeview: function (a) { c.codeview.toggle(a) } }, f = function (a) { n.isImg(a.target) && a.preventDefault() }, g = function (a) { var b = n.makeLayoutInfo(a.currentTarget || a.target); c.editor.removeBogus(b.editable()), h(a) }; this.updateStyleInfo = function (a, b) { if (a) { var d = b.editor().data("options").airMode; d || c.toolbar.update(b.toolbar(), a), c.popover.update(b.popover(), a, d), c.handle.update(b.handle(), a, d) } }; var h = function (a) { var d = a.target; setTimeout(function () { var a = n.makeLayoutInfo(d), e = c.editor.currentStyle(d); b.updateStyleInfo(e, a) }, 0) }, l = function (a) { var b = n.makeLayoutInfo(a.currentTarget || a.target); c.popover.hide(b.popover()), c.handle.hide(b.handle()) }, m = function (b) { var c = a(b.target).closest("[data-event]"); c.length && b.preventDefault() }, o = function (b) { var d = a(b.target).closest("[data-event]"); if (d.length) { var f, g = d.attr("data-event"), i = d.attr("data-value"), j = d.attr("data-hide"), l = n.makeLayoutInfo(b.target); if (-1 !== a.inArray(g, ["resize", "floatMe", "removeMedia", "imageShape"])) { var m = l.handle().find(".note-control-selection"); f = a(m.data("target")) } if (j && d.parents(".popover").hide(), a.isFunction(a.summernote.pluginEvents[g])) a.summernote.pluginEvents[g](b, c.editor, l, i); else if (c.editor[g]) { var o = l.editable(); o.focus(), c.editor[g](o, i, f), b.preventDefault() } else e[g] && (e[g].call(this, l), b.preventDefault()); if (-1 !== a.inArray(g, ["backColor", "foreColor"])) { var p = l.editor().data("options", p), q = p.airMode ? c.popover : c.toolbar; q.updateRecentColor(k.head(d), g, i) } h(b) } }, p = 18, t = function (b, c) { var d, e = a(b.target.parentNode), f = e.next(), g = e.find(".note-dimension-picker-mousecatcher"), h = e.find(".note-dimension-picker-highlighted"), i = e.find(".note-dimension-picker-unhighlighted"); if (void 0 === b.offsetX) { var j = a(b.target).offset(); d = { x: b.pageX - j.left, y: b.pageY - j.top } } else d = { x: b.offsetX, y: b.offsetY }; var k = { c: Math.ceil(d.x / p) || 1, r: Math.ceil(d.y / p) || 1 }; h.css({ width: k.c + "em", height: k.r + "em" }), g.attr("data-value", k.c + "x" + k.r), 3 < k.c && k.c < c.insertTableMaxSize.col && i.css({ width: k.c + 1 + "em" }), 3 < k.r && k.r < c.insertTableMaxSize.row && i.css({ height: k.r + 1 + "em" }), f.html(k.c + " x " + k.r) }; this.bindKeyMap = function (b, d) { var f = b.editor(), g = b.editable(); g.on("keydown", function (h) { var i = []; h.metaKey && i.push("CMD"), h.ctrlKey && !h.altKey && i.push("CTRL"), h.shiftKey && i.push("SHIFT"); var j = r.nameFromCode[h.keyCode]; j && i.push(j); var k, l = i.join("+"), m = d[l]; if (m) { if (k = a.summernote.pluginEvents[l], a.isFunction(k) && k(h, c.editor, b)) return !1; k = a.summernote.pluginEvents[m], a.isFunction(k) ? k(h, c.editor, b) : c.editor[m] ? (c.editor[m](g, f.data("options")), h.preventDefault()) : e[m] && (e[m].call(this, b), h.preventDefault()) } else r.isEdit(h.keyCode) && c.editor.afterCommand(g) }) }, this.attach = function (a, b) { b.shortcuts && this.bindKeyMap(a, b.keyMap[i.isMac ? "mac" : "pc"]), a.editable().on("mousedown", f), a.editable().on("keyup mouseup", g), a.editable().on("scroll", l), c.clipboard.attach(a, b), c.handle.attach(a, b), a.popover().on("click", o), a.popover().on("mousedown", m), c.dragAndDrop.attach(a, b), b.airMode || (a.toolbar().on("click", o), a.toolbar().on("mousedown", m), c.statusbar.attach(a, b)); var d = b.airMode ? a.popover() : a.toolbar(), e = d.find(".note-dimension-picker-mousecatcher"); e.css({ width: b.insertTableMaxSize.col + "em", height: b.insertTableMaxSize.row + "em" }).on("mousemove", function (a) { t(a, b) }), a.editor().data("options", b), i.isMSIE || setTimeout(function () { document.execCommand("styleWithCSS", 0, b.styleWithSpan) }, 0); var h = new s(a.editable()); a.editable().data("NoteHistory", h), a.editable().data("callbacks", { onInit: b.onInit, onFocus: b.onFocus, onBlur: b.onBlur, onKeydown: b.onKeydown, onKeyup: b.onKeyup, onMousedown: b.onMousedown, onEnter: b.onEnter, onPaste: b.onPaste, onBeforeCommand: b.onBeforeCommand, onChange: b.onChange, onImageUpload: b.onImageUpload, onImageUploadError: b.onImageUploadError, onMediaDelete: b.onMediaDelete, onToolbarClick: b.onToolbarClick }); var j = c.editor.styleFromNode(a.editable()); this.updateStyleInfo(j, a) }, this.attachCustomEvent = function (b, c) { var e = b.holder(), f = b.editable(), g = f.data("callbacks"); f.focus(d(e, g, "focus")), f.blur(d(e, g, "blur")), f.keydown(function (a) { a.keyCode === r.code.ENTER && d(e, g, "enter").call(this, a), d(e, g, "keydown").call(this, a) }), f.keyup(d(e, g, "keyup")), f.on("mousedown", d(e, g, "mousedown")), f.on("mouseup", d(e, g, "mouseup")), f.on("scroll", d(e, g, "scroll")), f.on("paste", d(e, g, "paste")); var h = i.isMSIE ? "DOMCharacterDataModified DOMSubtreeModified DOMNodeInserted" : "input"; f.on(h, function () { d(e, g, "change")(f.html(), f) }), c.airMode || (b.toolbar().click(d(e, g, "toolbar.click")), b.popover().click(d(e, g, "popover.click"))), n.isTextarea(k.head(e)) && e.closest("form").submit(function (a) { b.holder().val(b.holder().code()), d(e, g, "submit").call(this, a, e.code()) }), n.isTextarea(k.head(e)) && c.textareaAutoSync && e.on("summernote.change", function () { b.holder().val(b.holder().code()) }), d(e, g, "init")(b); for (var j = 0, l = a.summernote.plugins.length; l > j; j++) a.isFunction(a.summernote.plugins[j].init) && a.summernote.plugins[j].init(b) }, this.detach = function (a, b) { a.holder().off(), a.editable().off(), a.popover().off(), a.handle().off(), a.dialog().off(), b.airMode || (a.dropzone().off(), a.toolbar().off(), a.statusbar().off()) } }, N = function () {
        var b = function (a, b) { var c = b.event, d = b.value, e = b.title, f = b.className, g = b.dropdown, h = b.hide; return (g ? '<div class="btn-group' + (f ? " " + f : "") + '">' : "") + '<button type="button" class="btn btn-default btn-sm' + (!g && f ? " " + f : "") + (g ? " dropdown-toggle" : "") + '"' + (g ? ' data-toggle="dropdown"' : "") + (e ? ' title="' + e + '"' : "") + (c ? ' data-event="' + c + '"' : "") + (d ? " data-value='" + d + "'" : "") + (h ? " data-hide='" + h + "'" : "") + ' tabindex="-1">' + a + (g ? ' <span class="caret"></span>' : "") + "</button>" + (g || "") + (g ? "</div>" : "") }, c = function (a, c) { var d = '<i class="' + a + '"></i>'; return b(d, c) }, d = function (b, c) { var d = a('<div class="' + b + ' popover bottom in" style="display: none;"><div class="arrow"></div><div class="popover-content"></div></div>'); return d.find(".popover-content").append(c), d }, e = function (a, b, c, d) { return '<div class="' + a + ' modal" aria-hidden="false"><div class="modal-dialog"><div class="modal-content">' + (b ? '<div class="modal-header"><button type="button" class="close" aria-hidden="true" tabindex="-1">&times;</button><h4 class="modal-title">' + b + "</h4></div>" : "") + '<div class="modal-body">' + c + "</div>" + (d ? '<div class="modal-footer">' + d + "</div>" : "") + "</div></div></div>" }, f = function (a, b, c) { var d = "dropdown-menu" + (b ? " " + b : ""); return c = c || "ul", a instanceof Array && (a = a.join("")), "<" + c + ' class="' + d + '">' + a + "</" + c + ">" }, g = {
            picture: function (a, b) { return c(b.iconPrefix + b.icons.image.image, { event: "showImageDialog", title: a.image.image, hide: !0 }) }, link: function (a, b) { return c(b.iconPrefix + b.icons.link.link, { event: "showLinkDialog", title: a.link.link, hide: !0 }) }, table: function (a, b) { var d = ['<div class="note-dimension-picker">', '<div class="note-dimension-picker-mousecatcher" data-event="insertTable" data-value="1x1"></div>', '<div class="note-dimension-picker-highlighted"></div>', '<div class="note-dimension-picker-unhighlighted"></div>', "</div>", '<div class="note-dimension-display"> 1 x 1 </div>']; return c(b.iconPrefix + b.icons.table.table, { title: a.table.table, dropdown: f(d, "note-table") }) }, style: function (a, b) { var d = b.styleTags.reduce(function (b, c) { var d = a.style["p" === c ? "normal" : c]; return b + '<li><a data-event="formatBlock" href="#" data-value="' + c + '">' + ("p" === c || "pre" === c ? d : "<" + c + ">" + d + "</" + c + ">") + "</a></li>" }, ""); return c(b.iconPrefix + b.icons.style.style, { title: a.style.style, dropdown: f(d) }) }, fontname: function (a, c) { var d = [], e = c.fontNames.reduce(function (a, b) { return i.isFontInstalled(b) || k.contains(c.fontNamesIgnoreCheck, b) ? (d.push(b), a + '<li><a data-event="fontName" href="#" data-value="' + b + '" style="font-family:\'' + b + '\'"><i class="' + c.iconPrefix + c.icons.misc.check + '"></i> ' + b + "</a></li>") : a }, ""), g = i.isFontInstalled(c.defaultFontName), h = g ? c.defaultFontName : d[0], j = '<span class="note-current-fontname">' + h + "</span>"; return b(j, { title: a.font.name, className: "note-fontname", dropdown: f(e, "note-check") }) }, fontsize: function (a, c) { var d = c.fontSizes.reduce(function (a, b) { return a + '<li><a data-event="fontSize" href="#" data-value="' + b + '"><i class="' + c.iconPrefix + c.icons.misc.check + '"></i> ' + b + "</a></li>" }, ""), e = '<span class="note-current-fontsize">11</span>'; return b(e, { title: a.font.size, className: "note-fontsize", dropdown: f(d, "note-check") }) }, color: function (a, c) { var d = '<i class="' + c.iconPrefix + c.icons.color.recent + '" style="color:black;background-color:yellow;"></i>', e = b(d, { className: "note-recent-color", title: a.color.recent, event: "color", value: '{"backColor":"yellow"}' }), g = ['<li><div class="btn-group">', '<div class="note-palette-title">' + a.color.background + "</div>", '<div class="note-color-reset" data-event="backColor"', ' data-value="inherit" title="' + a.color.transparent + '">' + a.color.setTransparent + "</div>", '<div class="note-color-palette" data-target-event="backColor"></div>', '</div><div class="btn-group">', '<div class="note-palette-title">' + a.color.foreground + "</div>", '<div class="note-color-reset" data-event="foreColor" data-value="inherit" title="' + a.color.reset + '">', a.color.resetToDefault, "</div>", '<div class="note-color-palette" data-target-event="foreColor"></div>', "</div></li>"], h = b("", { title: a.color.more, dropdown: f(g) }); return e + h }, bold: function (a, b) { return c(b.iconPrefix + b.icons.font.bold, { event: "bold", title: a.font.bold }) }, italic: function (a, b) { return c(b.iconPrefix + b.icons.font.italic, { event: "italic", title: a.font.italic }) }, underline: function (a, b) { return c(b.iconPrefix + b.icons.font.underline, { event: "underline", title: a.font.underline }) }, strikethrough: function (a, b) { return c(b.iconPrefix + b.icons.font.strikethrough, { event: "strikethrough", title: a.font.strikethrough }) }, superscript: function (a, b) { return c(b.iconPrefix + b.icons.font.superscript, { event: "superscript", title: a.font.superscript }) }, subscript: function (a, b) { return c(b.iconPrefix + b.icons.font.subscript, { event: "subscript", title: a.font.subscript }) }, clear: function (a, b) { return c(b.iconPrefix + b.icons.font.clear, { event: "removeFormat", title: a.font.clear }) }, ul: function (a, b) { return c(b.iconPrefix + b.icons.lists.unordered, { event: "insertUnorderedList", title: a.lists.unordered }) }, ol: function (a, b) { return c(b.iconPrefix + b.icons.lists.ordered, { event: "insertOrderedList", title: a.lists.ordered }) }, paragraph: function (a, b) {
                var d = c(b.iconPrefix + b.icons.paragraph.left, { title: a.paragraph.left, event: "justifyLeft" }), e = c(b.iconPrefix + b.icons.paragraph.center, { title: a.paragraph.center, event: "justifyCenter" }), g = c(b.iconPrefix + b.icons.paragraph.right, { title: a.paragraph.right, event: "justifyRight" }), h = c(b.iconPrefix + b.icons.paragraph.justify, { title: a.paragraph.justify, event: "justifyFull" }), i = c(b.iconPrefix + b.icons.paragraph.outdent, { title: a.paragraph.outdent, event: "outdent" }), j = c(b.iconPrefix + b.icons.paragraph.indent, { title: a.paragraph.indent, event: "indent" }), k = ['<div class="note-align btn-group">', d + e + g + h, '</div><div class="note-list btn-group">', j + i, "</div>"];
                return c(b.iconPrefix + b.icons.paragraph.paragraph, { title: a.paragraph.paragraph, dropdown: f(k, "", "div") })
            }, height: function (a, b) { var d = b.lineHeights.reduce(function (a, c) { return a + '<li><a data-event="lineHeight" href="#" data-value="' + parseFloat(c) + '"><i class="' + b.iconPrefix + b.icons.misc.check + '"></i> ' + c + "</a></li>" }, ""); return c(b.iconPrefix + b.icons.font.height, { title: a.font.height, dropdown: f(d, "note-check") }) }, help: function (a, b) { return c(b.iconPrefix + b.icons.options.help, { event: "showHelpDialog", title: a.options.help, hide: !0 }) }, fullscreen: function (a, b) { return c(b.iconPrefix + b.icons.options.fullscreen, { event: "fullscreen", title: a.options.fullscreen }) }, codeview: function (a, b) { return c(b.iconPrefix + b.icons.options.codeview, { event: "codeview", title: a.options.codeview }) }, undo: function (a, b) { return c(b.iconPrefix + b.icons.history.undo, { event: "undo", title: a.history.undo }) }, redo: function (a, b) { return c(b.iconPrefix + b.icons.history.redo, { event: "redo", title: a.history.redo }) }, hr: function (a, b) { return c(b.iconPrefix + b.icons.hr.insert, { event: "insertHorizontalRule", title: a.hr.insert }) }
        }, h = function (e, f) { var h = function () { var a = c(f.iconPrefix + f.icons.link.edit, { title: e.link.edit, event: "showLinkDialog", hide: !0 }), b = c(f.iconPrefix + f.icons.link.unlink, { title: e.link.unlink, event: "unlink" }), g = '<a href="http://www.google.com" target="_blank">www.google.com</a>&nbsp;&nbsp;<div class="note-insert btn-group">' + a + b + "</div>"; return d("note-link-popover", g) }, i = function () { var a = b('<span class="note-fontsize-10">100%</span>', { title: e.image.resizeFull, event: "resize", value: "1" }), g = b('<span class="note-fontsize-10">50%</span>', { title: e.image.resizeHalf, event: "resize", value: "0.5" }), h = b('<span class="note-fontsize-10">25%</span>', { title: e.image.resizeQuarter, event: "resize", value: "0.25" }), i = c(f.iconPrefix + f.icons.image.floatLeft, { title: e.image.floatLeft, event: "floatMe", value: "left" }), j = c(f.iconPrefix + f.icons.image.floatRight, { title: e.image.floatRight, event: "floatMe", value: "right" }), k = c(f.iconPrefix + f.icons.image.floatNone, { title: e.image.floatNone, event: "floatMe", value: "none" }), l = c(f.iconPrefix + f.icons.image.shapeRounded, { title: e.image.shapeRounded, event: "imageShape", value: "img-rounded" }), m = c(f.iconPrefix + f.icons.image.shapeCircle, { title: e.image.shapeCircle, event: "imageShape", value: "img-circle" }), n = c(f.iconPrefix + f.icons.image.shapeThumbnail, { title: e.image.shapeThumbnail, event: "imageShape", value: "img-thumbnail" }), o = c(f.iconPrefix + f.icons.image.shapeNone, { title: e.image.shapeNone, event: "imageShape", value: "" }), p = c(f.iconPrefix + f.icons.image.remove, { title: e.image.remove, event: "removeMedia", value: "none" }), q = (f.disableResizeImage ? "" : '<div class="btn-group">' + a + g + h + "</div>") + '<div class="btn-group">' + i + j + k + '</div><br><div class="btn-group">' + l + m + n + o + '</div><div class="btn-group">' + p + "</div>"; return d("note-image-popover", q) }, j = function () { for (var b = a("<div />"), c = 0, h = f.airPopover.length; h > c; c++) { for (var i = f.airPopover[c], j = a('<div class="note-' + i[0] + ' btn-group">'), k = 0, l = i[1].length; l > k; k++) { var m = a(g[i[1][k]](e, f)); m.attr("data-name", i[1][k]), j.append(m) } b.append(j) } return d("note-air-popover", b.children()) }, k = a('<div class="note-popover" />'); return k.append(h()), k.append(i()), f.airMode && k.append(j()), k }, l = function (a) { return '<div class="note-handle"><div class="note-control-selection"><div class="note-control-selection-bg"></div><div class="note-control-holder note-control-nw"></div><div class="note-control-holder note-control-ne"></div><div class="note-control-holder note-control-sw"></div><div class="' + (a.disableResizeImage ? "note-control-holder" : "note-control-sizing") + ' note-control-se"></div>' + (a.disableResizeImage ? "" : '<div class="note-control-selection-info"></div>') + "</div></div>" }, m = function (a, b) { var c = "note-shortcut-col col-xs-6 note-shortcut-", d = []; for (var e in b) b.hasOwnProperty(e) && d.push('<div class="' + c + 'key">' + b[e].kbd + '</div><div class="' + c + 'name">' + b[e].text + "</div>"); return '<div class="note-shortcut-row row"><div class="' + c + 'title col-xs-offset-6">' + a + '</div></div><div class="note-shortcut-row row">' + d.join('</div><div class="note-shortcut-row row">') + "</div>" }, o = function (a) { var b = [{ kbd: "⌘ + B", text: a.font.bold }, { kbd: "⌘ + I", text: a.font.italic }, { kbd: "⌘ + U", text: a.font.underline }, { kbd: "⌘ + \\", text: a.font.clear }]; return m(a.shortcut.textFormatting, b) }, p = function (a) { var b = [{ kbd: "⌘ + Z", text: a.history.undo }, { kbd: "⌘ + ⇧ + Z", text: a.history.redo }, { kbd: "⌘ + ]", text: a.paragraph.indent }, { kbd: "⌘ + [", text: a.paragraph.outdent }, { kbd: "⌘ + ENTER", text: a.hr.insert }]; return m(a.shortcut.action, b) }, q = function (a) { var b = [{ kbd: "⌘ + ⇧ + L", text: a.paragraph.left }, { kbd: "⌘ + ⇧ + E", text: a.paragraph.center }, { kbd: "⌘ + ⇧ + R", text: a.paragraph.right }, { kbd: "⌘ + ⇧ + J", text: a.paragraph.justify }, { kbd: "⌘ + ⇧ + NUM7", text: a.lists.ordered }, { kbd: "⌘ + ⇧ + NUM8", text: a.lists.unordered }]; return m(a.shortcut.paragraphFormatting, b) }, r = function (a) { var b = [{ kbd: "⌘ + NUM0", text: a.style.normal }, { kbd: "⌘ + NUM1", text: a.style.h1 }, { kbd: "⌘ + NUM2", text: a.style.h2 }, { kbd: "⌘ + NUM3", text: a.style.h3 }, { kbd: "⌘ + NUM4", text: a.style.h4 }, { kbd: "⌘ + NUM5", text: a.style.h5 }, { kbd: "⌘ + NUM6", text: a.style.h6 }]; return m(a.shortcut.documentStyle, b) }, s = function (a, b) { var c = b.extraKeys, d = []; for (var e in c) c.hasOwnProperty(e) && d.push({ kbd: e, text: c[e] }); return m(a.shortcut.extraKeys, d) }, t = function (a, b) { var c = 'class="note-shortcut note-shortcut-col col-sm-6 col-xs-12"', d = ["<div " + c + ">" + p(a, b) + "</div><div " + c + ">" + o(a, b) + "</div>", "<div " + c + ">" + r(a, b) + "</div><div " + c + ">" + q(a, b) + "</div>"]; return b.extraKeys && d.push("<div " + c + ">" + s(a, b) + "</div>"), '<div class="note-shortcut-row row">' + d.join('</div><div class="note-shortcut-row row">') + "</div>" }, u = function (a) { return a.replace(/⌘/g, "Ctrl").replace(/⇧/g, "Shift") }, v = { image: function (a, b) { var c = ""; if (b.maximumImageFileSize) { var d = Math.floor(Math.log(b.maximumImageFileSize) / Math.log(1024)), f = 1 * (b.maximumImageFileSize / Math.pow(1024, d)).toFixed(2) + " " + " KMGTP"[d] + "B"; c = "<small>" + a.image.maximumFileSize + " : " + f + "</small>" } var g = '<div class="form-group row note-group-select-from-files"><label>' + a.image.selectFromFiles + '</label><input class="note-image-input form-control" type="file" name="files" accept="image/*" multiple="multiple" />' + c + '</div><div class="form-group row"><label>' + a.image.url + '</label><input class="note-image-url form-control col-md-12" type="text" /></div>', h = '<button href="#" class="btn btn-primary note-image-btn disabled" disabled>' + a.image.insert + "</button>"; return e("note-image-dialog", a.image.insert, g, h) }, link: function (a, b) { var c = '<div class="form-group row"><label>' + a.link.textToDisplay + '</label><input class="note-link-text form-control col-md-12" type="text" /></div><div class="form-group row"><label>' + a.link.url + '</label><input class="note-link-url form-control col-md-12" type="text" value="http://" /></div>' + (b.disableLinkTarget ? "" : '<div class="checkbox"><label><input type="checkbox" checked> ' + a.link.openInNewWindow + "</label></div>"), d = '<button href="#" class="btn btn-primary note-link-btn disabled" disabled>' + a.link.insert + "</button>"; return e("note-link-dialog", a.link.insert, c, d) }, help: function (a, b) { var c = '<a class="modal-close pull-right" aria-hidden="true" tabindex="-1">' + a.shortcut.close + '</a><div class="title">' + a.shortcut.shortcuts + "</div>" + (i.isMac ? t(a, b) : u(t(a, b))) + '<p class="text-center"><a href="//summernote.org/" target="_blank">Summernote 0.6.16</a> · <a href="//github.com/summernote/summernote" target="_blank">Project</a> · <a href="//github.com/summernote/summernote/issues" target="_blank">Issues</a></p>'; return e("note-help-dialog", "", c, "") } }, w = function (b, c) { var d = ""; return a.each(v, function (a, e) { d += e(b, c) }), '<div class="note-dialog">' + d + "</div>" }, x = function () { return '<div class="note-resizebar"><div class="note-icon-bar"></div><div class="note-icon-bar"></div><div class="note-icon-bar"></div></div>' }, y = function (a) { return i.isMac && (a = a.replace("CMD", "⌘").replace("SHIFT", "⇧")), a.replace("BACKSLASH", "\\").replace("SLASH", "/").replace("LEFTBRACKET", "[").replace("RIGHTBRACKET", "]") }, z = function (b, c, d) { var e = j.invertObject(c), f = b.find("button"); f.each(function (b, c) { var d = a(c), f = e[d.data("event")]; f && d.attr("title", function (a, b) { return b + " (" + y(f) + ")" }) }).tooltip({ container: "body", trigger: "hover", placement: d || "top" }).on("click", function () { a(this).tooltip("hide") }) }, A = function (b, c) { var d = c.colors; b.find(".note-color-palette").each(function () { for (var b = a(this), c = b.attr("data-target-event"), e = [], f = 0, g = d.length; g > f; f++) { for (var h = d[f], i = [], j = 0, k = h.length; k > j; j++) { var l = h[j]; i.push(['<button type="button" class="note-color-btn" style="background-color:', l, ';" data-event="', c, '" data-value="', l, '" title="', l, '" data-toggle="button" tabindex="-1"></button>'].join("")) } e.push('<div class="note-color-row">' + i.join("") + "</div>") } b.html(e.join("")) }) }; this.createLayoutByAirMode = function (b, c) { var d = c.langInfo, e = c.keyMap[i.isMac ? "mac" : "pc"], f = j.uniqueId(); b.addClass("note-air-editor note-editable panel-body"), b.attr({ id: "note-editor-" + f, contentEditable: !0 }); var g = document.body, k = a(h(d, c)); k.addClass("note-air-layout"), k.attr("id", "note-popover-" + f), k.appendTo(g), z(k, e), A(k, c); var m = a(l(c)); m.addClass("note-air-layout"), m.attr("id", "note-handle-" + f), m.appendTo(g); var n = a(w(d, c)); n.addClass("note-air-layout"), n.attr("id", "note-dialog-" + f), n.find("button.close, a.modal-close").click(function () { a(this).closest(".modal").modal("hide") }), n.appendTo(g) }, this.createLayoutByFrame = function (b, c) { var d = c.langInfo, e = a('<div class="note-editor panel panel-default" />'); c.width && e.width(c.width), c.height > 0 && a('<div class="note-statusbar">' + (c.disableResizeEditor ? "" : x()) + "</div>").prependTo(e); var f = a('<div class="note-editing-area" />'), j = !b.is(":disabled"), k = a('<div class="note-editable panel-body" contentEditable="' + j + '"></div>').prependTo(f); c.height && k.height(c.height), c.direction && k.attr("dir", c.direction); var m = b.attr("placeholder") || c.placeholder; m && k.attr("data-placeholder", m), k.html(n.html(b) || n.emptyPara), a('<textarea class="note-codable"></textarea>').prependTo(f); var o = a(h(d, c)).prependTo(f); A(o, c), z(o, D), a(l(c)).prependTo(f), f.prependTo(e); for (var p = a('<div class="note-toolbar panel-heading" />'), q = 0, r = c.toolbar.length; r > q; q++) { for (var s = c.toolbar[q][0], t = c.toolbar[q][1], u = a('<div class="note-' + s + ' btn-group" />'), v = 0, y = t.length; y > v; v++) { var B = g[t[v]]; if (a.isFunction(B)) { var C = a(B(d, c)); C.attr("data-name", t[v]), u.append(C) } } p.append(u) } var D = c.keyMap[i.isMac ? "mac" : "pc"]; A(p, c), z(p, D, "bottom"), p.prependTo(e), a('<div class="note-dropzone"><div class="note-dropzone-message"></div></div>').prependTo(e); var E = c.dialogsInBody ? a(document.body) : e, F = a(w(d, c)).prependTo(E); F.find("button.close, a.modal-close").click(function () { a(this).closest(".modal").modal("hide") }), e.insertAfter(b), b.hide() }, this.hasNoteEditor = function (a) { return this.noteEditorFromHolder(a).length > 0 }, this.noteEditorFromHolder = function (b) { return b.hasClass("note-air-editor") ? b : b.next().hasClass("note-editor") ? b.next() : a() }, this.createLayout = function (a, b) { b.airMode ? this.createLayoutByAirMode(a, b) : this.createLayoutByFrame(a, b) }, this.layoutInfoFromHolder = function (a) { var b = this.noteEditorFromHolder(a); if (b.length) return b.data("holder", a), n.buildLayoutInfo(b) }, this.removeLayout = function (a, b, c) { c.airMode ? (a.removeClass("note-air-editor note-editable").removeAttr("id contentEditable"), b.popover().remove(), b.handle().remove(), b.dialog().remove()) : (a.html(b.editable().html()), c.dialogsInBody && b.dialog().remove(), b.editor().remove(), a.show()) }, this.getTemplate = function () { return { button: b, iconButton: c, dialog: e } }, this.addButtonInfo = function (a, b) { g[a] = b }, this.addDialogInfo = function (a, b) { v[a] = b }
    }; a.summernote = a.summernote || {}, a.extend(a.summernote, p); var O = new N, P = new M; a.extend(a.summernote, { renderer: O, eventHandler: P, core: { agent: i, list: k, dom: n, range: o }, pluginEvents: {}, plugins: [] }), a.summernote.addPlugin = function (b) { a.summernote.plugins.push(b), b.buttons && a.each(b.buttons, function (a, b) { O.addButtonInfo(a, b) }), b.dialogs && a.each(b.dialogs, function (a, b) { O.addDialogInfo(a, b) }), b.events && a.each(b.events, function (b, c) { a.summernote.pluginEvents[b] = c }), b.langs && a.each(b.langs, function (b, c) { a.summernote.lang[b] && a.extend(a.summernote.lang[b], c) }), b.options && a.extend(a.summernote.options, b.options) }, a.fn.extend({ summernote: function () { var b = a.type(k.head(arguments)), c = "string" === b, d = "object" === b, e = d ? k.head(arguments) : {}; if (e = a.extend({}, a.summernote.options, e), e.icons = a.extend({}, a.summernote.options.icons, e.icons), e.langInfo = a.extend(!0, {}, a.summernote.lang["en-US"], a.summernote.lang[e.lang]), !c && d) for (var f = 0, g = a.summernote.plugins.length; g > f; f++) { var h = a.summernote.plugins[f]; e.plugin[h.name] && (a.summernote.plugins[f] = a.extend(!0, h, e.plugin[h.name])) } this.each(function (b, c) { var d = a(c); if (!O.hasNoteEditor(d)) { O.createLayout(d, e); var f = O.layoutInfoFromHolder(d); d.data("layoutInfo", f), P.attach(f, e), P.attachCustomEvent(f, e) } }); var i = this.first(); if (i.length) { var j = O.layoutInfoFromHolder(i); if (c) { var l = k.head(k.from(arguments)), m = k.tail(k.from(arguments)), n = [l, j.editable()].concat(m); return P.invoke.apply(P, n) } e.focus && j.editable().focus() } return this }, code: function (b) { if (void 0 === b) { var c = this.first(); if (!c.length) return; var d = O.layoutInfoFromHolder(c), e = d && d.editable(); if (e && e.length) { var f = P.invoke("codeview.isActivated", d); return P.invoke("codeview.sync", d), f ? d.codable().val() : d.editable().html() } return n.value(c) } return this.each(function (c, d) { var e = O.layoutInfoFromHolder(a(d)), f = e && e.editable(); f && f.html(b) }), this }, destroy: function () { return this.each(function (b, c) { var d = a(c); if (O.hasNoteEditor(d)) { var e = O.layoutInfoFromHolder(d), f = e.editor().data("options"); P.detach(e, f), O.removeLayout(d, e, f) } }), this } })
});

/*FileTree */

if (jQuery) (function ($) {

    $.extend($.fn, {
        fileTree: function (o, h) {
            // Defaults
            if (!o) var o = {};
            if (o.root == undefined) o.root = '/';
            if (o.script == undefined) o.script = 'jqueryFileTree.php';
            if (o.folderEvent == undefined) o.folderEvent = 'click';
            if (o.expandSpeed == undefined) o.expandSpeed = 500;
            if (o.collapseSpeed == undefined) o.collapseSpeed = 500;
            if (o.expandEasing == undefined) o.expandEasing = null;
            if (o.collapseEasing == undefined) o.collapseEasing = null;
            if (o.multiFolder == undefined) o.multiFolder = true;
            if (o.loadMessage == undefined) o.loadMessage = 'Loading...';

            $(this).each(function () {

                function showTree(c, t) {
                    $(c).addClass('wait');
                    $(".jqueryFileTree.start").remove();
                    $.post(o.script, { dir: t }, function (data) {
                        $(c).find('.start').html('');
                        $(c).removeClass('wait').append(data);
                        if (o.root == t) $(c).find('UL:hidden').show(); else $(c).find('UL:hidden').slideDown({ duration: o.expandSpeed, easing: o.expandEasing });
                        bindTree(c);
                    });
                }

                function bindTree(t) {
                    $(t).find('LI A').bind(o.folderEvent, function () {
                        if ($(this).parent().hasClass('directory')) {
                            if ($(this).parent().hasClass('collapsed')) {
                                // Expand
                                if (!o.multiFolder) {
                                    $(this).parent().parent().find('UL').slideUp({ duration: o.collapseSpeed, easing: o.collapseEasing });
                                    $(this).parent().parent().find('LI.directory').removeClass('expanded').addClass('collapsed');
                                }
                                $(this).parent().find('UL').remove(); // cleanup
                                showTree($(this).parent(), escape($(this).attr('rel').match(/.*\//)));
                                $(this).parent().removeClass('collapsed').addClass('expanded');
                            } else {
                                // Collapse
                                $(this).parent().find('UL').slideUp({ duration: o.collapseSpeed, easing: o.collapseEasing });
                                $(this).parent().removeClass('expanded').addClass('collapsed');
                            }
                        } else {
                            h($(this).attr('rel'));
                        }
                        return false;
                    });
                    // Prevent A from triggering the # on non-click events
                    if (o.folderEvent.toLowerCase != 'click') $(t).find('LI A').bind('click', function () { return false; });
                }
                // Loading message
                $(this).html('<ul class="jqueryFileTree start"><li class="wait">' + o.loadMessage + '<li></ul>');
                // Get the initial file list
                showTree($(this), escape(o.root));
            });
        }
    });

})(jQuery);
function IQAutoSave(url, elem) {
    if ($(elem).attr("type") == "checkbox") {

        $(elem).css('border', '1px solid #c19716');
        $.post(url, { NewValue: $(elem).is(":checked") ? "true" : "false", ScreenInfo: $(elem).attr("data-ScreenInfo") }, function (data) {
            eval(data);
            $(elem).css('border', '1px solid #0ac964');
        });
    } else {
        $(elem).css('border', '1px solid #c19716');
        var NewVal = $(elem).val();
        if ($(elem).hasClass("searchautocomplete")) {
            NewVal = "";
            var a = $(elem).select2("data");

            for (index = 0; index < a.length; ++index) {
                NewVal += a[index].id + ",";
            }
        }

        $.post(url, { NewValue: NewVal, ScreenInfo: $(elem).attr("data-ScreenInfo") }, function (data) {
            eval(data);
            $(elem).css('border', '1px solid #0ac964');
        });
    }
}
var IQPopupTarget = "";

function IQPopupEditor(itm) {
    IQPopupTarget = $(itm).attr("data-target")
    var elem = $(IQPopupTarget);
    $("#PopupEditorArea").val(elem.val());
    $("#PopupEditorLabel").html(elem.attr("data-Label"));

    $("#PopupEditor").modal('show');
}
function IQPopupEditorClose() {
       
    var elem = $(IQPopupTarget);
    elem.val($("#PopupEditorArea").val()).change();
    $("#PopupEditor").modal('hide');
}

function IQTargetButton(obj) {
    $.pjax({ url: $(obj).attr("data-url") + $($(obj).attr("data-target")).val(), container: "#Main" , timeout:3000});
}
function IQJSCall(url, elem) {
    if (!elem) elem = "form";

    $.post(url, $(elem).find("input,select,textarea").serialize(), function (data) {
        eval(data);
        AutoComplete();
    });
}
function IQRealSubmit(url) {
    $("form").attr("action", url);
    $("form").submit();
}

function ShowLoading() {
    $("#LoadingIndictaor").css('display', 'inline');
}

function HideLoading() {
    $("#LoadingIndictaor").css('display', 'none');
}
function IQDirtyCallback(url, elem) {

    $.post(url, $("form").serialize(), function (data) {
        eval(data);
        PostLoadComplete();
    });
}

var dirty = false;
function IQDirty() {
    if (!dirty) {
        window.onbeforeunload = function (e) {
            if (dirty) {
                e = e || window.event;
                // For IE and Firefox
                if (e) {
                    e.returnValue = "You have not yet saved this record!";
                }
                // For Safari
                return "You have not yet saved this record!";
            }
        };
        dirty = true;
    }
}

function AddAlert() {
    $("input[name=Alert_Title]").val($("input[name=CurrentTitle]").val());
    $('#AddAlertScreen').modal();
}
function RemoveAlert() {
    $("form").attr("action", "/IQAlerts/RemoveAlert/");
    $("form").submit();
}
function ChangePassword() {
    $("#ChangePasswordScreen").modal();
}


/****************** Dataset Search ********************/
function DSSearch_ToggleSort(field, sort, dfid, itm) {
 //   $(".sortDown:not(.hide)").addClass("hide");
 //   $(".sortUp:not(.hide)").addClass("hide");
 //   $(".sortUpDown").removeClass("hide");

    var curVal = $("*[name=" + field + "]").val();
    if (curVal == dfid) {

        var sortval = $("*[name=" + sort + "]").val();
        if (sortval == 0) {
         //   $(itm).find(".sortUp").removeClass("hide");
            $("*[name=" + sort + "]").val(1).change();
        } else {
          //  $(itm).find(".sortDown").removeClass("hide");
            $("*[name=" + sort + "]").val(0).change();
        }

    } else {
       // $(itm).find(".sortUpDown").removeClass("hide");
     //   $(itm).find(".sortUpDown").addClass("hide");
        $("*[name=" + sort + "]").val(0);
        $("*[name=" + field + "]").val(dfid).change();
    }
}
function DSSearch_AddField(clientdir) {
    var dfid = $("select[name=FieldAdd] option:selected");
    $("#FieldList").append("<li class='ui-state-default' id='FieldCol-" + dfid.attr("value") + "'><input type='hidden' class='FieldPos' name='Field-"
            + dfid.attr("value") + "' value='100' /><label style='display:inline-block;width:50%;cursor:hand;padding-left:5px;'><a href='#' onclick='javascript:$(\"#FieldCol-" 
            + dfid.attr("value") + "\").remove();'><img src='/" + clientdir + "/trash.png' style='height:15px;margin-right:2px;float:right' /></a>" + dfid.html() + "</label><input type='number' class='form-control'  style='display:inline-block;width:50%;' name='FieldWidth-"
            + dfid.attr("value") + "' value='100'/></li>");

}
function DSSearch_SelectAll(itm) {
    if ($(itm).val() == "Select All") {
        $("input[name=AllSelected]").val("true");
        $("input[name=RecordIDs]").prop("checked", true);
        $(itm).val("Unselect All");
    } else {
        $("input[name=AllSelected]").val("false");
        $("input[name=RecordIDs]").prop("checked",false);
        $(itm).val("Select All");
    }
    DSSearch_RecordIDChange();
}
function DSSearch_SelectPage(itm) {
    if ($(itm).val() == "Select Page") {
        $("input[name=RecordIDs]").prop("checked", true);
    } else {
        $("input[name=RecordIDs]").prop("checked", false);
    }
    DSSearch_RecordIDChange();
}
function DSSearch_RecordIDChange() {
    if ($("input[name=RecordIDs]:checked").length > 0) 
        $("#CheckPage").val("Uncheck Page");
   else
        $("#CheckPage").val("Select Page");
    DSSearch_CheckSelected();
}
function DSSearch_CheckSelected() {
    if ($("input[name=AllSelected]").val() == "true") {

        $("#TotalSelected").html($("#TotalResults").html());
    } else {
        $("#TotalSelected").html($("input[name=RecordIDs]:checked").length);
    }
}
function DSSearch_RunPageAction(url) {
    $("form").removeClass("search");
    $("form").attr("action", url);
    $("form").submit();
}
function DSSearch_UpdateOp(id, obj) {
    searchData.$(obj).val();
}
function DSSearch_RunSearch(url) {
    var href = url + (url.indexOf("?") == -1 ? "?" : "&") + $("form").serialize();
    $("#resultsView").load(href);
}
function DSSearch_AddFilter(url) {
    $.post(url, { FieldToFilter: $("select[name=FieldToFilter]").val(), NoOfExtraFilters: $("input[name=NoOfExtraFilters]").val() }, function (data) {
        $("#FiltersList").append(data);
        var noextra = parseInt($("input[name=NoOfExtraFilters]").val());
        noextra += 1;
        $("input[name=NoOfExtraFilters]").val(noextra);
        $("select[name=FieldToFilter]:selected").removeAttr('selected').attr('disabled', 'disabled');
        $("#AddFilterModel").modal('hide');

    });
}
function DSSearch_RemoveFilter(dfid, selector, url) {
    $(selector).remove();
    $("select[name=FieldToFilter]").find("option[value=" + dfid + "]").removeAttr('disabled');
    setTimeout(function () {
        DSSearch_RunSearch(url);
    }, 500);
}

var FileTarget = "";
var MultipleFiles = false;
function ShowFilePicker(Target, Multiple) {
    FileTarget = Target;
    MultipleFiles = Multiple;
    $("#FilePickerDialogBox").modal();

}

function IQSearch(url) {
    
    $("#Results").load(url, $("form").serialize());
}

function IQSaveRecord(url) {

    var canSave = true;
    $(".mandatory").each(function () {
        if ($(this).val == "" || $(this).val() == "0")
            canSave = false;
    });
    if (!canSave) {
        alert("You must complete all mandatory fields before saving.");
        return;
    }
    dirty = false;
    $("form").attr("action", url);

    $("form").submit();

}
function UploadFiles() {
    $("#FileUploadProgress").css("display", "block");
    var formData = new FormData($('form').get(0));
    $.ajax({
        url: '/IQFiles/Upload',  //Server script to process data
        type: 'POST',
        xhr: function () {  // Custom XMLHttpRequest
            var myXhr = $.ajaxSettings.xhr();
            if (myXhr.upload) { // Check if upload property exists
                myXhr.upload.addEventListener('progress', progressHandlingFunction, false); // For handling the progress of the upload
            }
            return myXhr;
        },
        //Ajax events
        // Form data
        data: formData,
        //Options to tell jQuery not to process data or worry about content-type.
        cache: false,
        contentType: false,
        processData: false,
        success: function (data) {
            $("#SelectedFile").html(data);
            $("#FileUploadProgress").css("display", "none");
            var control =  $("UploadFile");
            //   control.wrap('<form>').closest('form').get(0).reset
            
            $("#ConfirmFileSelection").removeAttr("disabled");
        }
    });
}

function UploadFileFM() {
    $("#FileUploadProgress").css("display", "block");
    var formData = new FormData($('form').get(0));
    $.ajax({
        url: '/IQFiles/UploadFM',  //Server script to process data
        type: 'POST',
        xhr: function () {  // Custom XMLHttpRequest
            var myXhr = $.ajaxSettings.xhr();
            if (myXhr.upload) { // Check if upload property exists
                myXhr.upload.addEventListener('progress', progressHandlingFunction, false); // For handling the progress of the upload
            }
            return myXhr;
        },
        //Ajax events
        // Form data
        data: formData,
        //Options to tell jQuery not to process data or worry about content-type.
        cache: false,
        contentType: false,
        processData: false,
        success: function (data) {
            location.reload();
        }
    });
}
function IQRemoveFile(uid) {
    var control = $("#" + uid).parent();
    var target = $("#" + uid).attr("data-target");
    var mode = $("#" + uid).attr("data-mode");
    $("#" + uid).remove();
    var newVal = "";
    control.find(".FileHolder").each(function () {
        newVal += $(this).attr("data-file") + ";";
    });
    $(mode).modal('hide');
    $(".modal-backdrop").remove();
    $(target).val(newVal).change();

}
function progressHandlingFunction(e) {
    if (e.lengthComputable) {
        var valeur = e.loaded / e.total*100;
        $("#FileUploadProgress").css('width', valeur+'%').attr('aria-valuenow', valeur);
    }
}
function FileChosen() {
    var f = $("#SelectedFile").html();
    if (f != "") {
        if (MultipleFiles)
            $(FileTarget).val($(FileTarget).val() + ";" + f).change();
        else
            $(FileTarget).val(f).change();
    }
    $("#FilePickerDialogBox").modal("hide");
}

/****************** End Dataset Search ********************/
$(document).ready(function () {
    $(document).on("change", "select.DSSearch_RunSearch", function () {
        DSSearch_RunSearch($(this).attr("data-url"));
    })
});

var theSelect2Element;
function PostLoadComplete() {
    ShowLoading();
    AutoComplete();
    // hook up dynamic content items
    //

    var observer = new MutationObserver(function (mutations) {
        for (var i = 0; i < mutations.length; i++) {
            if ($(mutations[i].target).hasClass("DynamicTab")) {
                $(mutations[i].target).removeClass("DynamicTab");
                var id = $(mutations[i].target).attr("data-LoadTarget");
                var url = $(mutations[i].target).attr("data-dynamicContent");
                $(id).load((url));
            }
        }
    });
    $(".DynamicTab").each(function () {

        observer.observe($(this)[0], {
            attributes: true
        });
    });

   


    $('.RichEditor').each(function () {
        $(this).summernote({
            onKeyup: function (e) {
                $($(this).attr("data-target")).val($(this).code()).change();
            },
            onInit: function () {
                $(this).next().attr("style", $(this).attr("style"))
                $(this).next().css("display", "block");
                if ($(this).attr("data-disabled")) {
                    $(".note-editor").find("button").attr("disabled", true);
                    $(".note-editable").removeAttr("contenteditable");
                    $(".note-editable").css("background-color", "lightgrey");

                    $(".note-editor").css("background-color", "lightgrey");
                }
            },
            height: $(this).height()-50,
            toolbar: [
        ['style', ['style']],
        ['font', ['bold', 'italic', 'underline', 'clear']],
        ['fontname', ['fontname']],
        ['color', ['color']],
        ['para', ['ul', 'ol', 'paragraph']],
        ['height', ['height']],
        ['table', ['table']],
        ['insert', ['link', 'hr']],
        ['view', ['codeview']]
            ],
        });
    });
    $("select[name=QuickSearch]").select2({
        ajax: {
            url: "/IQSearch/Search",
            dataType: "json",
            delay: 100,
            processResults: function (data, page) {
                return data;
            },

            cache: true
        },
        minimumInputLength: 1
    });
    $("select[name=QuickSearch]").on("select2:select", function (e) {
        location.href = $(e.currentTarget).select2("data")[0].id;
    });
    
  
  //  $(document).on("change.dp", function () { $(this).trigger("change"); });

    $("form").submit(function () {
        $("input,select").attr("disabled", false);
    });

  //  $(".searchautocomplete").focus(function () { $(this).select2("open"); });

 /*   $(document).on('focus', '.select2', function () {
        $(this).siblings('select').select2('open');
    });*/
    $('#directoryStructure').fileTree({ root: '/', script:'/IQFiles/FileListing/' }, 
                function(file) { 
                    $("#SelectedFile").html(file);
                    $("#FileUploadProgress").css("display", "none");
                    $("#ConfirmFileSelection").removeAttr("disabled");
                },
                function(dir) { 
                    $('.FilePathToUpload').html(dir);  
                    $('input[name=directory]').val(dir);
                });

    $(".modal").modal('hide');
    EveryRequest();
    HideLoading();
}

function EveryRequest() {
   

}

function AutoComplete() {
    $(".select2-hidden-accessible").removeClass("select2-hidden-accessible");
    $(".select2").remove();
    $("select.searchable").select2();

    $("select.searchautocomplete:not(.hide):not(.mandatory)").select2({
        ajax: {
            dataType: "json",
            delay: 100,
            processResults: function (data, page) {
                return data;
            },
            cache: true
        },
        minimumInputLength: 1,
        query: function (query) {
            $.post($(theSelect2Element).attr("data-ajax--url") + "?q=" + query.term,
               $("form").serialize(),
               function (data) {
                   query.callback(data);
               }, 'json'
           );
        }
    }).on('select2:open', function (e) { theSelect2Element = e.currentTarget; });

    $("select.searchautocomplete.mandatory:not(.hide)").select2({
        ajax: {
            dataType: "json",
            delay: 100,
            processResults: function (data, page) {
                return data;
            },
            cache: true
        },
        minimumInputLength: 1,
        containerCssClass: "mandatory",
        query: function (query) {
            $.post($(theSelect2Element).attr("data-ajax--url") + "?q=" + query.term,
             $("form").serialize(),
             function (data) {
                 query.callback(data);
             }, 'json'
         );
        }
    }).on('select2:open', function (e) { theSelect2Element = e.currentTarget; });


    $("select.searchautocomplete:not(.hide)").each(function () {
        $(this).data('select2').$container.attr('style', $(this).attr('style'));
    });

  
    $(".select2-container--default .select2-selection--single").css("width", "100%");
    $(".select2-container--default .select2-selection--single").css("height", "21px");

    $(".input-group>.select2.select2-container").each(function () {
        $(this).css("width", ($(this).parents(".input-group").attr("data-OriginalWidth") - 22).toString() + "px");
    });
}

function ShowDatePicker(elem) {
    var val = $(elem).val();

    $(elem).datetimepicker({
        format: 'DD.MM.YYYY',
        extraFormats: ['dd/mm/yyyy'],
        useCurrent: false, defaultDate: val
    });
    if (val != '') {
        var dt;
        if (val.indexOf('.') !== -1)
            dt = moment(val, 'D.M.YYYY');
        else if (val.indexOf('/') != -1)
            dt = moment(val, 'D/M/Y');
        else
            dt = moment(val);

        $(elem).data("DateTimePicker").date(dt);

    }

    $(elem).data("DateTimePicker").show();

    $(elem).on("dp.hide", function () {
        $(elem).data("DateTimePicker").destroy();
    });


    $(elem).on("dp.change", function () { $(this).trigger("change"); });
}

